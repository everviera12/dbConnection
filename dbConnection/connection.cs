using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbConnection
{
    class connection
    {
        // datos de la base de datos
        private MySqlConnection conexion;
        private String server = "127.0.0.1";
        private String database = "db_test";
        private String user = "root";
        private String password = "root123";
        private String cadenaConnection;

        //creamos un constructor para tener la cadena de la base de datos
        public connection()
        {
            cadenaConnection = "Database = " + database + ";" +
                "DataSource = " + server + ";" +
                "User ID = " + user + ";" +
                "Password = " + password;
        }

        // verificamos si la conexion está correcta
        public MySqlConnection GetSqlConnection()
        {
            if (conexion == null)
            {
                conexion = new MySqlConnection(cadenaConnection);
                conexion.Open();
            }
            return conexion;
        }
    }
}
