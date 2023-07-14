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
    public partial class create : Form
    {
        public create()
        {
            InitializeComponent();
        }
        SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\alnaseem\documents\visual studio 2012\Projects\sms\sms\Dashbord\Database1.mdf;Integrated Security=True");

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            sc.Open();
            SqlCommand cmd = new SqlCommand("insert into users values('" + userTB.Text + "','" + passTB.Text + "')",sc);
            cmd.ExecuteNonQuery();
            sc.Close();
            this.Hide();
            Form1 fm = new Form1();
            fm.Show();
            
        }
    }
}
