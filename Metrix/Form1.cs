using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Metrix;

namespace Metrix
{
    public partial class Form1 : Form
    {

       
        
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {
            //panel2.BackColor=Color.#c0392b;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            //panel2.BackColor = Color.AntiqueWhite;
          
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSupSave_Click(object sender, EventArgs e)
        {

            ForeignSupplier fr = new ForeignSupplier();
            fr.supIdValue = int.Parse(SupId_txt.Text);
            fr.companyNameValue = SupName_txt.Text;
            fr.contactValue = SupConNo_txt.Text;
            fr.countryValue = SupAddress_txt.Text;
            fr.emailValue = SupEmail_txt.Text;
            fr.refNameValue = SupRefName_txt.Text;
            fr.SupplierSave();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ForeignSupplier fr = new ForeignSupplier();
            fr.supIdValue = int.Parse(SupId_txt.Text);
            fr.companyNameValue = SupName_txt.Text;
            fr.contactValue = SupConNo_txt.Text;
            fr.countryValue = SupAddress_txt.Text;
            fr.emailValue = SupEmail_txt.Text;
            fr.refNameValue = SupRefName_txt.Text;
            fr.SupplierUpdate();
        }

        private void btnSupDelete_Click(object sender, EventArgs e)
        {
            ForeignSupplier fr = new ForeignSupplier();
            fr.supIdValue = int.Parse(SupId_txt.Text);
            fr.companyNameValue = SupName_txt.Text;
            fr.contactValue = SupConNo_txt.Text;
            fr.countryValue = SupAddress_txt.Text;
            fr.emailValue = SupEmail_txt.Text;
            fr.refNameValue = SupRefName_txt.Text;
            fr.SupplierDelete();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Customer cus = new Customer();
            cus.cusIdValue = int.Parse(CusID_txt.Text);
            cus.cusNameValue = CusName_txt.Text;
            cus.cusContactValue = int.Parse(CusConNo_txt.Text);
            cus.cusNicValue = CusNic_txt.Text;
            cus.cusAdLine1Value = CusAddress1_txt.Text;
            cus.cusAdLine2Value = CusAddress2_txt.Text;
            cus.cusAdLine3Value = CusAddress3_txt.Text;
            cus.CustomerDelete();
        }

        private void btnCusSave_Click(object sender, EventArgs e)
        {
            Customer cus = new Customer();
            cus.cusIdValue = int.Parse(CusID_txt.Text);
            cus.cusNameValue = CusName_txt.Text;
            cus.cusContactValue = int.Parse(CusConNo_txt.Text);
            cus.cusNicValue = CusNic_txt.Text;
            cus.cusAdLine1Value = CusAddress1_txt.Text;
            cus.cusAdLine2Value = CusAddress2_txt.Text;
            cus.cusAdLine3Value = CusAddress3_txt.Text;
            cus.CustomerSave();
        }

        private void label46_Click(object sender, EventArgs e)
        {

        }

        private void btnCusUpdate_Click(object sender, EventArgs e)
        {
            Customer cus = new Customer();
            cus.cusIdValue = int.Parse(CusID_txt.Text);
            cus.cusNameValue = CusName_txt.Text;
            cus.cusContactValue = int.Parse(CusConNo_txt.Text);
            cus.cusNicValue = CusNic_txt.Text;
            cus.cusAdLine1Value = CusAddress1_txt.Text;
            cus.cusAdLine2Value = CusAddress2_txt.Text;
            cus.cusAdLine3Value = CusAddress3_txt.Text;
            cus.CustomerUpdate();
        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void btnEmpSave_Click(object sender, EventArgs e)
        {
            Employee em = new Employee();
            em.empIdValue = int.Parse(Empid_txt.Text);
            em.empNameValue = EmpName_txt.Text;
            em.empContactValue = int.Parse(EmpContact_text.Text);
            em.empAdLine1Value = EmpAdLine1_text.Text;
            em.empAdLine2Value = EmpAdLine2_text.Text;
            em.empDobValue = EmpDob_text.Text;
            em.empNicValue = EmpNic_text.Text;
            em.empPosValue = EmpPos_text.Text;
            em.empDeptValue = EmpDept_text.Text;
            em.EmployeeSave();
        }

        private void btnEmpUpdate_Click(object sender, EventArgs e)
        {
            Employee em = new Employee();
            em.empIdValue = int.Parse(Empid_txt.Text);
            em.empNameValue = EmpName_txt.Text;
            em.empContactValue = int.Parse(EmpContact_text.Text);
            em.empAdLine1Value = EmpAdLine1_text.Text;
            em.empAdLine2Value = EmpAdLine2_text.Text;
            em.empDobValue = EmpDob_text.Text;
            em.empNicValue = EmpNic_text.Text;
            em.empPosValue = EmpPos_text.Text;
            em.empDeptValue = EmpDept_text.Text;
            em.EmployeeUpdate();
        }

        private void btnEmpDelete_Click(object sender, EventArgs e)
        {
            Employee em = new Employee();
            em.empIdValue = int.Parse(Empid_txt.Text);
            em.empNameValue = EmpName_txt.Text;
            em.empContactValue = int.Parse(EmpContact_text.Text);
            em.empAdLine1Value = EmpAdLine1_text.Text;
            em.empAdLine2Value = EmpAdLine2_text.Text;
            em.empDobValue = EmpDob_text.Text;
            em.empNicValue = EmpNic_text.Text;
            em.empPosValue = EmpPos_text.Text;
            em.empDeptValue = EmpDept_text.Text;
            em.EmployeeDelete();
        }

        private void btnProdSave_Click(object sender, EventArgs e)
        {
            Product pr = new Product();
            pr.prodIdValue = int.Parse(ProductId_text.Text);
            pr.nameValue = ProdName_text.Text;
            pr.brandValue = ProdBrand_text.Text;
            pr.countryValue = ProdCon_text.Text;
            pr.supIdValue =int.Parse(ProdSupid_text.Text);
            pr.purchPriceValue =int.Parse(ProdPurch_text.Text);
            pr.salePriceValue = int.Parse(ProdSales_text.Text);
            pr.warrentValue = ProdWarr_text.Text;
            pr.ProductSave();

        }

        private void btnProdUpdate_Click(object sender, EventArgs e)
        {
            Product pr = new Product();
            pr.prodIdValue = int.Parse(ProductId_text.Text);
            pr.nameValue = ProdName_text.Text;
            pr.brandValue = ProdBrand_text.Text;
            pr.countryValue = ProdCon_text.Text;
            pr.supIdValue = int.Parse(ProdSupid_text.Text);
            pr.purchPriceValue = int.Parse(ProdPurch_text.Text);
            pr.salePriceValue = int.Parse(ProdSales_text.Text);
            pr.warrentValue = ProdWarr_text.Text;
            pr.ProductUpdate();
        }

        private void btnProdDelete_Click(object sender, EventArgs e)
        {
            Product pr = new Product();
            pr.prodIdValue = int.Parse(ProductId_text.Text);
            pr.nameValue = ProdName_text.Text;
            pr.brandValue = ProdBrand_text.Text;
            pr.countryValue = ProdCon_text.Text;
            pr.supIdValue = int.Parse(ProdSupid_text.Text);
            pr.purchPriceValue = int.Parse(ProdPurch_text.Text);
            pr.salePriceValue = int.Parse(ProdSales_text.Text);
            pr.warrentValue = ProdWarr_text.Text;
            pr.ProductDelete();
        }
    }
}
