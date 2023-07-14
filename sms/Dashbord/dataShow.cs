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
    public partial class dataShow : Form
    {
        int id;
        public dataShow(int id)
        {
            this.id = id;
            InitializeComponent();
        }
        SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\alnaseem\documents\visual studio 2012\Projects\sms\sms\Dashbord\Database1.mdf;Integrated Security=True");
        private void dataShow_Load(object sender, EventArgs e)
        {
            SqlDataAdapter dat = new SqlDataAdapter("select * from card where user_id_in = "+id,sc);
            DataTable dt = new DataTable();
            dat.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}
