using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Desafio11032020.Data
{
    class IMCDals
    {
        Banco _banco = new Banco ();

        public bool Cadastrar(IMCModel imc)
        {

            string query = "INSERT INTO [dbo].[TB_IMC]([IMC_NOME],[IMC_IDADE],[IMC_PESO],[IMC_ALTURA],[IMC_IMC]) "
                         + "VALUES ('" + imc.Nome + "', " + imc.Idade + ", " + imc.Peso.ToString("F", CultureInfo.InvariantCulture) + ", " + imc.Altura.ToString("F", CultureInfo.InvariantCulture) + ", " + imc.IMC.ToString("F", CultureInfo.InvariantCulture) + ")";

            try
            {
                return _banco.ExecutarInstrucao(query);
            }
            catch
            {
                return false;
            }
        }

        public List<IMCModel> Consultar()
        {
            List<IMCModel> imcs = new List<IMCModel>();
            string query = "SELECT* FROM[dbo].[TB_IMC]";

            try
            {
                DataTable dt = _banco.BuscarRegistro(query);
                IMCModel imc = null;
                DataRow[] dataRows = dt.Select();
                foreach (DataRow dr in dataRows)
                {
                    int idade = Convert.ToInt32(dr["IMC_IDADE"].ToString());
                    float peso = float.Parse(dr["IMC_PESO"].ToString());
                    float altura = float.Parse(dr["IMC_PESO"].ToString());
                    float Imc = float.Parse(dr["IMC_IMC"].ToString());

                    imc = new IMCModel(dr["IMC_NOME"].ToString(), idade, peso, altura, Imc);

                    imcs.Add(imc);
                }

                return imcs;
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
