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
    public partial class statistics : Form
    {
        public statistics()
        {
            InitializeComponent();
        }

        private void statistics_Load(object sender, EventArgs e)
        {
           
                dataGridView1.Rows.Add("# of Games",Program.games.Count);
                dataGridView1.Rows.Add("# of Player", Program.Players.Count);
            dataGridView1.Rows.Add("Highest Score", Program.getHighestScore().ToString());
            dataGridView1.Rows.Add("Lowest Score", Program.getlowestScore().ToString());
            dataGridView1.Rows.Add("Maximum Duration", Program.getHighestDuration().ToString());
            dataGridView1.Rows.Add("Minimum Duration", Program.getlowestDuration().ToString());
            dataGridView1.Rows.Add("Total Duration", Program.getTotal().ToString());


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Intro i = new Intro();
            i.Show();
            this.Close();
        }
    }
}
