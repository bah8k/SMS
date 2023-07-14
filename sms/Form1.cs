using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace sms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\alnaseem\documents\visual studio 2012\Projects\sms\sms\Dashbord\Database1.mdf;Integrated Security=True");
        private void singUpLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            create fm = new create();
            fm.Show();   
            
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            String min = (DateTime.Now.Minute+2).ToString();
            if (userTB.Text == "admin" && passTB.Text == "admin" + min)
            {

                Dashbord.main_dsh newF = new Dashbord.main_dsh();
                this.Hide();
                newF.Show();
            }
            else {
                try
                {
                    sc.Open();
                    SqlCommand cmd = new SqlCommand("select id from users where username = '" + userTB.Text + "' and pass = '" + passTB.Text + "'", sc);
                    int id  = Convert.ToInt16(cmd.ExecuteScalar().ToString());
                    sc.Close();

                    user.main_user fm = new user.main_user(id);
                    this.Hide();
                    fm.Show();
                }
                catch {
                    MessageBox.Show("Faild!");
                }
            }
        }

        private void userTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void passTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
