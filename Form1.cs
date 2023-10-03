using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace JTDDV_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string apellido = textBox2.Text;
            string telefono = textBox3.Text;
            string estatura = textBox4.Text;
            string edad = textBox5.Text;
            string genero = "";

            if (radioButton1.Checked)
            {
                genero = "hombre";
            }
            else if (radioButton2.Checked)
            {
                genero = "mujer";
            }

            string datos = ($"nombre: {nombre}\r\napellido: {apellido}\r\nTelefono: {telefono}\r\nestatura {estatura}:\r\nedad{edad}\r\nGenero{genero}");

            string rutaArchivo = ("C:\\Users\\1116340557\\source\\repos\\JTDDV_05\"");

            bool archivoExiste = File.Exists(rutaArchivo);
            Console.WriteLine(archivoExiste);

            if (archivoExiste == false)
            {
                File.WriteAllText(rutaArchivo, datos);
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(rutaArchivo))
                {
                    if (archivoExiste)
                    {
                        writer.WriteLine();
                    }
                    writer.WriteLine(datos);
                }
            }
            MessageBox.Show($"datos guardados con éxito \n\n{datos}");
        
        }
        private void button2_click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
