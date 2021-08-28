using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;

namespace Chemistry_Project_Canary
{
    public class FiltroPadre
    {
        DataSet resultados = new DataSet();
        public virtual void leer_datos(string query, ref DataSet dstprincipal, string tabla)
        {

        }
    }
}