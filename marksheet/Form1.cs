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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int no1 = Convert.ToInt32(this.textBox1.Text);
            int no2 = Convert.ToInt32(this.textBox2.Text);
            int no3 = Convert.ToInt32(this.textBox3.Text);
            int no4 = Convert.ToInt32(this.textBox4.Text);
            int no5 = no1 + no2 + no3 + no4;

              textBox5.Text = Convert.ToString(no5);


               double a = (double)((no5 *100 ) /400);
               textBox6.Text = a.ToString();


            if(a>=80)
            {
                textBox7.Text = "YOU GOT A+ GRADE";
            }

           else if (a >= 70)
            {
                textBox7.Text = "YOU GOT A GRADE";
            }


            else if (a >= 60)
            {
                textBox7.Text = "YOU GOT B GRADE";
            }
            else if (a >= 50)
            {
                textBox7.Text = "YOU GOT C GRADE";
            }
            else
            {
                textBox7.Text = "FAIL";
            }

            //string name = textBox3.Text;
            //this.label4.Text = name;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if((string)comboBox1.SelectedItem=="1st Semster")
            {

                MessageBox.Show("Welecome to first semster");
             

                label1.Text = "Web Design";
                label3.Text = "C Language";
                label4.Text = "SQL";
                label6.Text = "Office";

            }
            else if ((string)comboBox1.SelectedItem == "2nd Semster")
            {
                textBox1.Text = "";
                textBox2.Text = "";
                MessageBox.Show("Welecome to second semster");

                label1.Text = "XML";
                label3.Text = "C#";
                label4.Text = "Java";
                label6.Text = "Cloud";
                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }






    }
}
