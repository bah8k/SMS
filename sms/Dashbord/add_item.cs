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
    public partial class add_item : Form
    {
        public add_item()
        {
            InitializeComponent();
        }
        SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\alnaseem\documents\visual studio 2012\Projects\sms\sms\Dashbord\Database1.mdf;Integrated Security=True");
        private void add_item_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sc.Open();
            SqlCommand cmd = new SqlCommand("insert into items values('" + nameTB.Text + "'," + priceTB.Text + "," + countTB.Text+")", sc);
            cmd.ExecuteNonQuery();
            this.Close();
            sc.Close();

        }
    }
}
