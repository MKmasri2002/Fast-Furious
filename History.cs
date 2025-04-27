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
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }

        private void History_Load(object sender, EventArgs e)
        {
            foreach(var g in Program.games)
            {
                dataGridView1.Rows.Add(g.Date,Program.getTotal(),g.p1Name,g.p1Score,g.p2Name,g.p2Score);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Intro i=new Intro();
            i.Show();
            this.Close();
        }
    }
}
