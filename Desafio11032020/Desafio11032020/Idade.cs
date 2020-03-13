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
    public partial class Idade : Form
    {
        public Idade()
        {
            InitializeComponent();
        }

        public bool VerificaCampo()
        {
            if (TxtIdade.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void TxtIdade_TextChanged(object sender, EventArgs e)
        {
            if (VerificaCampo())
            {
                int idade = Convert.ToInt32(TxtIdade.Text);
                if (idade < 18)
                {
                    lblIdade.ForeColor = Color.Red;
                    lblIdade.Text = "Sem permissão";
                }
                else
                {
                    lblIdade.ForeColor = Color.Green;
                    lblIdade.Text = "Permissão concedida";
                }
            }          
        }

        private void lblFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
