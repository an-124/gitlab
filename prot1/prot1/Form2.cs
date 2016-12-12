using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prot1
{
    public partial class Form2 : Form
    {
        public ABCan f1 = new ABCan();
        public XYZan f2 = new XYZan();
        public Dest f3 = new Dest();
        public Dib_siman f4 = new Dib_siman();
        public Form2()
        {
            InitializeComponent();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void поставщикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            f3.ShowDialog();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            f1.ShowDialog();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            f4.ShowDialog();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            f2.ShowDialog();
            Close();
        }

    }
}
