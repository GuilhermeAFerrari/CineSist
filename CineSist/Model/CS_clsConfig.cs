using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CineSist.Model
{
    class CS_clsConfig
    {
        private int mID_Config;
        private string mDS_Parametro;
        private string mVL_Parametro;

        public int ID_Config
        {
            get { return mID_Config; }
            set { mID_Config = value; }
        }

        public string DS_Parametro
        {
            get { return mDS_Parametro; }
            set { mDS_Parametro = value; }
        }

        public string VL_Parametro
        {
            get { return mVL_Parametro; }
            set { mVL_Parametro = value; }
        }

        public string inserirConfig()
        {
            CS_clsConexao conexao = new CS_clsConexao();
            conexao.conectar();
            SqlCommand cmd;

            string mErro = null;

            try
            {
                cmd = new SqlCommand("INSERT INTO TB_CONFIG (ID_CONFIG, DS_PARAMETRO, VL_PARAMETRO) VALUES (@ID_CONFIG, @DS_PARAMETRO, @VL_PARAMETRO)", conexao.conexao);
                cmd.Parameters.AddWithValue("@ID_CONFIG", mID_Config);
                cmd.Parameters.AddWithValue("@DS_PARAMETRO", mDS_Parametro);
                cmd.Parameters.AddWithValue("@VL_PARAMETRO", mVL_Parametro);
                cmd.ExecuteReader(CommandBehavior.SingleRow);
                conexao.desconectar();
                return mErro;
            }
            catch (Exception ex)
            {
                mErro = ex.Message;
                return mErro;
            }
            finally
            {
                conexao.desconectar();
            }
        }
    }
}
