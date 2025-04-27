using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fast_Furious
{
    public partial class Current : Form
    {
        private bool computer1 = false;
        private bool computer2 = false;
        private Player firstPlayer = null;
        private Player seconedPlayer = null;
       
       
        public Current()
        {
            InitializeComponent();
        }

        private void Current_Load(object sender, EventArgs e)
        {
          
            for(int i=2;i<Program.Players.Count; i++)
            {
                comboBox1.Items.Add(Program.Players[i].Name);
                comboBox2.Items.Add(Program.Players[i].Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Intro i = new Intro();
            i.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1 || computer1 == true &&
                comboBox2.SelectedIndex != -1|| computer2 == true)
            {
                if (computer1)
                    firstPlayer = Program.Players[0];
                else
                    firstPlayer = Program.getPlayer(comboBox1.SelectedItem.ToString());
                if (computer2)
                    seconedPlayer = Program.Players[1];
                else
                    seconedPlayer = Program.getPlayer(comboBox2.SelectedItem.ToString());
                /////////////////////////////////////////////////////////
               
                level0 l = new level0(firstPlayer,seconedPlayer);
                l.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("You must select an player to play");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            computer1 = !computer1;
          
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            computer2 = !computer2;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Intro i = new Intro();
            i.Show();
            this.Close();
        }
    }
}
