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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void BtnParImpar_Click(object sender, EventArgs e)
        {
            ParImpar pi = new ParImpar();
            pi.Show();
        }

        private void BtnCalculadora_Click(object sender, EventArgs e)
        {
            Calculadora calc = new Calculadora();
            calc.Show();
        }

        private void BtnIdade_Click(object sender, EventArgs e)
        {
            Idade idade = new Idade();
            idade.Show();
        }

        private void BtnTxt_Click(object sender, EventArgs e)
        {
            PersistenciaTxt ptxt = new PersistenciaTxt();
            ptxt.Show();
        }

        private void BtnIMC_Click(object sender, EventArgs e)
        {
            IMC imc = new IMC();
            imc.Show();
        }

        private void lblfechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
