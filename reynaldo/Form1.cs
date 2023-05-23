using Capa_Datos.DTOs;
using Capa_Negocio;

namespace reynaldo
{
    public partial class Form1 : Form
    {

        CN_Estudiante CN_Estudiante = new();

        public Form1()
        {
            InitializeComponent();
            mostrar();
        }

        public void mostrar()
        {
            dataGridView1.DataSource = CN_Estudiante.MostrarEstudiantes();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            EstudianteCreacionDTOs creacionDTOs = new EstudianteCreacionDTOs();
            creacionDTOs.Nombre = txtnombre.Text;
            creacionDTOs.Apellido = txtapellido.Text;
            creacionDTOs.Telefono = txttelefono.Text;
            creacionDTOs.Correo = txtcorreo.Text;

            await CN_Estudiante.InsertarEstudiante(creacionDTOs);
            mostrar();


        }

  


        private async void btnEdit_Click(object sender, EventArgs e)
        {
           


            EstudianteDTO creacionDTOs = new ();
            creacionDTOs.Nombre = txtnombre.Text;
            creacionDTOs.Apellido = txtapellido.Text;
            creacionDTOs.Telefono = txttelefono.Text;
            creacionDTOs.Correo = txtcorreo.Text;
            creacionDTOs.EstudianteId =Convert.ToInt32( textBox1.Text);

            await CN_Estudiante.ActualizarEstudiante(creacionDTOs);
            mostrar();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        
        }
    }
}