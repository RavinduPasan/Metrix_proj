using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Metrix
{
    class DatabaseConnection{

        private MySqlConnection conn; //opening a connection
        private string server; 
        private string db; //database name
        private string uid; //username
        private string pass; //password

        //Constructer
        public DatabaseConnection() {

            Initialize();    
        
        }

        //initialize values
        private void Initialize() {

            server = "localhost";
            db = "metrix";
            uid = "root";
            pass = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            db + ";" + "UID=" + uid + ";" + "PASSWORD=" + pass + ";";

            conn = new MySqlConnection(connectionString);
        
        
        }

    }
}
