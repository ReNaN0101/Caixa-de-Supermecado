using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caixa_de_Supermecado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(textBox3.Text);
            listBox4.Items.Add(textBox4.Text);
            textBox4.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            float a, b, c;
            if (!textBox2.Text.Equals("") && !textBox3.Text.Equals(""))
            {
                a = Convert.ToInt32(textBox2.Text);
                b = Convert.ToInt32(textBox3.Text);
                c = a * b;
                textBox4.Text = Convert.ToString(c);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            float a, b, c;
            if (!textBox2.Text.Equals("") && !textBox3.Text.Equals(""))
            {
                a = Convert.ToInt32(textBox2.Text);
                b = Convert.ToInt32(textBox3.Text);
                c = a * b;
                textBox4.Text = Convert.ToString(c);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox3.Clear();

            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
        }

        private void dad(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void adad(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;

            if(listBox1.Items.Count != 0)
            
            {
                listBox1.Items.RemoveAt(i);
                listBox2.Items.RemoveAt(i);
                listBox3.Items.RemoveAt(i);
                listBox4.Items.RemoveAt(i);

            }
                
        }
    }
}
