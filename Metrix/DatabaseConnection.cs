using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metrix
{
    class DatabaseConnection
    {
        private string sql_string; //sql string
        private string strCon;  //connection url
        System.Data.SqlClient.SqlDataAdapter da_1; //opening the table in db - data adapter

        public string Sql { //Property
            
            set { sql_string = value; }
        
        }

        public string connection_string { //Property
            
            set { strCon = value; }
        
        }

        //Loads the table into the DataSet
        //Dataset does that
        public System.Data.DataSet GetConnection { //Read-only property
            
            get { return MyDataSet(); } //connects to the database and fill a dataset
        
        }

        private System.Data.DataSet MyDataSet() {

            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(strCon); //connection object

            con.Open();

            //1st param - record want from db , 2nd param- con obj - which db table is in
            da_1 = new System.Data.SqlClient.SqlDataAdapter(sql_string, con);

            //whole method return this data set, hold the all records from db
            System.Data.DataSet dat_set = new System.Data.DataSet(); 
            da_1.Fill(dat_set, "Table_Data_1"); //fill the dat set - after comma can add a name for the fill
            con.Close();

            return dat_set;

            
        
        }
 

    }
}
