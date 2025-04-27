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
    public partial class Intro : Form
    {
        public Intro()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void creatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Creat c = new Creat();
            c.Show();
            this.Visible = false;
        }

        private void currentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Current c = new Current();
            c.Show();
            this.Visible = false;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Current c = new Current();
            c.Show();
            this.Visible=false;
        }

        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statistics s = new statistics();
            s.Show();
            this.Visible=false;
        }

        private void Intro_Load(object sender, EventArgs e)
        {
     
            
        }

        private void hestoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            History h = new History();
            h.Show();
            this.Visible=false;
        }
    }
}
