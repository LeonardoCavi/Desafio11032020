using Desafio11032020.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio11032020
{
    public partial class IMC : Form
    {
        private List<IMCModel> ListaIMCs;
        IMCDals _imcdals = new IMCDals();

        public IMC()
        {
            InitializeComponent();
        }

        public bool VerificaCampo()
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Campo nome vazio!");
                return false;
            }
            else if(txtIdade.Text == "")
            {
                MessageBox.Show("Campo idade vazio!");
                return false;   
            }
            else if(txtPeso.Text == "")
            {
                MessageBox.Show("Campo peso vazio!");
                return false;         
            }
            else if(txtAltura.Text == "")
            {
                MessageBox.Show("Campo altura vazio!");
                return false;
            }
            else
            {
                return true;
            }
        }

        public void LimpaCampo()
        {
            txtNome.Text = "";
            txtIdade.Text = "";
            txtAltura.Text = "";
            txtPeso.Text = "";
        }

        private void GRAVAR_Click(object sender, EventArgs e)
        {
            if (VerificaCampo())
            {
                string Nome = txtNome.Text;
                int Idade = Convert.ToInt32(txtIdade.Text);
                float Peso = float.Parse(txtPeso.Text.Replace(",","."), CultureInfo.InvariantCulture.NumberFormat);
                float Altura = float.Parse(txtAltura.Text.Replace(",", "."), CultureInfo.InvariantCulture.NumberFormat);

                float IMC = Peso / (Altura * Altura);

                IMCModel imcmodels = new IMCModel(Nome, Idade, Peso, Altura, IMC);
                

                if (_imcdals.Cadastrar(imcmodels))
                {
                    MessageBox.Show("IMC: " + imcmodels.IMC.ToString("F"));
                    lblmsg.ForeColor = Color.Green;
                    lblmsg.Text = "Cadastro realizado com sucesso!";
                    LimpaCampo();
                }
                else
                {
                    lblmsg.ForeColor = Color.Red;
                    lblmsg.Text = "Houve um erro no cadastro!";
                }
            }
        }

        private void BtnConsulta_Click(object sender, EventArgs e)
        {
            List<IMCModel> imcs = _imcdals.Consultar();
            if (imcs == null)
            {
                MessageBox.Show("Não existe cadastros realizados!");
            }
            else
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Nome", typeof(string));
                dt.Columns.Add("Idade", typeof(int));
                dt.Columns.Add("Peso", typeof(float));
                dt.Columns.Add("Altura", typeof(float));
                dt.Columns.Add("IMC", typeof(float));

                foreach (IMCModel imc in imcs)
                {

                    dt.Rows.Add(imc.Nome, imc.Idade, imc.Peso, imc.Altura, imc.IMC);
                }

                ListaIMCs = imcs;
                dataGridView1.DataSource = dt;
            }

        }

        private void lblfechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
