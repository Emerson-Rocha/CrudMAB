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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        int i = 0;
        private void Tm_Tick(object sender, EventArgs e)
        {
            //MessageBox.Show("ola");
            //amanda_linda.Text = i++.ToString();
            //if (i == 11) {                // fazer parar
            //    tm.Stop();
            //} 
            try
            {
                amanda_linda.Text = prb.Value++.ToString() + "%";

                if (prb.Value == 100) {
                    /// DIRECIONAR PARA TELA DE LOGIN
                    amanda_linda.Text = "100%";
                    tm.Stop();
                    this.Hide();
                    Login frmLogin = new Login();
                    frmLogin.Show();

                    
                }
            }
            catch (Exception erro) {
                MessageBox.Show("tratar o erro");
            }

        }
    }
}
