using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Metrix
{
    class ForeignSupplier:Supplier
    {
        DatabaseConnection db = new DatabaseConnection();
        public override void SupplierSave() {

            db.cmd.CommandText = "insert into " + db.db + ".supplier (SupplierId, CompanyName, ContactNo, Address, Email, ReferenceName) values ('" + supIdValue + "', '" + companyNameValue + "', '" + contactValue + "', '" + countryValue + "', '" + emailValue + "', '" + refNameValue + "')";

            db.OpenConnection();
            int x = db.cmd.ExecuteNonQuery();
            db.CloseConnection();
            if (x == 1)
            {
                MessageBox.Show("Data Saved Successfully");
            }
            else
                MessageBox.Show("Data Not Saved Successfully");
        }

        public override void SupplierUpdate()
        {
            db.cmd.CommandText = "update " + db.db + ".supplier set  SupplierId ='" + supIdValue + "', CompanyName ='" + companyNameValue + "',  ContactNo ='" + contactValue + "',  Address ='" + countryValue + "', Email ='" + emailValue + "', ReferenceName ='" + refNameValue + "' where SupplierId ='" + supIdValue + "'  ;";

            db.OpenConnection();
            int x = db.cmd.ExecuteNonQuery();
            db.CloseConnection();
            if (x == 1)
            {
                MessageBox.Show("Data Updated Sucesfully");
            }
            else
                MessageBox.Show("Data Not Updated Sucesfully");
        }

        public override void SupplierDelete()
        {

            db.cmd.CommandText = "delete from " + db.db + ".supplier where  SupplierId ='" + supIdValue + "' ;";

            db.OpenConnection();
            int x = db.cmd.ExecuteNonQuery();
            db.CloseConnection();
            if (x == 1)
            {
                MessageBox.Show("Data Deleted Successfully");
            }
            else
                MessageBox.Show("Data Not Deleted Successfully");
        }
    }
}
