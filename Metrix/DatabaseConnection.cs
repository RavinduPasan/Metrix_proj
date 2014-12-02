using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Metrix
{
    class DatabaseConnection{

        public MySqlConnection conn; //opening a connection
        public MySqlCommand cmd;
        private string server; 
        public string db; //database name
        private string uid; //username
        private string pass; //password

        //Constructer
        public DatabaseConnection() {
            conn = new MySqlConnection();
            cmd = new MySqlCommand();         
            server = "localhost";
            db = "metrix";
            uid = "root";
            pass = "";
            conn.ConnectionString = "SERVER=" + server + ";" + "DATABASE=" +
            db + ";" + "UID=" + uid + ";" + "PASSWORD=" + pass + ";";
            cmd.Connection = conn;
           
        }

        //initialize values
        public MySqlCommand Initialize()
        {

            cmd.Connection = conn;
            return cmd;        
        }

        //open connection to database
        public bool OpenConnection(){
            try{
                
                conn.Open();
                return true;
            }
            catch(MySqlException ex) {
                switch (ex.Number)
                {
                    case 0: // 0: Error for cannot connecting to db
                        MessageBox.Show("Cannot Connect to the Server");
                        break;

                    case 1045: //1045 : Error for wrong credentials
                        MessageBox.Show("Username / Password is incorrect ! Try Again ! ");
                        break;
                }

                return false;
            
            }
        }

        //Close connection
        public bool CloseConnection(){
            try
            {

                conn.Close();
                return true;

            }

            catch (MySqlException ex) {

                MessageBox.Show(ex.Message);
                return false;
            
            }
        
        }

        
        
        
        

    }
}
