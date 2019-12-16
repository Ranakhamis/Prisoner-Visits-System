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
    public partial class visitorSelection : Form
    {
        string ordb = "Data source =ORCL; User Id = scott; password = tiger;";
        OracleConnection con;
        DataTable gridSource = new DataTable();

        public visitorSelection()
        {
            InitializeComponent();

        }

        private void visitorSelection_Load(object sender, EventArgs e)
        { 
            con = new OracleConnection(ordb);
            con.Open();
            OracleCommand cmd = new OracleCommand();
            gridSource.Columns.Add("ID", typeof(int));
            gridSource.Columns.Add("Visitor Name", typeof(string));
            gridSource.Columns.Add("Prisoner Name", typeof(string));
            select_all_visitors.DataSource = gridSource;

            ///////////// USING WHERE CONDITION
            cmd.CommandText = "select visitor_id from visitor";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                visitor_ids.Items.Add(reader[0].ToString());
                visitor_ids.SelectedIndex = 0;
            }

            ///////////// NOT USING WHERE CONDITION.
            cmd.Connection = con;
            cmd.CommandText = "select * from visitor";
            cmd.CommandType = CommandType.Text;

            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                gridSource.Rows.Add(reader[0].ToString(),reader[2].ToString(), reader[1].ToString());
            }




        }

        private void visitorSelection_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }

        private void visitor_ids_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = con;
            c.CommandText = "select visitor_name from visitor where visitor_id =:id";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("id", visitor_ids.SelectedItem.ToString());
            OracleDataReader dr = c.ExecuteReader();
            if (dr.Read())
            {
                visitor_name.Text = dr[0].ToString();
            }
            dr.Close();
        }

        private void select_all_visitors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
