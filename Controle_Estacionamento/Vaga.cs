using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Controle_Estacionamento
{
    public partial class Vaga : Form
    {
        private Stopwatch stopwatch;
        private int cont;
        public Vaga()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            stopwatch.Start();
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            stopwatch.Stop();
        }

        private void btnZerar_Click(object sender, EventArgs e)
        {
            stopwatch.Restart();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtPagamento_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Vaga1_Load(object sender, EventArgs e)
        {
            stopwatch = new Stopwatch();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label9.Text = String.Format("{0:hh\\:mm\\:ss}", stopwatch.Elapsed);
        }

        private void Vagas_Click(object sender, EventArgs e)
        {
         
        }
    }
}
