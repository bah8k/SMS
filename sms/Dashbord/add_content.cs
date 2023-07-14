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

namespace sms.Dashbord
{
    public partial class add_content : Form
    {
        int id;
        public add_content(int id)
        {
            InitializeComponent();
            this.id = id;
        }
        SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\alnaseem\documents\visual studio 2012\Projects\sms\sms\Dashbord\Database1.mdf;Integrated Security=True");

        private void button_Click(object sender, EventArgs e)
        {

            sc.Open();
            SqlCommand cmd = new SqlCommand("update items set count = "+textBox1.Text+" where id ="+id,sc);
            cmd.ExecuteNonQuery();
            sc.Close();
            this.Close();

        }

        private void add_content_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

    }
}
