using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect_Database
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        Dbcontion Q = new Dbcontion();

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Q.Query("SELECT * FROM  tb_Employee");
            comboBoxem.DataSource = Q.ds.Tables["EMP"];
            comboBoxem.DisplayMember = "Em_id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Em_id;
            String goods_ID;
            Em_id = comboBoxem.Text.ToString();
            goods_ID = comboBoxgd.Text.ToString();
            Q.Query("insert into sell (Em_id,goods_ID) values('" + Em_id + "','" + goods_ID + "')");
        }

        private void comboBoxgd_SelectedIndexChanged(object sender, EventArgs e)
        {
            Q.Query("SELECT * FROM tb_goods");
            comboBoxgd.DataSource = Q.ds.Tables["EMP"];
            comboBoxgd.DisplayMember = "goods_ID";
        }
    }
}
