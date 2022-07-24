using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Connect_Database
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

        }
        Dbcontion Q = new Dbcontion();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        

        }

        private void display()
        {
            string sql = "select*from tb_Employee";
            Q.Query(sql);

            dataGridView1.DataSource = Q.ds.Tables["EMP"];
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            display();
        }

        private void edit()
        {
            string sql = "Update tb_Employee set Em_Name = @name, surename, phone, email, note";
        }
    }
}
