using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mechanical_energy_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("World");
            comboBox1.Items.Add("Mars");
            comboBox1.Items.Add("Moon");
            comboBox1.Items.Add("Venus");
            comboBox1.Items.Add("Saturn");
            comboBox1.Items.Add("Jupiter");
            comboBox1.Items.Add("I will enter value");
            label1.Text = "Energy";
            comboBox1.SelectedIndex = 0;
            //textBox4.Text = "9,807";
            label4.Text = "m";
            label5.Text = "m";
            label3.Text = "h";
            label2.Text = "v";
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "World") {
                textBox4.Text = "9,807";
            }
            if (comboBox1.Text == "Mars")
            {
                textBox4.Text = "3,71";
            }
            if (comboBox1.Text == "Moon")
            {
                textBox4.Text = "1,62";
            }
            if (comboBox1.Text == "Venus")
            {
                textBox4.Text = "8,87";
            }
            if (comboBox1.Text == "Saturn")
            {
                textBox4.Text = "10,44";
            }
            if (comboBox1.Text == "Jupiter")
            {
                textBox4.Text = "24,79";
            }
            if (comboBox1.Text == "I will enter value")
            {
                textBox4.Text = "";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double mass = Convert.ToDouble(textBox1.Text);
                if (mass <= 0)
                {
                    textBox1.Text = "";
                    label1.Text = "";
                    MessageBox.Show("The value entered is not a mass", "Mass Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                double Velocity = Convert.ToDouble(textBox2.Text);
                double Height = Convert.ToDouble(textBox3.Text);
                double Gravity = Convert.ToDouble(textBox4.Text);
                double ek, em, ep;
                ek = (mass * Velocity * Velocity) / 2;
                ep = mass * Gravity * Height;
                em = ek + ep;
                if (Velocity == 0)
                {
                    label1.Text = "Potential Energy = " + ep;
                }
                if (Height == 0 && Gravity == 00)
                {
                    label1.Text = "Kinetic Energy = " + ek;
                }
                label1.Text = "Pe = " + ep + " + " + " Ke = " + ek + " = " + "(Mechanical Energy) = " + em;
            }
            catch (Exception)
            {
                MessageBox.Show("The entered value is not suitable", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            label3.Text = textBox3.Text;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label2.Text = textBox2.Text;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label4.Text = textBox1.Text;
            label5.Text = textBox1.Text;
        }
    }
}
