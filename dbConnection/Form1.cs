using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbConnection
{
    public partial class Form1 : Form
    {
        private connection mConexion;
        public Form1()
        {
            InitializeComponent();
            mConexion = new connection();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            string result = ""; 
            MySqlDataReader MySqlDataReader = null;
            string consulta = "CALL verUsuarios";
            if (mConexion.GetSqlConnection() != null)
            {
                MySqlCommand mySqlCommand = new MySqlCommand(consulta);
                mySqlCommand.Connection = mConexion.GetSqlConnection();
                MySqlDataReader = mySqlCommand.ExecuteReader();
                while (MySqlDataReader.Read())
                {
                    result = MySqlDataReader.GetString("name");
                }
                MessageBox.Show(result);
            }
            else
            {
                MessageBox.Show("Error de conexion: ");
            }
        }
    }
}
