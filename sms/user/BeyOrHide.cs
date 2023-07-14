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
using System.Data.SqlClient;

namespace sms.user
{
    public partial class BeyOrHide : Form
    {

        int pid;
        int uid;
        String name;
        int price;
        int count;

        bool isBuy = false;
        SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\alnaseem\documents\visual studio 2012\Projects\sms\sms\Dashbord\Database1.mdf;Integrated Security=True");

        public BeyOrHide(int pid,int uid,String name,int price,int count,bool isBuy)
        {
            InitializeComponent();
            this.pid = pid;
            this.uid = uid;
            this.name = name;
            this.price = price;
            this.count = count;
            this.isBuy = isBuy;
        }

        private void BeyOrHide_Load(object sender, EventArgs e)
        {
            if (!isBuy)
            {
                label1.Text = "هل تريد حذف العملية من السجل ؟";
       
            }
        }

        private void yes_Click(object sender, EventArgs e)
        {
            sc.Open();

            if (isBuy)
            {
                SqlCommand cmd = new SqlCommand("insert into card values('" + name + "'," + price + "," + uid + ",0)", sc);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("update items set count = " + (count - 1).ToString() + "where id = " + pid, sc);
                cmd.ExecuteNonQuery();
                this.Close();
            }
            else {
                SqlCommand cmd = new SqlCommand("update card set hide = 1 where id = " + pid, sc);
                cmd.ExecuteNonQuery();
                this.Close();

            }

            sc.Close();
        }

        private void no_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
