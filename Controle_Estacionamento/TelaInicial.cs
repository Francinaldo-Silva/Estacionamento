using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_Estacionamento
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnV1_Click(object sender, EventArgs e)
        {
            Vaga vaga1 = new Vaga();
            vaga1.Show();
            vaga1.Text = "Vaga 01";
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vaga vaga3 = new Vaga();
            vaga3.Show();
            vaga3.Text = "Vaga 03";

        }

        private void btn2_Click(object sender, EventArgs e)
        {

            Vaga vaga2 = new Vaga();
            vaga2.Show();
            vaga2.Text = "Vaga 02";
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            Vaga vaga3 = new Vaga();
            vaga3.Show();
            vaga3.Text = "Vaga 03";

        }
       
        private void btn4_Click(object sender, EventArgs e)
        {
            Vaga vaga4 = new Vaga();
            vaga4.Show();
            vaga4.Text = "Vaga 04";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Vaga vaga5 = new Vaga();
            vaga5.Show();
            vaga5.Text = "Vaga 05";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Vaga vaga6 = new Vaga();
            vaga6.Show();
            vaga6.Text = "Vaga 06";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Vaga vaga7 = new Vaga();
            vaga7.Show();
            vaga7.Text = "Vaga 07";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Vaga vaga8 = new Vaga();
            vaga8.Show();
            vaga8.Text = "Vaga 08";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Vaga vaga9 = new Vaga();
            vaga9.Show();
            vaga9.Text = "Vaga 09";

        }
    }
}
