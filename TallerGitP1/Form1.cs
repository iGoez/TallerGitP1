using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TallerGitP1
{
    public partial class Form1 : Form
    {
        Informacion info;
        public Form1()
        {
            InitializeComponent();
            info = new Informacion();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pregunta4_Click(object sender, EventArgs e)
        {

        }

        private void pregunnta3_Click(object sender, EventArgs e)
        {

        }

        private void guardar_Click(object sender, EventArgs e)
        {
            

            info.P1 = textBox1.Text;
            info.P2 = textBox2.Text;
            info.P3 = textBox3.Text;
            info.P4 = textBox4.Text;
            info.P5 = textBox5.Text;
            info.P6 = textBox6.Text;
            info.P7 = textBox7.Text;
            info.P8 = textBox8.Text;


            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";

            info.escritura();
        }

        private void Cargar_Click(object sender, EventArgs e)
        {

        }
    }
}
