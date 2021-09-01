using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurKLoJeN_Wordlist_Maker
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void ambiance_Button_21_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Done_btn_Click(object sender, EventArgs e)
        {
            
            //for name
            listBox1.Items.Add(ambiance_TextBox1.Text + ambiance_TextBox2.Text);
            listBox1.Items.Add(ambiance_TextBox1.Text + ambiance_TextBox3.Text);
            listBox1.Items.Add(ambiance_TextBox1.Text + ambiance_TextBox4.Text);
            listBox1.Items.Add(ambiance_TextBox1.Text + ambiance_TextBox5.Text);
            listBox1.Items.Add(ambiance_TextBox1.Text + ambiance_TextBox6.Text);
            listBox1.Items.Add(ambiance_TextBox1.Text + ambiance_TextBox7.Text);
            listBox1.Items.Add(ambiance_TextBox1.Text + ambiance_TextBox8.Text);
            listBox1.Items.Add(ambiance_TextBox1.Text + ambiance_TextBox9.Text);
            listBox1.Items.Add(ambiance_TextBox1.Text + ambiance_TextBox10.Text);
            listBox1.Items.Add(ambiance_TextBox1.Text + ambiance_TextBox11.Text);
            listBox1.Items.Add(ambiance_TextBox1.Text + ambiance_TextBox12.Text);
            listBox1.Items.Add(ambiance_TextBox1.Text + ambiance_TextBox13.Text);
            listBox1.Items.Add(ambiance_TextBox1.Text + ambiance_TextBox14.Text);
            listBox1.Items.Add(ambiance_TextBox1.Text + ambiance_TextBox15.Text);
            listBox1.Items.Add(ambiance_TextBox1.Text + ambiance_TextBox16.Text);
            listBox1.Items.Add(ambiance_TextBox1.Text + ambiance_TextBox17.Text);
            listBox1.Items.Add(ambiance_TextBox1.Text + ambiance_TextBox18.Text);
            listBox1.Items.Add(ambiance_TextBox1.Text + ambiance_TextBox19.Text);
            listBox1.Items.Add(ambiance_TextBox1.Text + ambiance_TextBox20.Text);
            listBox1.Items.Add(ambiance_TextBox1.Text + ambiance_TextBox21.Text);

            // for surname


            listBox1.Items.Add(ambiance_TextBox2.Text + ambiance_TextBox1.Text);
            listBox1.Items.Add(ambiance_TextBox2.Text + ambiance_TextBox3.Text);
            listBox1.Items.Add(ambiance_TextBox2.Text + ambiance_TextBox4.Text);
            listBox1.Items.Add(ambiance_TextBox2.Text + ambiance_TextBox5.Text);
            listBox1.Items.Add(ambiance_TextBox2.Text + ambiance_TextBox6.Text);
            listBox1.Items.Add(ambiance_TextBox2.Text + ambiance_TextBox7.Text);
            listBox1.Items.Add(ambiance_TextBox2.Text + ambiance_TextBox8.Text);
            listBox1.Items.Add(ambiance_TextBox2.Text + ambiance_TextBox9.Text);
            listBox1.Items.Add(ambiance_TextBox2.Text + ambiance_TextBox10.Text);
            listBox1.Items.Add(ambiance_TextBox2.Text + ambiance_TextBox11.Text);
            listBox1.Items.Add(ambiance_TextBox2.Text + ambiance_TextBox12.Text);
            listBox1.Items.Add(ambiance_TextBox2.Text + ambiance_TextBox13.Text);
            listBox1.Items.Add(ambiance_TextBox2.Text + ambiance_TextBox14.Text);
            listBox1.Items.Add(ambiance_TextBox2.Text + ambiance_TextBox15.Text);
            listBox1.Items.Add(ambiance_TextBox2.Text + ambiance_TextBox16.Text);
            listBox1.Items.Add(ambiance_TextBox2.Text + ambiance_TextBox17.Text);
            listBox1.Items.Add(ambiance_TextBox2.Text + ambiance_TextBox18.Text);
            listBox1.Items.Add(ambiance_TextBox2.Text + ambiance_TextBox19.Text);
            listBox1.Items.Add(ambiance_TextBox2.Text + ambiance_TextBox20.Text);
            listBox1.Items.Add(ambiance_TextBox2.Text + ambiance_TextBox21.Text);


            // for phone number

            listBox1.Items.Add(ambiance_TextBox3.Text + ambiance_TextBox1.Text);
            listBox1.Items.Add(ambiance_TextBox3.Text + ambiance_TextBox2.Text);
            listBox1.Items.Add(ambiance_TextBox3.Text + ambiance_TextBox4.Text);
            listBox1.Items.Add(ambiance_TextBox3.Text + ambiance_TextBox5.Text);
            listBox1.Items.Add(ambiance_TextBox3.Text + ambiance_TextBox6.Text);
            listBox1.Items.Add(ambiance_TextBox3.Text + ambiance_TextBox7.Text);
            listBox1.Items.Add(ambiance_TextBox3.Text + ambiance_TextBox8.Text);
            listBox1.Items.Add(ambiance_TextBox3.Text + ambiance_TextBox9.Text);
            listBox1.Items.Add(ambiance_TextBox3.Text + ambiance_TextBox10.Text);
            listBox1.Items.Add(ambiance_TextBox3.Text + ambiance_TextBox11.Text);
            listBox1.Items.Add(ambiance_TextBox3.Text + ambiance_TextBox12.Text);
            listBox1.Items.Add(ambiance_TextBox3.Text + ambiance_TextBox13.Text);
            listBox1.Items.Add(ambiance_TextBox3.Text + ambiance_TextBox14.Text);
            listBox1.Items.Add(ambiance_TextBox3.Text + ambiance_TextBox15.Text);
            listBox1.Items.Add(ambiance_TextBox3.Text + ambiance_TextBox16.Text);
            listBox1.Items.Add(ambiance_TextBox3.Text + ambiance_TextBox17.Text);
            listBox1.Items.Add(ambiance_TextBox3.Text + ambiance_TextBox18.Text);
            listBox1.Items.Add(ambiance_TextBox3.Text + ambiance_TextBox19.Text);
            listBox1.Items.Add(ambiance_TextBox3.Text + ambiance_TextBox20.Text);
            listBox1.Items.Add(ambiance_TextBox3.Text + ambiance_TextBox21.Text);

            // for date

            listBox1.Items.Add(ambiance_TextBox4.Text + ambiance_TextBox1.Text);
            listBox1.Items.Add(ambiance_TextBox4.Text + ambiance_TextBox2.Text);
            listBox1.Items.Add(ambiance_TextBox4.Text + ambiance_TextBox3.Text);
            listBox1.Items.Add(ambiance_TextBox4.Text + ambiance_TextBox5.Text);
            listBox1.Items.Add(ambiance_TextBox4.Text + ambiance_TextBox6.Text);
            listBox1.Items.Add(ambiance_TextBox4.Text + ambiance_TextBox7.Text);
            listBox1.Items.Add(ambiance_TextBox4.Text + ambiance_TextBox8.Text);
            listBox1.Items.Add(ambiance_TextBox4.Text + ambiance_TextBox9.Text);
            listBox1.Items.Add(ambiance_TextBox4.Text + ambiance_TextBox10.Text);
            listBox1.Items.Add(ambiance_TextBox4.Text + ambiance_TextBox11.Text);
            listBox1.Items.Add(ambiance_TextBox4.Text + ambiance_TextBox12.Text);
            listBox1.Items.Add(ambiance_TextBox4.Text + ambiance_TextBox13.Text);
            listBox1.Items.Add(ambiance_TextBox4.Text + ambiance_TextBox14.Text);
            listBox1.Items.Add(ambiance_TextBox4.Text + ambiance_TextBox15.Text);
            listBox1.Items.Add(ambiance_TextBox4.Text + ambiance_TextBox16.Text);
            listBox1.Items.Add(ambiance_TextBox4.Text + ambiance_TextBox17.Text);
            listBox1.Items.Add(ambiance_TextBox4.Text + ambiance_TextBox18.Text);
            listBox1.Items.Add(ambiance_TextBox4.Text + ambiance_TextBox19.Text);
            listBox1.Items.Add(ambiance_TextBox4.Text + ambiance_TextBox20.Text);
            listBox1.Items.Add(ambiance_TextBox4.Text + ambiance_TextBox21.Text);

            // team

            listBox1.Items.Add(ambiance_TextBox5.Text + ambiance_TextBox1.Text);
            listBox1.Items.Add(ambiance_TextBox5.Text + ambiance_TextBox2.Text);
            listBox1.Items.Add(ambiance_TextBox5.Text + ambiance_TextBox3.Text);
            listBox1.Items.Add(ambiance_TextBox5.Text + ambiance_TextBox4.Text);
            listBox1.Items.Add(ambiance_TextBox5.Text + ambiance_TextBox6.Text);
            listBox1.Items.Add(ambiance_TextBox5.Text + ambiance_TextBox7.Text);
            listBox1.Items.Add(ambiance_TextBox5.Text + ambiance_TextBox8.Text);
            listBox1.Items.Add(ambiance_TextBox5.Text + ambiance_TextBox9.Text);
            listBox1.Items.Add(ambiance_TextBox5.Text + ambiance_TextBox10.Text);
            listBox1.Items.Add(ambiance_TextBox5.Text + ambiance_TextBox11.Text);
            listBox1.Items.Add(ambiance_TextBox5.Text + ambiance_TextBox12.Text);
            listBox1.Items.Add(ambiance_TextBox5.Text + ambiance_TextBox13.Text);
            listBox1.Items.Add(ambiance_TextBox5.Text + ambiance_TextBox14.Text);
            listBox1.Items.Add(ambiance_TextBox5.Text + ambiance_TextBox15.Text);
            listBox1.Items.Add(ambiance_TextBox5.Text + ambiance_TextBox16.Text);
            listBox1.Items.Add(ambiance_TextBox5.Text + ambiance_TextBox17.Text);
            listBox1.Items.Add(ambiance_TextBox5.Text + ambiance_TextBox18.Text);
            listBox1.Items.Add(ambiance_TextBox5.Text + ambiance_TextBox19.Text);
            listBox1.Items.Add(ambiance_TextBox5.Text + ambiance_TextBox20.Text);
            listBox1.Items.Add(ambiance_TextBox5.Text + ambiance_TextBox21.Text);

            //city

            listBox1.Items.Add(ambiance_TextBox6.Text + ambiance_TextBox1.Text);
            listBox1.Items.Add(ambiance_TextBox6.Text + ambiance_TextBox2.Text);
            listBox1.Items.Add(ambiance_TextBox6.Text + ambiance_TextBox6.Text);
            listBox1.Items.Add(ambiance_TextBox6.Text + ambiance_TextBox6.Text);
            listBox1.Items.Add(ambiance_TextBox6.Text + ambiance_TextBox6.Text);
            listBox1.Items.Add(ambiance_TextBox6.Text + ambiance_TextBox7.Text);
            listBox1.Items.Add(ambiance_TextBox6.Text + ambiance_TextBox8.Text);
            listBox1.Items.Add(ambiance_TextBox6.Text + ambiance_TextBox9.Text);
            listBox1.Items.Add(ambiance_TextBox6.Text + ambiance_TextBox10.Text);
            listBox1.Items.Add(ambiance_TextBox6.Text + ambiance_TextBox11.Text);
            listBox1.Items.Add(ambiance_TextBox6.Text + ambiance_TextBox12.Text);
            listBox1.Items.Add(ambiance_TextBox6.Text + ambiance_TextBox13.Text);
            listBox1.Items.Add(ambiance_TextBox6.Text + ambiance_TextBox14.Text);
            listBox1.Items.Add(ambiance_TextBox6.Text + ambiance_TextBox15.Text);
            listBox1.Items.Add(ambiance_TextBox6.Text + ambiance_TextBox16.Text);
            listBox1.Items.Add(ambiance_TextBox6.Text + ambiance_TextBox17.Text);
            listBox1.Items.Add(ambiance_TextBox6.Text + ambiance_TextBox18.Text);
            listBox1.Items.Add(ambiance_TextBox6.Text + ambiance_TextBox19.Text);
            listBox1.Items.Add(ambiance_TextBox6.Text + ambiance_TextBox20.Text);
            listBox1.Items.Add(ambiance_TextBox6.Text + ambiance_TextBox21.Text);

            // favorite character

            listBox1.Items.Add(ambiance_TextBox7.Text + ambiance_TextBox1.Text);
            listBox1.Items.Add(ambiance_TextBox7.Text + ambiance_TextBox2.Text);
            listBox1.Items.Add(ambiance_TextBox7.Text + ambiance_TextBox3.Text);
            listBox1.Items.Add(ambiance_TextBox7.Text + ambiance_TextBox4.Text);
            listBox1.Items.Add(ambiance_TextBox7.Text + ambiance_TextBox5.Text);
            listBox1.Items.Add(ambiance_TextBox7.Text + ambiance_TextBox6.Text);
            listBox1.Items.Add(ambiance_TextBox7.Text + ambiance_TextBox8.Text);
            listBox1.Items.Add(ambiance_TextBox7.Text + ambiance_TextBox9.Text);
            listBox1.Items.Add(ambiance_TextBox7.Text + ambiance_TextBox10.Text);
            listBox1.Items.Add(ambiance_TextBox7.Text + ambiance_TextBox11.Text);
            listBox1.Items.Add(ambiance_TextBox7.Text + ambiance_TextBox12.Text);
            listBox1.Items.Add(ambiance_TextBox7.Text + ambiance_TextBox13.Text);
            listBox1.Items.Add(ambiance_TextBox7.Text + ambiance_TextBox14.Text);
            listBox1.Items.Add(ambiance_TextBox7.Text + ambiance_TextBox15.Text);
            listBox1.Items.Add(ambiance_TextBox7.Text + ambiance_TextBox16.Text);
            listBox1.Items.Add(ambiance_TextBox7.Text + ambiance_TextBox17.Text);
            listBox1.Items.Add(ambiance_TextBox7.Text + ambiance_TextBox18.Text);
            listBox1.Items.Add(ambiance_TextBox7.Text + ambiance_TextBox19.Text);
            listBox1.Items.Add(ambiance_TextBox7.Text + ambiance_TextBox20.Text);
            listBox1.Items.Add(ambiance_TextBox7.Text + ambiance_TextBox21.Text);

            // pet name

            listBox1.Items.Add(ambiance_TextBox8.Text + ambiance_TextBox1.Text);
            listBox1.Items.Add(ambiance_TextBox8.Text + ambiance_TextBox2.Text);
            listBox1.Items.Add(ambiance_TextBox8.Text + ambiance_TextBox3.Text);
            listBox1.Items.Add(ambiance_TextBox8.Text + ambiance_TextBox4.Text);
            listBox1.Items.Add(ambiance_TextBox8.Text + ambiance_TextBox5.Text);
            listBox1.Items.Add(ambiance_TextBox8.Text + ambiance_TextBox6.Text);
            listBox1.Items.Add(ambiance_TextBox8.Text + ambiance_TextBox7.Text);
            listBox1.Items.Add(ambiance_TextBox8.Text + ambiance_TextBox9.Text);
            listBox1.Items.Add(ambiance_TextBox8.Text + ambiance_TextBox10.Text);
            listBox1.Items.Add(ambiance_TextBox8.Text + ambiance_TextBox11.Text);
            listBox1.Items.Add(ambiance_TextBox8.Text + ambiance_TextBox12.Text);
            listBox1.Items.Add(ambiance_TextBox8.Text + ambiance_TextBox13.Text);
            listBox1.Items.Add(ambiance_TextBox8.Text + ambiance_TextBox14.Text);
            listBox1.Items.Add(ambiance_TextBox8.Text + ambiance_TextBox15.Text);
            listBox1.Items.Add(ambiance_TextBox8.Text + ambiance_TextBox16.Text);
            listBox1.Items.Add(ambiance_TextBox8.Text + ambiance_TextBox17.Text);
            listBox1.Items.Add(ambiance_TextBox8.Text + ambiance_TextBox18.Text);
            listBox1.Items.Add(ambiance_TextBox8.Text + ambiance_TextBox19.Text);
            listBox1.Items.Add(ambiance_TextBox8.Text + ambiance_TextBox20.Text);
            listBox1.Items.Add(ambiance_TextBox8.Text + ambiance_TextBox21.Text);

            // 2. child birth date

            listBox1.Items.Add(ambiance_TextBox9.Text + ambiance_TextBox1.Text);
            listBox1.Items.Add(ambiance_TextBox9.Text + ambiance_TextBox2.Text);
            listBox1.Items.Add(ambiance_TextBox9.Text + ambiance_TextBox3.Text);
            listBox1.Items.Add(ambiance_TextBox9.Text + ambiance_TextBox4.Text);
            listBox1.Items.Add(ambiance_TextBox9.Text + ambiance_TextBox5.Text);
            listBox1.Items.Add(ambiance_TextBox9.Text + ambiance_TextBox6.Text);
            listBox1.Items.Add(ambiance_TextBox9.Text + ambiance_TextBox7.Text);
            listBox1.Items.Add(ambiance_TextBox9.Text + ambiance_TextBox8.Text);
            listBox1.Items.Add(ambiance_TextBox9.Text + ambiance_TextBox10.Text);
            listBox1.Items.Add(ambiance_TextBox9.Text + ambiance_TextBox11.Text);
            listBox1.Items.Add(ambiance_TextBox9.Text + ambiance_TextBox12.Text);
            listBox1.Items.Add(ambiance_TextBox9.Text + ambiance_TextBox13.Text);
            listBox1.Items.Add(ambiance_TextBox9.Text + ambiance_TextBox14.Text);
            listBox1.Items.Add(ambiance_TextBox9.Text + ambiance_TextBox15.Text);
            listBox1.Items.Add(ambiance_TextBox9.Text + ambiance_TextBox16.Text);
            listBox1.Items.Add(ambiance_TextBox9.Text + ambiance_TextBox17.Text);
            listBox1.Items.Add(ambiance_TextBox9.Text + ambiance_TextBox18.Text);
            listBox1.Items.Add(ambiance_TextBox9.Text + ambiance_TextBox19.Text);
            listBox1.Items.Add(ambiance_TextBox9.Text + ambiance_TextBox20.Text);
            listBox1.Items.Add(ambiance_TextBox9.Text + ambiance_TextBox21.Text);

            // 1. child birth date

            listBox1.Items.Add(ambiance_TextBox10.Text + ambiance_TextBox1.Text);
            listBox1.Items.Add(ambiance_TextBox10.Text + ambiance_TextBox2.Text);
            listBox1.Items.Add(ambiance_TextBox10.Text + ambiance_TextBox3.Text);
            listBox1.Items.Add(ambiance_TextBox10.Text + ambiance_TextBox4.Text);
            listBox1.Items.Add(ambiance_TextBox10.Text + ambiance_TextBox5.Text);
            listBox1.Items.Add(ambiance_TextBox10.Text + ambiance_TextBox6.Text);
            listBox1.Items.Add(ambiance_TextBox10.Text + ambiance_TextBox7.Text);
            listBox1.Items.Add(ambiance_TextBox10.Text + ambiance_TextBox8.Text);
            listBox1.Items.Add(ambiance_TextBox10.Text + ambiance_TextBox9.Text);
            listBox1.Items.Add(ambiance_TextBox10.Text + ambiance_TextBox11.Text);
            listBox1.Items.Add(ambiance_TextBox10.Text + ambiance_TextBox12.Text);
            listBox1.Items.Add(ambiance_TextBox10.Text + ambiance_TextBox13.Text);
            listBox1.Items.Add(ambiance_TextBox10.Text + ambiance_TextBox14.Text);
            listBox1.Items.Add(ambiance_TextBox10.Text + ambiance_TextBox15.Text);
            listBox1.Items.Add(ambiance_TextBox10.Text + ambiance_TextBox16.Text);
            listBox1.Items.Add(ambiance_TextBox10.Text + ambiance_TextBox17.Text);
            listBox1.Items.Add(ambiance_TextBox10.Text + ambiance_TextBox18.Text);
            listBox1.Items.Add(ambiance_TextBox10.Text + ambiance_TextBox19.Text);
            listBox1.Items.Add(ambiance_TextBox10.Text + ambiance_TextBox20.Text);
            listBox1.Items.Add(ambiance_TextBox10.Text + ambiance_TextBox21.Text);

            // 2. child name

            listBox1.Items.Add(ambiance_TextBox11.Text + ambiance_TextBox1.Text);
            listBox1.Items.Add(ambiance_TextBox11.Text + ambiance_TextBox2.Text);
            listBox1.Items.Add(ambiance_TextBox11.Text + ambiance_TextBox3.Text);
            listBox1.Items.Add(ambiance_TextBox11.Text + ambiance_TextBox4.Text);
            listBox1.Items.Add(ambiance_TextBox11.Text + ambiance_TextBox5.Text);
            listBox1.Items.Add(ambiance_TextBox11.Text + ambiance_TextBox6.Text);
            listBox1.Items.Add(ambiance_TextBox11.Text + ambiance_TextBox7.Text);
            listBox1.Items.Add(ambiance_TextBox11.Text + ambiance_TextBox8.Text);
            listBox1.Items.Add(ambiance_TextBox11.Text + ambiance_TextBox9.Text);
            listBox1.Items.Add(ambiance_TextBox11.Text + ambiance_TextBox10.Text);
            listBox1.Items.Add(ambiance_TextBox11.Text + ambiance_TextBox12.Text);
            listBox1.Items.Add(ambiance_TextBox11.Text + ambiance_TextBox13.Text);
            listBox1.Items.Add(ambiance_TextBox11.Text + ambiance_TextBox14.Text);
            listBox1.Items.Add(ambiance_TextBox11.Text + ambiance_TextBox15.Text);
            listBox1.Items.Add(ambiance_TextBox11.Text + ambiance_TextBox16.Text);
            listBox1.Items.Add(ambiance_TextBox11.Text + ambiance_TextBox17.Text);
            listBox1.Items.Add(ambiance_TextBox11.Text + ambiance_TextBox18.Text);
            listBox1.Items.Add(ambiance_TextBox11.Text + ambiance_TextBox19.Text);
            listBox1.Items.Add(ambiance_TextBox11.Text + ambiance_TextBox20.Text);
            listBox1.Items.Add(ambiance_TextBox11.Text + ambiance_TextBox21.Text);


            // 1. child name

            listBox1.Items.Add(ambiance_TextBox12.Text + ambiance_TextBox1.Text);
            listBox1.Items.Add(ambiance_TextBox12.Text + ambiance_TextBox2.Text);
            listBox1.Items.Add(ambiance_TextBox12.Text + ambiance_TextBox3.Text);
            listBox1.Items.Add(ambiance_TextBox12.Text + ambiance_TextBox4.Text);
            listBox1.Items.Add(ambiance_TextBox12.Text + ambiance_TextBox5.Text);
            listBox1.Items.Add(ambiance_TextBox12.Text + ambiance_TextBox6.Text);
            listBox1.Items.Add(ambiance_TextBox12.Text + ambiance_TextBox7.Text);
            listBox1.Items.Add(ambiance_TextBox12.Text + ambiance_TextBox8.Text);
            listBox1.Items.Add(ambiance_TextBox12.Text + ambiance_TextBox9.Text);
            listBox1.Items.Add(ambiance_TextBox12.Text + ambiance_TextBox10.Text);
            listBox1.Items.Add(ambiance_TextBox12.Text + ambiance_TextBox11.Text);
            listBox1.Items.Add(ambiance_TextBox12.Text + ambiance_TextBox13.Text);
            listBox1.Items.Add(ambiance_TextBox12.Text + ambiance_TextBox14.Text);
            listBox1.Items.Add(ambiance_TextBox12.Text + ambiance_TextBox15.Text);
            listBox1.Items.Add(ambiance_TextBox12.Text + ambiance_TextBox16.Text);
            listBox1.Items.Add(ambiance_TextBox12.Text + ambiance_TextBox17.Text);
            listBox1.Items.Add(ambiance_TextBox12.Text + ambiance_TextBox18.Text);
            listBox1.Items.Add(ambiance_TextBox12.Text + ambiance_TextBox19.Text);
            listBox1.Items.Add(ambiance_TextBox12.Text + ambiance_TextBox20.Text);
            listBox1.Items.Add(ambiance_TextBox12.Text + ambiance_TextBox21.Text);

            // wife name

            listBox1.Items.Add(ambiance_TextBox13.Text + ambiance_TextBox1.Text);
            listBox1.Items.Add(ambiance_TextBox13.Text + ambiance_TextBox2.Text);
            listBox1.Items.Add(ambiance_TextBox13.Text + ambiance_TextBox3.Text);
            listBox1.Items.Add(ambiance_TextBox13.Text + ambiance_TextBox4.Text);
            listBox1.Items.Add(ambiance_TextBox13.Text + ambiance_TextBox5.Text);
            listBox1.Items.Add(ambiance_TextBox13.Text + ambiance_TextBox6.Text);
            listBox1.Items.Add(ambiance_TextBox13.Text + ambiance_TextBox7.Text);
            listBox1.Items.Add(ambiance_TextBox13.Text + ambiance_TextBox8.Text);
            listBox1.Items.Add(ambiance_TextBox13.Text + ambiance_TextBox9.Text);
            listBox1.Items.Add(ambiance_TextBox13.Text + ambiance_TextBox10.Text);
            listBox1.Items.Add(ambiance_TextBox13.Text + ambiance_TextBox11.Text);
            listBox1.Items.Add(ambiance_TextBox13.Text + ambiance_TextBox12.Text);
            listBox1.Items.Add(ambiance_TextBox13.Text + ambiance_TextBox14.Text);
            listBox1.Items.Add(ambiance_TextBox13.Text + ambiance_TextBox15.Text);
            listBox1.Items.Add(ambiance_TextBox13.Text + ambiance_TextBox16.Text);
            listBox1.Items.Add(ambiance_TextBox13.Text + ambiance_TextBox17.Text);
            listBox1.Items.Add(ambiance_TextBox13.Text + ambiance_TextBox18.Text);
            listBox1.Items.Add(ambiance_TextBox13.Text + ambiance_TextBox19.Text);
            listBox1.Items.Add(ambiance_TextBox13.Text + ambiance_TextBox20.Text);
            listBox1.Items.Add(ambiance_TextBox13.Text + ambiance_TextBox21.Text);

            // lucky number

            listBox1.Items.Add(ambiance_TextBox14.Text + ambiance_TextBox1.Text);
            listBox1.Items.Add(ambiance_TextBox14.Text + ambiance_TextBox2.Text);
            listBox1.Items.Add(ambiance_TextBox14.Text + ambiance_TextBox3.Text);
            listBox1.Items.Add(ambiance_TextBox14.Text + ambiance_TextBox4.Text);
            listBox1.Items.Add(ambiance_TextBox14.Text + ambiance_TextBox5.Text);
            listBox1.Items.Add(ambiance_TextBox14.Text + ambiance_TextBox6.Text);
            listBox1.Items.Add(ambiance_TextBox14.Text + ambiance_TextBox7.Text);
            listBox1.Items.Add(ambiance_TextBox14.Text + ambiance_TextBox8.Text);
            listBox1.Items.Add(ambiance_TextBox14.Text + ambiance_TextBox9.Text);
            listBox1.Items.Add(ambiance_TextBox14.Text + ambiance_TextBox10.Text);
            listBox1.Items.Add(ambiance_TextBox14.Text + ambiance_TextBox11.Text);
            listBox1.Items.Add(ambiance_TextBox14.Text + ambiance_TextBox12.Text);
            listBox1.Items.Add(ambiance_TextBox14.Text + ambiance_TextBox13.Text);
            listBox1.Items.Add(ambiance_TextBox14.Text + ambiance_TextBox15.Text);
            listBox1.Items.Add(ambiance_TextBox14.Text + ambiance_TextBox16.Text);
            listBox1.Items.Add(ambiance_TextBox14.Text + ambiance_TextBox17.Text);
            listBox1.Items.Add(ambiance_TextBox14.Text + ambiance_TextBox18.Text);
            listBox1.Items.Add(ambiance_TextBox14.Text + ambiance_TextBox19.Text);
            listBox1.Items.Add(ambiance_TextBox14.Text + ambiance_TextBox20.Text);
            listBox1.Items.Add(ambiance_TextBox14.Text + ambiance_TextBox21.Text);


            // 2. best friend

            listBox1.Items.Add(ambiance_TextBox15.Text + ambiance_TextBox1.Text);
            listBox1.Items.Add(ambiance_TextBox15.Text + ambiance_TextBox2.Text);
            listBox1.Items.Add(ambiance_TextBox15.Text + ambiance_TextBox3.Text);
            listBox1.Items.Add(ambiance_TextBox15.Text + ambiance_TextBox4.Text);
            listBox1.Items.Add(ambiance_TextBox15.Text + ambiance_TextBox5.Text);
            listBox1.Items.Add(ambiance_TextBox15.Text + ambiance_TextBox6.Text);
            listBox1.Items.Add(ambiance_TextBox15.Text + ambiance_TextBox7.Text);
            listBox1.Items.Add(ambiance_TextBox15.Text + ambiance_TextBox8.Text);
            listBox1.Items.Add(ambiance_TextBox15.Text + ambiance_TextBox9.Text);
            listBox1.Items.Add(ambiance_TextBox15.Text + ambiance_TextBox10.Text);
            listBox1.Items.Add(ambiance_TextBox15.Text + ambiance_TextBox11.Text);
            listBox1.Items.Add(ambiance_TextBox15.Text + ambiance_TextBox12.Text);
            listBox1.Items.Add(ambiance_TextBox15.Text + ambiance_TextBox13.Text);
            listBox1.Items.Add(ambiance_TextBox15.Text + ambiance_TextBox14.Text);
            listBox1.Items.Add(ambiance_TextBox15.Text + ambiance_TextBox16.Text);
            listBox1.Items.Add(ambiance_TextBox15.Text + ambiance_TextBox17.Text);
            listBox1.Items.Add(ambiance_TextBox15.Text + ambiance_TextBox18.Text);
            listBox1.Items.Add(ambiance_TextBox15.Text + ambiance_TextBox19.Text);
            listBox1.Items.Add(ambiance_TextBox15.Text + ambiance_TextBox20.Text);
            listBox1.Items.Add(ambiance_TextBox15.Text + ambiance_TextBox21.Text);

            // 1. best friend

            listBox1.Items.Add(ambiance_TextBox16.Text + ambiance_TextBox1.Text);
            listBox1.Items.Add(ambiance_TextBox16.Text + ambiance_TextBox2.Text);
            listBox1.Items.Add(ambiance_TextBox16.Text + ambiance_TextBox3.Text);
            listBox1.Items.Add(ambiance_TextBox16.Text + ambiance_TextBox4.Text);
            listBox1.Items.Add(ambiance_TextBox16.Text + ambiance_TextBox5.Text);
            listBox1.Items.Add(ambiance_TextBox16.Text + ambiance_TextBox6.Text);
            listBox1.Items.Add(ambiance_TextBox16.Text + ambiance_TextBox7.Text);
            listBox1.Items.Add(ambiance_TextBox16.Text + ambiance_TextBox8.Text);
            listBox1.Items.Add(ambiance_TextBox16.Text + ambiance_TextBox9.Text);
            listBox1.Items.Add(ambiance_TextBox16.Text + ambiance_TextBox10.Text);
            listBox1.Items.Add(ambiance_TextBox16.Text + ambiance_TextBox11.Text);
            listBox1.Items.Add(ambiance_TextBox16.Text + ambiance_TextBox12.Text);
            listBox1.Items.Add(ambiance_TextBox16.Text + ambiance_TextBox13.Text);
            listBox1.Items.Add(ambiance_TextBox16.Text + ambiance_TextBox14.Text);
            listBox1.Items.Add(ambiance_TextBox16.Text + ambiance_TextBox15.Text);
            listBox1.Items.Add(ambiance_TextBox16.Text + ambiance_TextBox17.Text);
            listBox1.Items.Add(ambiance_TextBox16.Text + ambiance_TextBox18.Text);
            listBox1.Items.Add(ambiance_TextBox16.Text + ambiance_TextBox19.Text);
            listBox1.Items.Add(ambiance_TextBox16.Text + ambiance_TextBox20.Text);
            listBox1.Items.Add(ambiance_TextBox16.Text + ambiance_TextBox21.Text);

            // 2. sibling name

            listBox1.Items.Add(ambiance_TextBox17.Text + ambiance_TextBox1.Text);
            listBox1.Items.Add(ambiance_TextBox17.Text + ambiance_TextBox2.Text);
            listBox1.Items.Add(ambiance_TextBox17.Text + ambiance_TextBox3.Text);
            listBox1.Items.Add(ambiance_TextBox17.Text + ambiance_TextBox4.Text);
            listBox1.Items.Add(ambiance_TextBox17.Text + ambiance_TextBox5.Text);
            listBox1.Items.Add(ambiance_TextBox17.Text + ambiance_TextBox6.Text);
            listBox1.Items.Add(ambiance_TextBox17.Text + ambiance_TextBox7.Text);
            listBox1.Items.Add(ambiance_TextBox17.Text + ambiance_TextBox8.Text);
            listBox1.Items.Add(ambiance_TextBox17.Text + ambiance_TextBox9.Text);
            listBox1.Items.Add(ambiance_TextBox17.Text + ambiance_TextBox10.Text);
            listBox1.Items.Add(ambiance_TextBox17.Text + ambiance_TextBox11.Text);
            listBox1.Items.Add(ambiance_TextBox17.Text + ambiance_TextBox12.Text);
            listBox1.Items.Add(ambiance_TextBox17.Text + ambiance_TextBox13.Text);
            listBox1.Items.Add(ambiance_TextBox17.Text + ambiance_TextBox14.Text);
            listBox1.Items.Add(ambiance_TextBox17.Text + ambiance_TextBox15.Text);
            listBox1.Items.Add(ambiance_TextBox17.Text + ambiance_TextBox16.Text);
            listBox1.Items.Add(ambiance_TextBox17.Text + ambiance_TextBox18.Text);
            listBox1.Items.Add(ambiance_TextBox17.Text + ambiance_TextBox19.Text);
            listBox1.Items.Add(ambiance_TextBox17.Text + ambiance_TextBox20.Text);
            listBox1.Items.Add(ambiance_TextBox17.Text + ambiance_TextBox21.Text);

            // 1. sibling name

            listBox1.Items.Add(ambiance_TextBox18.Text + ambiance_TextBox1.Text);
            listBox1.Items.Add(ambiance_TextBox18.Text + ambiance_TextBox2.Text);
            listBox1.Items.Add(ambiance_TextBox18.Text + ambiance_TextBox3.Text);
            listBox1.Items.Add(ambiance_TextBox18.Text + ambiance_TextBox4.Text);
            listBox1.Items.Add(ambiance_TextBox18.Text + ambiance_TextBox5.Text);
            listBox1.Items.Add(ambiance_TextBox18.Text + ambiance_TextBox6.Text);
            listBox1.Items.Add(ambiance_TextBox18.Text + ambiance_TextBox7.Text);
            listBox1.Items.Add(ambiance_TextBox18.Text + ambiance_TextBox8.Text);
            listBox1.Items.Add(ambiance_TextBox18.Text + ambiance_TextBox9.Text);
            listBox1.Items.Add(ambiance_TextBox18.Text + ambiance_TextBox10.Text);
            listBox1.Items.Add(ambiance_TextBox18.Text + ambiance_TextBox11.Text);
            listBox1.Items.Add(ambiance_TextBox18.Text + ambiance_TextBox12.Text);
            listBox1.Items.Add(ambiance_TextBox18.Text + ambiance_TextBox13.Text);
            listBox1.Items.Add(ambiance_TextBox18.Text + ambiance_TextBox14.Text);
            listBox1.Items.Add(ambiance_TextBox18.Text + ambiance_TextBox15.Text);
            listBox1.Items.Add(ambiance_TextBox18.Text + ambiance_TextBox16.Text);
            listBox1.Items.Add(ambiance_TextBox18.Text + ambiance_TextBox17.Text);
            listBox1.Items.Add(ambiance_TextBox18.Text + ambiance_TextBox19.Text);
            listBox1.Items.Add(ambiance_TextBox18.Text + ambiance_TextBox20.Text);
            listBox1.Items.Add(ambiance_TextBox18.Text + ambiance_TextBox21.Text);


            // father name

            listBox1.Items.Add(ambiance_TextBox19.Text + ambiance_TextBox1.Text);
            listBox1.Items.Add(ambiance_TextBox19.Text + ambiance_TextBox2.Text);
            listBox1.Items.Add(ambiance_TextBox19.Text + ambiance_TextBox3.Text);
            listBox1.Items.Add(ambiance_TextBox19.Text + ambiance_TextBox4.Text);
            listBox1.Items.Add(ambiance_TextBox19.Text + ambiance_TextBox5.Text);
            listBox1.Items.Add(ambiance_TextBox19.Text + ambiance_TextBox6.Text);
            listBox1.Items.Add(ambiance_TextBox19.Text + ambiance_TextBox7.Text);
            listBox1.Items.Add(ambiance_TextBox19.Text + ambiance_TextBox8.Text);
            listBox1.Items.Add(ambiance_TextBox19.Text + ambiance_TextBox9.Text);
            listBox1.Items.Add(ambiance_TextBox19.Text + ambiance_TextBox10.Text);
            listBox1.Items.Add(ambiance_TextBox19.Text + ambiance_TextBox11.Text);
            listBox1.Items.Add(ambiance_TextBox19.Text + ambiance_TextBox12.Text);
            listBox1.Items.Add(ambiance_TextBox19.Text + ambiance_TextBox13.Text);
            listBox1.Items.Add(ambiance_TextBox19.Text + ambiance_TextBox14.Text);
            listBox1.Items.Add(ambiance_TextBox19.Text + ambiance_TextBox15.Text);
            listBox1.Items.Add(ambiance_TextBox19.Text + ambiance_TextBox16.Text);
            listBox1.Items.Add(ambiance_TextBox19.Text + ambiance_TextBox17.Text);
            listBox1.Items.Add(ambiance_TextBox19.Text + ambiance_TextBox18.Text);
            listBox1.Items.Add(ambiance_TextBox19.Text + ambiance_TextBox20.Text);
            listBox1.Items.Add(ambiance_TextBox19.Text + ambiance_TextBox21.Text);

            // mother name

            listBox1.Items.Add(ambiance_TextBox20.Text + ambiance_TextBox1.Text);
            listBox1.Items.Add(ambiance_TextBox20.Text + ambiance_TextBox2.Text);
            listBox1.Items.Add(ambiance_TextBox20.Text + ambiance_TextBox3.Text);
            listBox1.Items.Add(ambiance_TextBox20.Text + ambiance_TextBox4.Text);
            listBox1.Items.Add(ambiance_TextBox20.Text + ambiance_TextBox5.Text);
            listBox1.Items.Add(ambiance_TextBox20.Text + ambiance_TextBox6.Text);
            listBox1.Items.Add(ambiance_TextBox20.Text + ambiance_TextBox7.Text);
            listBox1.Items.Add(ambiance_TextBox20.Text + ambiance_TextBox8.Text);
            listBox1.Items.Add(ambiance_TextBox20.Text + ambiance_TextBox9.Text);
            listBox1.Items.Add(ambiance_TextBox20.Text + ambiance_TextBox10.Text);
            listBox1.Items.Add(ambiance_TextBox20.Text + ambiance_TextBox11.Text);
            listBox1.Items.Add(ambiance_TextBox20.Text + ambiance_TextBox12.Text);
            listBox1.Items.Add(ambiance_TextBox20.Text + ambiance_TextBox13.Text);
            listBox1.Items.Add(ambiance_TextBox20.Text + ambiance_TextBox14.Text);
            listBox1.Items.Add(ambiance_TextBox20.Text + ambiance_TextBox15.Text);
            listBox1.Items.Add(ambiance_TextBox20.Text + ambiance_TextBox16.Text);
            listBox1.Items.Add(ambiance_TextBox20.Text + ambiance_TextBox17.Text);
            listBox1.Items.Add(ambiance_TextBox20.Text + ambiance_TextBox18.Text);
            listBox1.Items.Add(ambiance_TextBox20.Text + ambiance_TextBox19.Text);
            listBox1.Items.Add(ambiance_TextBox20.Text + ambiance_TextBox21.Text);


            listBox1.Items.Add(ambiance_TextBox21.Text + ambiance_TextBox1.Text);
            listBox1.Items.Add(ambiance_TextBox21.Text + ambiance_TextBox2.Text);
            listBox1.Items.Add(ambiance_TextBox21.Text + ambiance_TextBox3.Text);
            listBox1.Items.Add(ambiance_TextBox21.Text + ambiance_TextBox4.Text);
            listBox1.Items.Add(ambiance_TextBox21.Text + ambiance_TextBox5.Text);
            listBox1.Items.Add(ambiance_TextBox21.Text + ambiance_TextBox6.Text);
            listBox1.Items.Add(ambiance_TextBox21.Text + ambiance_TextBox7.Text);
            listBox1.Items.Add(ambiance_TextBox21.Text + ambiance_TextBox8.Text);
            listBox1.Items.Add(ambiance_TextBox21.Text + ambiance_TextBox9.Text);
            listBox1.Items.Add(ambiance_TextBox21.Text + ambiance_TextBox10.Text);
            listBox1.Items.Add(ambiance_TextBox21.Text + ambiance_TextBox11.Text);
            listBox1.Items.Add(ambiance_TextBox21.Text + ambiance_TextBox12.Text);
            listBox1.Items.Add(ambiance_TextBox21.Text + ambiance_TextBox13.Text);
            listBox1.Items.Add(ambiance_TextBox21.Text + ambiance_TextBox14.Text);
            listBox1.Items.Add(ambiance_TextBox21.Text + ambiance_TextBox15.Text);
            listBox1.Items.Add(ambiance_TextBox21.Text + ambiance_TextBox16.Text);
            listBox1.Items.Add(ambiance_TextBox21.Text + ambiance_TextBox17.Text);
            listBox1.Items.Add(ambiance_TextBox21.Text + ambiance_TextBox18.Text);
            listBox1.Items.Add(ambiance_TextBox21.Text + ambiance_TextBox19.Text);
            listBox1.Items.Add(ambiance_TextBox21.Text + ambiance_TextBox20.Text);

        }

        private void save_btn_Click(object sender, EventArgs e)
        {

            if (listBox1.Items.Count > 0)
            {
                using (TextWriter TW = new StreamWriter("list.txt"))
                {
                    foreach (string itemText in listBox1.Items)
                    {
                        TW.WriteLine(itemText);
                    }
                }
                Process.Start("list.txt");
            }
       
        }
    }
}
