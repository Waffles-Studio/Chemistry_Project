using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace Chemistry_Project_Canary
{
    public class FiltroHijo : FiltroPadre
    {
        public FiltroHijo()
        {
            
        }

        public override void leer_datos(string query, ref DataSet dstprincipal, string tabla)
        {
            try
            {
                string cadena = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Elementos.accdb";
                OleDbConnection cn = new OleDbConnection(cadena);
                cn.Open();
                OleDbDataAdapter da = new OleDbDataAdapter(query, cn);
                da.Fill(dstprincipal, tabla);
                da.Dispose();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            base.leer_datos(query, ref dstprincipal, tabla);
        }
    }
}