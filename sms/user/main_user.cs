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

namespace sms.user
{
    public partial class main_user : Form
    {
        int myId;
        public main_user(int myId)
        {
            InitializeComponent();
            this.myId = myId;
        }

        bool isStore = false;
        SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\alnaseem\documents\visual studio 2012\Projects\sms\sms\Dashbord\Database1.mdf;Integrated Security=True");
       
        private void main_user_Load(object sender, EventArgs e)
        {
            sc.Open();

            SqlCommand cmd = new SqlCommand("select count(*) from items where count > 0", sc);
            label2.Text = cmd.ExecuteScalar().ToString();

            cmd = new SqlCommand("select count(*) from card where hide = 0 and user_id_in = "+myId, sc);
            label3.Text = cmd.ExecuteScalar().ToString();

            // SqlDataAdapter adapter = new SqlDataAdapter("select * from items",sc);
            // DataTable dt = new DataTable();
            // adapter.Fill(dt);
            // dataGridView1.DataSource = dt;

            sc.Close();

        }

        private void panel3_Click(object sender, EventArgs e)
        {
            isStore = true;

            SqlDataAdapter adapter = new SqlDataAdapter("select * from items where count > 0", sc);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            main_user_Load(sender, e);
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            isStore = false;
            SqlDataAdapter adapter = new SqlDataAdapter("select id,name,price from card where hide = 0 and user_id_in = "+myId, sc);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            main_user_Load(sender, e);
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (isStore)
                {
                    int pid = Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                    String name = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    int price = Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
                    int count = Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
                    BeyOrHide fm = new BeyOrHide(pid, myId, name, price, count, true);
                    fm.Show();
                }
                else
                {
                    int pid = Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                    //String name = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    //int price = Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
                    //int count = Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
                    BeyOrHide fm = new BeyOrHide(pid, myId, "", 0, 0, false);
                    fm.Show();
                }
            }
            catch { }
        }

 
    }
}
