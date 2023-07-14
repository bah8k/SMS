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
    public partial class main_dsh : Form
    {
        public main_dsh()
        {
            InitializeComponent();
        }
        bool isF = false;
        bool isCustemer = false;

        SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\alnaseem\documents\visual studio 2012\Projects\sms\sms\Dashbord\Database1.mdf;Integrated Security=True");

        private void panel1_Click(object sender, EventArgs e)
        {
            Dashbord.add_item add = new add_item();
            add.Show();
        }

        private void main_dsh_Load(object sender, EventArgs e)
        {
            sc.Open();

            SqlCommand cmd = new SqlCommand("select count(*) from items",sc);
            label3.Text = cmd.ExecuteScalar().ToString();

            cmd = new SqlCommand("select count(*) from items where count < 1", sc);
            label5.Text = cmd.ExecuteScalar().ToString();

            cmd = new SqlCommand("select count(*) from users", sc);
            label2.Text = cmd.ExecuteScalar().ToString();

           // SqlDataAdapter adapter = new SqlDataAdapter("select * from items",sc);
           // DataTable dt = new DataTable();
           // adapter.Fill(dt);
           // dataGridView1.DataSource = dt;

            sc.Close();

        }

        private void panel2_Click(object sender, EventArgs e)
        {
            isF = true;
            isCustemer = false;
            SqlDataAdapter adapter = new SqlDataAdapter("select * from items where count < 1", sc);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            main_dsh_Load(sender,e);
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            isF = false;
            isCustemer = false;
            SqlDataAdapter adapter = new SqlDataAdapter("select * from items", sc);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            main_dsh_Load(sender, e);

        }

        private void panel3_Click(object sender, EventArgs e)
        {
            isF = false;
            isCustemer = true;
            SqlDataAdapter adapter = new SqlDataAdapter("select * from users", sc);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            main_dsh_Load(sender, e);

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (isF)
                {
                    add_content frm = new add_content(Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells[0].Value));
                    frm.Show();
                }
                else if (isCustemer)
                {
                    dataShow frm = new dataShow(Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells[0].Value));
                    frm.Show();
                }
            }
            catch { }
        }
    }
}
