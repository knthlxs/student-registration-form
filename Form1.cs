using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void panelStudInfo_Paint(object sender, PaintEventArgs e) {

        }

        private void lblStudInfo_Click(object sender, EventArgs e) {

        }

        private void panel2_Paint(object sender, PaintEventArgs e) {

        }

        private void panel8_Paint(object sender, PaintEventArgs e) {

        }

        private void label30_Click(object sender, EventArgs e) {

        }

        private void btnAddStudent_Click(object sender, EventArgs e) {
            try { 
                string studSurname = txtSurname.Text;
                string studFName = txtFirstName.Text;
                string studMiddle = txtMiddleName.Text;
                string addBlock = txtBlock.Text;
                string barangay = txtBarangay.Text;
                string municipality = txtMunicipality.Text;
                string country = txtCountry.Text;
                string postalCode = txtPostalCode.Text;



                //if (studSurname == string.Empty || studFName == string.Empty || studMiddle == string.Empty || addBlock == string.Empty || barangay == string.Empty || municipality == string.Empty || country == string.Empty || postalCode == string.Empty  || txtCourse.Text == string.Empty ) {
                //    throw new Exception("Invalid string");

                //}


                if (studSurname == string.Empty || studSurname.) throw new FormatException("Invalid input for student last name");

                if (studFName == string.Empty) throw new FormatException("Invalid input for student firrstname");
                
               
                
            } catch (FormatException ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox16_TextChanged(object sender, EventArgs e) {

        }
    }
}
