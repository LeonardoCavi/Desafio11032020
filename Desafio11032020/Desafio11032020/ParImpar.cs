using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio11032020
{
    public partial class ParImpar : Form
    {
        public ParImpar()
        {
            InitializeComponent();
        }

        public bool VerificaCampo()
        {
            if(TxtParImpar.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (VerificaCampo())
            {
                int num = Convert.ToInt32(TxtParImpar.Text);
                int resto = num % 2;
                if (resto != 0)
                {
                    lblParImpar.ForeColor = Color.Red;
                    lblParImpar.Text = "Impar";
                }
                else
                {
                    lblParImpar.ForeColor = Color.Green;
                    lblParImpar.Text = "Par";
                }
            }    
        }

        private void lblFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
