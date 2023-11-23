using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudMab
{
    public partial class MenuP : Form
    {
        public MenuP()
        {
            InitializeComponent();
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }

        private void Process1_Exited(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            process1.StartInfo.FileName = @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe";
            process1.Start();

        }

        private void ToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            process1.StartInfo.FileName = @"C:\Program Files (x86)\Microsoft\EdgeCore\118.0.2088.61\msedge.exe";
            process1.Start();
        }

        private void ToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolStripMenuItem11_Click(object sender, EventArgs e)
        {
              Frm = new cadas 
        }
    }
}
