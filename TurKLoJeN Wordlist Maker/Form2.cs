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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void ambiance_Button_21_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            
            
            if(Optional_RadioButton.Checked == true)
            {
                form3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Very Soon");
            }
        }

        private void ambiance_Button_22_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
