using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurKLoJeN_Wordlist_Maker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cikis_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void ambiance_ThemeContainer1_Click(object sender, EventArgs e)
        {

        }

        private void ambiance_Button_11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://turklojenofficial.com/");
        }
    }
}
