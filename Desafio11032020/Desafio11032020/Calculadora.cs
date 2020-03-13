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
    public partial class Calculadora : Form
    {
        int x;
        int y;
        int result;

        public Calculadora()
        {
            InitializeComponent();
        }

        public bool VerificaCampo()
        {
            if (TxtCalculadora1.Text == "")
            {
                MessageBox.Show("Preencha a campo Valor 1");
                return false;
            }
            else if (TxtCalculadora2.Text == "")
            {
                MessageBox.Show("Preencha o campo Valor 2");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void BtnSoma_Click(object sender, EventArgs e)
        {
            if (VerificaCampo())
            {
                x = Convert.ToInt32(TxtCalculadora1.Text);
                y = Convert.ToInt32(TxtCalculadora2.Text);
                result = x + y;
                LblResultado.Text = result.ToString();
            }

        }

        private void BtnSub_Click(object sender, EventArgs e)
        {
            if (VerificaCampo())
            {
                x = Convert.ToInt32(TxtCalculadora1.Text);
                y = Convert.ToInt32(TxtCalculadora2.Text);
                result = x - y;
                LblResultado.Text = result.ToString();
            }
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            if (VerificaCampo())
            {
                x = Convert.ToInt32(TxtCalculadora1.Text);
                y = Convert.ToInt32(TxtCalculadora2.Text);
                result = x / y;
                LblResultado.Text = result.ToString();
            }
        }

        private void BtnMult_Click(object sender, EventArgs e)
        {
            if (VerificaCampo())
            {
                x = Convert.ToInt32(TxtCalculadora1.Text);
                y = Convert.ToInt32(TxtCalculadora2.Text);
                result = x * y;
                LblResultado.Text = result.ToString();
            }
        }

        private void lblFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
