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
    }
}
