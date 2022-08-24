using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Collections.Specialized;
using System.IO;
using System.IO.Ports;
using System.Threading;
using System.Text.RegularExpressions;

namespace Cafe_Asia
{
    public partial class sms : Form
    {
        public sms()
        {
            InitializeComponent();
        }

        private void sms_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_pwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_send_Click(object sender, EventArgs e)
        {

            try
            {
                WebClient client = new WebClient();
                // client.Headers.Add("user - agent", "Mozilla / 4.0(compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");

                client.QueryString.Add("id", txt_username.Text);
                client.QueryString.Add("pw", txt_port.Text);
                client.QueryString.Add("to", txt_number.Text);
                client.QueryString.Add("text", txt_message.Text);
                string baseurl = "http://www.textit.biz/sendmsg";
                Stream data = client.OpenRead(baseurl);
                StreamReader reader = new StreamReader(data);
                string s = reader.ReadToEnd();
                MessageBox.Show( "Message sent succefully", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                data.Close();
                reader.Close();
            }
            catch(FormatException)
            {
                MessageBox.Show( "Please enter numbers only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception)
            {
                MessageBox.Show( "Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           // return(s);
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconPictureBox9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Dashboard ad1 = new Admin_Dashboard();
            ad1.Show();
        }

        private void txt_username_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_username.Text))
            {
                e.Cancel = true;
                txt_username.Focus();
                errorProvider1.SetError(txt_username, "please enter your username");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt_username, null);

            }
        }

        private void txt_port_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_port_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_port.Text) || txt_port.Text.Length > 8)
            {
                e.Cancel = true;
                txt_port.Focus();
                errorProvider1.SetError(txt_port, "please enter your password");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt_port, null);

            }
        }

        private void txt_number_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(txt_number.Text, @"^(?:7|0|(?:\+94))[0-9]{9,10}$"))
            {
                e.Cancel = true;
                txt_number.Focus();
                errorProvider1.SetError(txt_number, "contact number must have 10 numbers");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt_number, null);

            }
        }
    }
}
