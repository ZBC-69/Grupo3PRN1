using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            //VERIFICAR SI SE CUMPLE LA CONDICION DE SER APROBADO O REPROBADO
            decimal NotaMate;
            decimal NotaLengua;
            decimal NotaInformat;
            decimal NotaCiencias;
            decimal NotaSociales;
            decimal NotaArtistic;
            decimal NotaOPV;
            decimal NotaMoralyCivica;
            decimal NotaConducta;
            decimal Resultado;
            decimal Promedio;
            string NombreCompleto;
            string Nombre;


            Nombre = lbNombre.Text;
            NombreCompleto = tbNombre.Text;
            NotaMate = decimal.Parse(tbNotaMatematica.Text);
            NotaLengua = decimal.Parse(tbNotaLenguaje.Text);
            NotaInformat = decimal.Parse(tbNotaInformatica.Text);
            NotaCiencias = decimal.Parse(tbNotaCiencias.Text);
            NotaSociales = decimal.Parse(tbNotaSociales.Text);
            NotaArtistic = decimal.Parse(tbNotaArtistica.Text);
            NotaOPV = decimal.Parse(tbNotaOPV.Text);
            NotaMoralyCivica = decimal.Parse(tbNotaMoralCivica.Text);
            NotaConducta = decimal.Parse(tbNotaConducta.Text);


            Resultado = NotaMate + NotaLengua + NotaInformat + NotaCiencias + NotaSociales + NotaArtistic + NotaOPV + NotaMoralyCivica + NotaConducta;
            Promedio = Resultado / 9;

            lbResult.Text = Resultado.ToString("N2");
            lbPromedio.Text = Promedio.ToString("N2");


            
            if (Promedio >= 6)
            {
                lbEstado.Text = "APROBADO";
            }
            else
            
            {
                lbEstado.Text = "REPROBADO";
            }

            string[] dataToWrite = { Nombre.ToString(),NombreCompleto.ToString(), NotaMate.ToString("N2"), NotaLengua.ToString("N2"), NotaInformat.ToString("N2"), NotaCiencias.ToString("N2"),
                                     NotaSociales.ToString("N2"), NotaArtistic.ToString("N2"), NotaOPV.ToString("N2"), NotaMoralyCivica.ToString("N2"),
                                     NotaConducta.ToString("N2"), Resultado.ToString("N2"), Promedio.ToString("N2"), lbEstado.Text };

            string csvFilePath = "notas.csv";

            using (StreamWriter writer = new StreamWriter(csvFilePath, append: true))
            {
                writer.WriteLine(string.Join(",", dataToWrite));
            }

            MessageBox.Show("Datos guardados en el archivo CSV.");
        }
            

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbNombre.Text = "";
            tbNotaMatematica.Text = "";
            tbNotaLenguaje.Text = "";
            tbNotaInformatica.Text = "";
            tbNotaCiencias.Text = "";
            tbNotaSociales.Text = "";
            tbNotaArtistica.Text = "";
            tbNotaOPV.Text = "";
            tbNotaMoralCivica.Text = "";
            tbNotaConducta.Text = "";
            lbPromedio.Text = "";
            lbEstado.Text = "";
            lbResult.Text = "";





        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tbResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbNotaCiencias_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbNotaOrientParaLaVida_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
