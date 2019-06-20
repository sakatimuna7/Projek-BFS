using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aBOUTUSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MEMBER m = new MEMBER();
            m.MdiParent = this;
            m.Show();
        }

        private void bREADTHFIRSTSEARCHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _BFS bfs = new _BFS();
            bfs.MdiParent = this;
            bfs.Show();
        }
    }
}
