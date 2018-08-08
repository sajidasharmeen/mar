using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace marksheet
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBox1.Items.Clear();

            comboBox2.Items.Clear();

            if (comboBox1.SelectedItem == "Pakistan")
            {
                comboBox2.Items.Add("Karachi");
                comboBox2.Items.Add("Islambad");
                comboBox2.Items.Add("Lahore");
            }
            else if (comboBox1.SelectedItem == "America")
            {
                comboBox2.Items.Add("usa");
               
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
