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
    public partial class Case : Form
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;
        string con = "data source = ORCL;user id = scott; password = tiger;";
        public Case()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string cmdstr = @"insert into case 
                values (:case_ids , :case_names) 
                                                    ";
            adapter = new OracleDataAdapter(cmdstr, con);
            adapter.SelectCommand.Parameters.Add("case_ids", textBox2.Text);
            adapter.SelectCommand.Parameters.Add("case_names", comboBox2.Text);


            ds = new DataSet();
            adapter.Fill(ds);

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Case_Load(object sender, EventArgs e)
        {
            //DataSet ds = new DataSet();

            //OracleDataAdapter adapter1 = new OracleDataAdapter("SELECT * from case", con);
            //adapter1.Fill(ds,"case");

            //OracleDataAdapter adapter2 = new OracleDataAdapter("SELECT * from prisoner", con);
            //adapter2.Fill(ds,"prisoners");
            
            //DataRelation r = new DataRelation("fk",ds.Tables[0].Columns["case_id"],
            //                                    ds.Tables[1].Columns["pr_id"] );
            //ds.Relations.Add(r);

            //BindingSource bs_Master = new BindingSource(ds, "case");
            //BindingSource bs_Child = new BindingSource(bs_Master, "fk");

            //dataGridView1.DataSource = bs_Master;
            //dataGridView2.DataSource = bs_Child;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string cmdstr = "Delete from case where case_name = :case_name ";

            adapter = new OracleDataAdapter(cmdstr, con);
            adapter.SelectCommand.Parameters.Add("case_name", comboBox2.Text);

            ds = new DataSet();
            adapter.Fill(ds);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cmdstr = @"update case
                              set case_id = :id , case_name = :name where case_id = :id ";
            adapter = new OracleDataAdapter(cmdstr, con);
            adapter.SelectCommand.Parameters.Add("id", textBox2.Text);
            adapter.SelectCommand.Parameters.Add("name", comboBox2.Text);

            ds = new DataSet();
            adapter.Fill(ds);

        }
    }
}
