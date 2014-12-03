using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metrix
{
    class Product
    {
        private int prodId;
        private string name;
        private string brand;
        private string country;
        private int supId;
        private int purchPrice;
        private int salePrice;
        private string warrenty;


        public int prodIdValue {
            get {
                return this.prodId;
            }
            set {
                prodId = value;
            }
        }

        public string nameValue {
            get
            {
                return this.name;
            }
            set
            {
                name = value;
            }
        }

        public string brandValue
        {
            get 
            {
                return this.brand;
            }
            set 
            {
                brand = name;
            }

        }

        public string countryValue {
            get {
                return this.country;
            }
            set {
                country = value;
            }
        }

        public int supIdValue {
            get {
                return this.supId;
            }
            set {
                supId = value;
            }
        }

        public int purchPriceValue {
            get {
                return this.purchPrice;
            }
            set {
                purchPrice = value;
            }
        }

        public int salePriceValue {
            get
            {
                return this.salePrice;
            }
            set {
                salePrice = value;
            }
        }

        public string warrentValue {
            get
            {
                return this.warrenty;
            }
            set
            {
                warrenty = value;
            }
        }

        DatabaseConnection db = new DatabaseConnection();

        public void ProductSave()
        {
            db.cmd.CommandText = "insert into " + db.db + ".product values ('" + prodIdValue + "', '" + nameValue + "', '" + brandValue + "' ,'" + countryValue + "', '" + supIdValue + "' , '" + purchPriceValue + "', '" + salePriceValue + "', '" + warrentValue + "')";

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

        public void ProductUpdate()
        {
            db.cmd.CommandText = "update " + db.db + ".product set  productId ='" + prodIdValue + "', 	ProductName ='" + nameValue + "', 	Brand ='" + brandValue + "',  SupplierId ='" + supIdValue + "', PurchasePrice ='" + purchPriceValue + "', SalesPrice ='" + salePriceValue + "', Warrenty ='" + warrentValue + "' where productId ='" + prodIdValue + "'  ;";

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


        public void ProductDelete()
        {
            db.cmd.CommandText = "delete from " + db.db + ".product where  productId ='" + prodIdValue + "' ;";

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

        
    }
}