using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolLibrary;

namespace SchoolFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        private void BtnPushToTest_Click(object sender, EventArgs e)
        {
            var testSchool = new School
            {
                Name = "Sammamish High School",
                TwitterAddress = "sammamishhighschool"
            };

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
