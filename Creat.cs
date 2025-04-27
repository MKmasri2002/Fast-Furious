using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fast_Furious
{
    public partial class Creat : Form
    {
        String name, age, gender;
        String carColor =null;
        public Creat()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            name = textBox1.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            gender = comboBox1.SelectedItem.ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            age = comboBox2.SelectedItem.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            carColor = "Orange";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            carColor = "Green";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            carColor = "Blue";
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Intro intro = new Intro();
            intro.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && comboBox1.SelectedIndex != -1
                &&comboBox2.SelectedIndex!=-1&& carColor!=null)
            {
                Player p = new Player(name, gender, age, carColor);
                Program.Players.Add(p);
                MessageBox.Show("Welcome "+p.Name);
            }
            else
            {
                MessageBox.Show("You must insert all field");
            }
        }
    }
}
