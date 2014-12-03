using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metrix
{
    class Customer
    {
        private int cusId;
        private string cusName;
        private int cusContact;
        private string cusNic;
        private string cusAdLine1;
        private string cusAdLine2;
        private string cusAdLine3;

        public int cusIdValue 
        {
            get 
            {
                return this.cusId;
            }
            set 
            {
                cusId = value;
            }
        }

        public string cusNameValue
        {
            get 
            {
                return this.cusName;
            }
            set 
            {
                cusName = value;
            }
        }

        public int cusContactValue
        {
            get
            {
                return this.cusContact;
            }
            set
            {
               cusContact = value;
            }
        }


        public string cusNicValue
        {
            get
            {
                return this.cusNic;
            }
            set
            {
                cusNic = value;
            }
        }


        public string cusAdLine1Value
        {
            get 
            {
                return this.cusAdLine1;
            }
            set 
            {
                cusAdLine1 = value;
            }
        }

        public string cusAdLine2Value
        {
            get
            {
                return this.cusAdLine2;
            }
            set
            {
                cusAdLine2 = value;
            }
        }

        public string cusAdLine3Value
        {
            get
            {
                return this.cusAdLine3;
            }
            set
            {
                cusAdLine3 = value;
            }
        }

        DatabaseConnection db = new DatabaseConnection();

        public void CustomerSave() 
        {
            db.cmd.CommandText = "insert into " + db.db + ".customer (CustomerId, Name, ContactNo, 	NICNo, AddressLine1, AddressLine2, AddressLine3) values ('" + cusIdValue + "', '" + cusNameValue + "', '" + cusContactValue + "', '" + cusNicValue + "' , '" + cusAdLine1Value + "', '" + cusAdLine2Value + "', '" + cusAdLine3Value + "')";

            try
            {
                db.OpenConnection();
                int x = db.cmd.ExecuteNonQuery();
                db.CloseConnection();
                if (x == 1)
                {
                    MessageBox.Show("Data Saved Sucessfully");
                }
                else
                    MessageBox.Show("Data Not Saved Sucessfully");

            }

            catch (Exception ex)
            {
                MessageBox.Show("A database error ocurred! Contact system administrator! ");
            }
        }

        public void CustomerUpdate()
        {
            db.cmd.CommandText = "update  " + db.db + ".customer set  CustomerId ='" + cusIdValue + "', Name ='" + cusNameValue + "', ContactNo ='" + cusContactValue + "', NICNo ='" + cusNicValue + "' ,  AddressLine1 ='" + cusAdLine1Value + "',  AddressLine2 ='" + cusAdLine2Value + "',  AddressLine3 ='" + cusAdLine3Value + "' where CustomerId ='" + cusIdValue + "' ;";

            try
            {
                db.OpenConnection();
                int x = db.cmd.ExecuteNonQuery();
                db.CloseConnection();
                if (x == 1)
                {
                    MessageBox.Show("Data Updated Sucessfully");
                }
                else
                    MessageBox.Show("Data Not Updated Sucessfully");

            }

            catch (Exception ex)
            {
                MessageBox.Show("A database error ocurred! Contact system administrator! ");
            }
        }


        public void CustomerDelete()
        {
            db.cmd.CommandText = "delete from " + db.db + ".customer  where CustomerId ='" + cusIdValue + "' ;";

            try
            {
                db.OpenConnection();
                int x = db.cmd.ExecuteNonQuery();
                db.CloseConnection();
                if (x == 1)
                {
                    MessageBox.Show("Data Deleted Sucessfully");
                }
                else
                    MessageBox.Show("Data Not Deleted Sucessfully");

            }

            catch (Exception ex)
            {
                MessageBox.Show("A database error ocurred! Contact system administrator! ");
            }
        }
    }
}
