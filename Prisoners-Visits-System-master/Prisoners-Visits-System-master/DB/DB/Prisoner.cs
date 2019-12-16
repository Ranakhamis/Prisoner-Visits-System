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
    public partial class Prisoner : Form
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;
        string con = "data source = ORCL;user id = scott; password = tiger;";

        public Prisoner()
        {
            InitializeComponent();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Prisoner_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
        
        private void insert_Click(object sender, EventArgs e)
        {

            string cmdstr = @"insert into prisoner 
                values (:name , :age , :time , :start_date , :id , :gender,1) 
                                                    ";

            adapter = new OracleDataAdapter(cmdstr, con);
            adapter.SelectCommand.Parameters.Add("name", Name_cm.Text);
            adapter.SelectCommand.Parameters.Add("age", Age_txt.Text);
            adapter.SelectCommand.Parameters.Add("time", duration_txt.Text );
            adapter.SelectCommand.Parameters.Add("start_date", Convert.ToDateTime(dateTimePicker1.Text));
            adapter.SelectCommand.Parameters.Add("id", id_txt.Text);
            adapter.SelectCommand.Parameters.Add("gender", gender_txt.Text);

            ds = new DataSet();
            adapter.Fill(ds);

        }

        private void Selectall_Click(object sender, EventArgs e)
        {
            string cmdstr = "select * from prisoner";
            adapter = new OracleDataAdapter(cmdstr, con);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
        }

        private void update_Click(object sender, EventArgs e)
        {
            string cmdstr = @"update prisoner
                              set pr_name = :name, pr_age = :age , pr_time = :time , pr_start_time = :start_date , pr_gender = :gender  
                              where pr_id = :id ";
            adapter = new OracleDataAdapter(cmdstr, con);
            adapter.SelectCommand.Parameters.Add("name", (string)Name_cm.Text);
            adapter.SelectCommand.Parameters.Add("age", Age_txt.Text);
            adapter.SelectCommand.Parameters.Add("time", duration_txt.Text);
            adapter.SelectCommand.Parameters.Add("start_date", Convert.ToDateTime(dateTimePicker1.Text));
            adapter.SelectCommand.Parameters.Add("gender", gender_txt.Text);
            adapter.SelectCommand.Parameters.Add("id", id_txt.Text);
            ds = new DataSet();
            adapter.Fill(ds);

        }

        private void delete_Click(object sender, EventArgs e)
        {
            string cmdstr = "Delete from prisoner where pr_name = :name ";
            adapter = new OracleDataAdapter(cmdstr, con);
            adapter.SelectCommand.Parameters.Add("name", Name_cm.Text);
            ds = new DataSet();
            adapter.Fill(ds);

        }

        private void Name_cm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
    }
