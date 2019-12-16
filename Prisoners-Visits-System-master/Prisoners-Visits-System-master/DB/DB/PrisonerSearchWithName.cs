using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace DB
{
    public partial class PrisonerSearchWithName : Form
    {
        OracleDataAdapter adapter;
        DataSet ds;
        string con = "data source = ORCL;user id = scott; password = tiger;";

        public PrisonerSearchWithName()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cmdstr = "select * from prisoner where pr_name like :name|| '%' ";
            adapter = new OracleDataAdapter(cmdstr, con);
            adapter.SelectCommand.Parameters.Add("name", textBox1.Text);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void PrisonerSearchWithName_Load(object sender, EventArgs e)
        {

        }
    }
}
