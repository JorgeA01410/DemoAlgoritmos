
using Prueba.Algoritmos;
namespace Prueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Paso 0: Condicion de vacio
            if (textBox1.Text.Equals("") ||
                textBox2.Text.Equals("") ||
                textBox3.Text.Equals(""))
            {
                MessageBox.Show("El campo no puede estar vacio");
                return;
            }

            // Paso 1: Inicializacion de parametros
            int semilla1 = Convert.ToInt32(textBox1.Text);
            int semilla2 = Convert.ToInt32(textBox2.Text);
            int cantidad = Convert.ToInt32(textBox3.Text);
            // Paso 2: Declarar clase algoritmo de generacion de numeros pseudoaleatorios
            Algoritmo algoritmo = new Algoritmo();

            // Paso 3: LLamar medoto principal
            (List<int> val1, List<int> val2, List<int> productos, List<int> Rn, List<int> Rn1, List<int> sinext) = algoritmo.GenerarNumeros(semilla1, semilla2, cantidad);




            // Paso 4: Llenar el grid
            llenarGrid(val1, val2, productos, Rn, Rn1, sinext);



        }

        public void llenarGrid(List<int> val1, List<int> val2, List<int> productos, List<int> Rn, List<int> Rn1, List<int> sinext)
        {
            // Paso 0: Indicas el numero de columnas
            string numeroColumna1 = "1";
            string numeroColumna2 = "2";
            string numeroColumna3 = "3";
            string numeroColumna4 = "4";
            string numeroColumna5 = "5";
            string numeroColumna6 = "6";
            string numeroColumna7 = "7";



            // Paso 1: Determinas la cantidad de columnas
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add(numeroColumna1, "n");
            dataGridView1.Columns.Add(numeroColumna2, "R(n)");
            dataGridView1.Columns.Add(numeroColumna3, "R(n+1)");
            dataGridView1.Columns.Add(numeroColumna4, "R(n)^2");
            dataGridView1.Columns.Add(numeroColumna5, "M.R(n)^2");
            dataGridView1.Columns.Add(numeroColumna6, "Val 1");
            dataGridView1.Columns.Add(numeroColumna7, "Val 2");

            // Paso 2: Recorrer el grid y llenar cada fila
            for (int i = 0; i < val1.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna1) - 1].Value = (i).ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna6) - 1].Value = val1[i].ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna4) - 1].Value = productos[i].ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna2) - 1].Value = Rn[i].ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna3) - 1].Value = Rn1[i].ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna5) - 1].Value = sinext[i].ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna7) - 1].Value = val2[i].ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
