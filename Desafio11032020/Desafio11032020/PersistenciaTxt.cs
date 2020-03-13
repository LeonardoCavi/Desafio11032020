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

namespace Desafio11032020
{
    public partial class PersistenciaTxt : Form
    {
        public PersistenciaTxt()
        {
            InitializeComponent();
        }

        private static string _file = "persistencia.txt";

        private static void VerificaTxt()
        {
            if (!File.Exists(_file))
            {
                File.Create(_file);
            }
        }

        public void LimpaCampo()
        {
            TxtNome.Text = "";
            Txtemail.Text = "";
            TxtTel.Text = "";
            TxtRG.Text = "";
        }

        private void GRAVAR_Click(object sender, EventArgs e)
        {
            VerificaTxt();
            StreamWriter gravar = new StreamWriter(_file, true);

            if (Txtemail.Text.Contains("@"))
            {
                if (Txtemail.Text.Contains(".com"))
                {
                    gravar.WriteLine("Nome: " + TxtNome.Text + "\n" +
                            "e-mail: " + Txtemail.Text + "\n" +
                            "Telefone : " + TxtTel.Text + "\n" +
                            "RG: " + TxtRG.Text);

                    gravar.Close();
                    LimpaCampo();
                    lblMsg.ForeColor = Color.Green;
                    lblMsg.Text = "Dados Gravados com Sucesso!";
                }
            }
            else
            {
                lblMsg.ForeColor = Color.Red;
                lblMsg.Text = "e-mail invalido!";
                gravar.Close();
            }
            
        }

        private void lblfechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnConsulta_Click(object sender, EventArgs e)
        {
            ListConsulta.Items.Clear();
            VerificaTxt();
            StreamReader ler = new StreamReader(_file, true);

            while (ler.EndOfStream == false)
            {
                ListConsulta.Items.Add( ler.ReadLine());
            }

            ler.Close();
        }
    }
}
