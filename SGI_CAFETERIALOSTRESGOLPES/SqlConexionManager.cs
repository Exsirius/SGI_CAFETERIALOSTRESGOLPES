using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGI_CAFETERIALOSTRESGOLPES
{
    class SqlConexionManager
    {
        static public SqlConnection conexion;
        static public String Sql;
        static public DataSet Almacen;
        static public DataSet Almacen2;
        static public DataSet Almacen3;
        static public SqlDataAdapter Adaptar;
        public static SqlCommand comando;
        static public int Resultado;
        static public DataRow registro;
        static public DataRow registro1;
        static public DataRow registro2;
        static public int totalFilas;
        static public int ubicacionactual;
        static public int numFila;
        static public string cnn = "Data Source=EMILBATISTA2009\\EXSIRIUSXD; Initial Catalog=SGI_CafeteriaLosTresGolpes; User Id=sa; Password=Emil211009;";
    }
}
