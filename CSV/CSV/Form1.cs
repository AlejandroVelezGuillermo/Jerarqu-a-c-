using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CSV
{
    public partial class Form1 : Form
    {
        // Lista para almacenar los datos
        private List<registros> registros = new List<registros>();
        // Ruta del archivo CSV actualmente abierto
        private string rutaArchivoActual = "";

        string formato;
        public Form1()
        {
            InitializeComponent();
            // Establecer la propiedad DropDownStyle del ComboBox
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void aGREGARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AGREGAR();
        }
        private void AGREGAR() 
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtTelefono.Text) || string.IsNullOrWhiteSpace(txtCorreo.Text) || string.IsNullOrWhiteSpace(comboBox2.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de agregar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Crear un nuevo registro
            registros nuevoRegistro = new registros
            {
                Nombre = txtNombre.Text,
                Telefono = txtTelefono.Text,
                Correo = txtCorreo.Text,
                Asistencia = comboBox2.Text,
            };

            // Agregar el registro a la lista y al DataGridView
            registros.Add(nuevoRegistro);
            dgvDatos.DataSource = null; // Limpiar el origen de datos actual
            dgvDatos.DataSource = registros; // Asignar la nueva lista de registros
            LimpiarCampos();
        }
        private void gUARDARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SAVE();
        }
        private void SAVE() 
        {
            string NombreA = textBox1.Text;
            try
            {
                // Obtener la ruta del escritorio del usuario actual
                string escritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                // Crear la ruta completa del archivo CSV en el escritorio
                string rutaArchivo = Path.Combine(escritorio, NombreA + "." + formato);

                // Crear y escribir en el archivo CSV
                using (StreamWriter writer = new StreamWriter(rutaArchivo))
                {
                    // Escribir encabezados
                    writer.WriteLine("Nombre,Telefono,Correo,Asistencia");

                    // Escribir datos
                    foreach (registros registro in registros)
                    {
                        writer.WriteLine($"{registro.Nombre},{registro.Telefono},{registro.Correo}");
                    }
                }

                MessageBox.Show($"Datos guardados exitosamente en el archivo CSV en el escritorio ({rutaArchivo}).", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar en el archivo CSV: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Limpiar el DataGridView
            dgvDatos.DataSource = null;
            dgvDatos.Rows.Clear(); // Esto debería funcionar, pero si hay problemas, asegúrate de que el DataGridView está configurado correctamente

            // Limpiar la lista de registros
            registros.Clear();
        }
        private void LimpiarCampos()
        {
            LIMPIAR();
        }
        private void LIMPIAR()
        {
            // Limpiar los campos de entrada
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            textBox1.Text = "";
            comboBox2.Text = "";
        }
        private void aBRIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Diálogo para abrir el archivo CSV
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Archivos CSV |*.csv |Archivos Txt|*.txt|Archivos xml|*.xml|Archivos json|*.json|Todos Los Archivos|*.*",
                Title = "Archivos Cargados Correctamente."
            };


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtener la ruta del archivo seleccionado
                string rutaArchivo = openFileDialog.FileName;

                // Leer datos desde el archivo CSV
                using (StreamReader reader = new StreamReader(rutaArchivo))
                {
                    // Saltar la primera línea (encabezados)
                    reader.ReadLine();

                    // Limpiar la lista actual de registros
                    registros.Clear();

                    // Leer y agregar registros desde el archivo
                    while (!reader.EndOfStream)
                    {
                        string[] campos = reader.ReadLine().Split(',');
                        registros nuevoRegistro = new registros
                        {
                            Nombre = campos[0],
                            Telefono = campos[1],
                            Correo = campos[2]
                        };
                        registros.Add(nuevoRegistro);
                    }
                }

                // Mostrar los datos en el DataGridView
                dgvDatos.DataSource = null;
                dgvDatos.DataSource = registros;

                MessageBox.Show("Datos cargados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void rEMPLACARToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el valor seleccionado del ComboBox
            object valorSeleccionado = comboBox1.SelectedItem;

            // Si es una cadena, puedes convertirlo a string si es necesario
            if (valorSeleccionado != null)
            {
               formato = valorSeleccionado.ToString();
            }
        }
        private void eDITARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Verificar si hay al menos un renglón seleccionado
            if (dgvDatos.SelectedRows.Count > 0)
            {
                // Obtener el índice del primer renglón seleccionado
                int indiceSeleccionado = dgvDatos.SelectedRows[0].Index;

                // Obtener la fila completa del renglón seleccionado
                DataGridViewRow filaSeleccionada = dgvDatos.Rows[indiceSeleccionado];

                // Obtener los valores de todas las celdas del renglón
                string valorCelda0 = filaSeleccionada.Cells[0].Value.ToString();
                string valorCelda1 = filaSeleccionada.Cells[1].Value.ToString();
                string valorCelda2 = filaSeleccionada.Cells[2].Value.ToString();

                // Mostrar los valores en los TextBox
                txtNombre.Text = valorCelda0;
                txtTelefono.Text = valorCelda1;
                txtCorreo.Text = valorCelda2;
            }
        }
        private void ActualizarGrafico()
        {
            // Limpiar la serie del gráfico antes de actualizar
            chart1.Series.Clear();

            // Crear una nueva serie para la columna de asistencia
            Series seriesAsistencia = new Series("Asistencia");

            // Contar la cantidad de asistencias para cada opción
            var conteoAsistencias = registros
                .GroupBy(r => r.Asistencia)
                .Select(g => new { Asistencia = g.Key, Cantidad = g.Count() });

            // Agregar los puntos al gráfico
            foreach (var item in conteoAsistencias)
            {
                seriesAsistencia.Points.AddXY(item.Asistencia, item.Cantidad);
            }

            // Agregar la serie al gráfico
            chart1.Series.Add(seriesAsistencia);

            // Configurar el gráfico según tus preferencias
            chart1.ChartAreas[0].AxisX.Title = "Asistencia";
            chart1.ChartAreas[0].AxisY.Title = "Cantidad";
            chart1.Series["Asistencia"].ChartType = SeriesChartType.Column;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Array de nombres aleatorios
            string[] nombres = { "Juan", "María", "Pedro", "Ana", "Carlos", "Laura", "José", "Isabel", "Miguel", "Elena" };

            // Crear una instancia de la clase Random para generar números aleatorios
            Random random = new Random();

            // Obtener un índice aleatorio del array de nombres
            int indiceAleatorio = random.Next(nombres.Length);

            // Mostrar el nombre aleatorio en el TextBox
            txtNombre.Text = nombres[indiceAleatorio];
        }

        private string GenerarNumeroTelefono()
        {
            Random random = new Random();

            // Generar cada parte del número de teléfono
            string parte1 = random.Next(100, 1000).ToString("000");
            string parte2 = random.Next(100, 1000).ToString("000");
            string parte3 = random.Next(1000, 10000).ToString("0000");

            // Formar el número completo
            string numeroCompleto = $"({parte1}) {parte2}-{parte3}";

            return numeroCompleto;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Generar un número de teléfono aleatorio
            string numeroAleatorio = GenerarNumeroTelefono();

            // Mostrar el número aleatorio en el TextBox
            txtTelefono.Text = numeroAleatorio;
        }

        private string GenerarCorreoElectronico()
        {
            Random random = new Random();

            // Dominios de correo electrónico posibles
            string[] dominios = { "gmail.com", "yahoo.com", "outlook.com", "example.com", "domain.com" };

            // Generar una parte inicial del correo aleatoria
            string parteInicial = Guid.NewGuid().ToString().Substring(0, 8);

            // Seleccionar aleatoriamente un dominio
            string dominio = dominios[random.Next(dominios.Length)];

            // Formar la dirección de correo electrónico completa
            string correoCompleto = $"{parteInicial}@{dominio}";

            return correoCompleto;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Generar una dirección de correo electrónico aleatoria
            string correoAleatorio = GenerarCorreoElectronico();

            // Mostrar la dirección aleatoria en el TextBox
            txtCorreo.Text = correoAleatorio;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ActualizarGrafico();
        }
    }
}
