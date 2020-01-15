using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWord
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Seu computador vai desliguar");
            Process.Start("Shutdown", "-s -f -t 3600");
            


        }
       
        private void button1_Click_2(object sender, EventArgs e) // botão de cancelar o desligamento
        {

            DialogResult result2 = MessageBox.Show("Deseja cancelar a programação ",// aqui vai aparecer uma mensagem se desejar cancelar realmente
            "The Question",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
            if (result2 == DialogResult.Yes)
            {
                Process.Start("Shutdown", "-a");
                MessageBox.Show("Seu Desligamento Foi Cancelado");
                
            }
            if (result2 == DialogResult.No)
            {
                MessageBox.Show("Cancelado");
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {
            
           
        }
    }
}
