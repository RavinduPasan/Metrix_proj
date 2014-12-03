using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metrix
{
    class Employee
    {
        private int empId;
        private string empName;
        private int empContact;
        private string empAdLine1;
        private string empAdLine2;
        private string empDob;
        private string empNic;
        private string empPos;
        private string empDept;


        public int empIdValue
        {
            get 
            {
                return this.empId;
            }
            set
            {
                empId = value;
            }
        }

        public string empNameValue
        {
            get 
            {
                return this.empName;
            }
            set 
            {
                empName = value;
            }
        }

        public int empContactValue
        {
            get
            {
                return this.empContact;
            }
            set
            {
                empContact = value;
            }
        }

    
        public string empAdLine1Value
        {
            get
            {
                return this.empAdLine1;
            }
            set
            {
                empAdLine1 = value;
            }
        }

        public string empAdLine2Value
        {
            get
            {
                return this.empAdLine2;
            }
            set
            {
                empAdLine2 = value;
            }
        }


        public string empDobValue
        {
            get
            {
                return this.empDob;
            }
            set
            {
                empDob = value;
            }
        }

        public string empNicValue
        {
            get 
            {
                return this.empNic;
            }
            set
            {
                empNic = value;
            }
        }

        public string empPosValue
        {
            get
            {
                return this.empPos;
            }
            set
            {
                empPos = value;
            }
        }

        public string empDeptValue
        {
            get
            {
                return this.empDept;
            }
            set
            {
                empDept = value;
            }
        }

        
        DatabaseConnection db = new DatabaseConnection();
        
        
        public void EmployeeSave() {
        
             db.cmd.CommandText = "insert into " + db.db + ".employee values ('" + empIdValue + "', '" + empNameValue + "', '" + empContactValue + "', '" + empAdLine1Value + "' , '"  + empAdLine2Value +  "', '"  + empDobValue +  "', '"  + empNicValue +  "', '" + empPosValue +  "', '" + empDeptValue + "')";

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

        public void EmployeeUpdate() {
        
            
        
            db.cmd.CommandText = "update " + db.db + ".employee set  EmpId ='"+ empIdValue + "', EmpName ='"  + empNameValue + "',  ContactNo ='"+ empContactValue + "', AddressLine1 ='" + empAdLine1Value + "', AddressLine2 ='" + empAdLine2Value +"', DOB ='"+ empDobValue + "', NICNo = '" + empNicValue+ "',  Position = '"+ empPosValue +"', Department = '"+ empDeptValue +"'  ;";

            try
            {
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

            catch (Exception ex)
            {
              
                MessageBox.Show("A database error ocurred! Contact system administrator! ");
            
            }
        }

        public void EmployeeDelete() {

            db.cmd.CommandText = "delete from " + db.db + ".employee where  EmpId ='" + empIdValue + "' ;";

            try
            {
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

            catch (Exception ex)
            {
                MessageBox.Show("A database error ocurred! Contact system administrator! ");
            }
        
        }


        

       

        
    }
}
