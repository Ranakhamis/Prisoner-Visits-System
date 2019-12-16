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
    public partial class visitorFunction : Form
    {
        string ordb = "data source = ORCL;user id = scott; password = tiger;";
        OracleConnection con;
        public visitorFunction()
        {
            InitializeComponent();
        }
        private void visitorFunction_Load(object sender, EventArgs e)
        {
            con = new OracleConnection(ordb);
            OracleCommand cmd = new OracleCommand();

            con.Open();
            cmd.CommandText = "select pr_name from prisoner";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                prisoner_lists.Items.Add(reader[0].ToString());
            }

            cmd.CommandText = "select visitor_id from visitor";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                visitorIDS.Items.Add(reader[0].ToString());
                visitorIDS.SelectedIndex = 0;
            }

        }

        private void visitorFunction_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into visitor values(:id,:prisonername,:visitorname)";
            cmd.Parameters.Add("id", visitorIDS.Text); // BIND VALUE;   // hna text 3shan bzwd 7aga msh selected 2sasn.
            cmd.Parameters.Add("prisonername", prisoner_name.Text); // BIND VALUE;
            cmd.Parameters.Add("visitorname", visitor_name.Text);// BIND VALUE;
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                visitorIDS.Items.Add(visitorIDS.Text);
                MessageBox.Show("New Visitor is in");
            }
        }

        private void visitorIDS_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = con;
            c.CommandText = "select * from visitor where visitor_id =:id";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("id", visitorIDS.SelectedItem.ToString());
            OracleDataReader dr = c.ExecuteReader();
            if (dr.Read())
            {
                visitor_name.Text = dr[2].ToString();
                prisoner_name.Text = dr[1].ToString();
            }
            dr.Close();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "delete from visitor where visitor_id = :id";
            cmd.Parameters.Add("id", visitorIDS.Text); // BIND VALUE;
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("Actor is Deleted");
                visitorIDS.Items.RemoveAt(visitorIDS.SelectedIndex);
                prisoner_name.Text = "";
                visitor_name.Text = "";
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "update visitor set visitor_name = :visitorname, pr_name = :prname where visitor_id = :id";
            cmd.Parameters.Add("visitorname", visitor_name.Text); // BIND VALUE;
            cmd.Parameters.Add("prname", prisoner_name.Text); // BIND VALUE;
            cmd.Parameters.Add("id", visitorIDS.Text); // BIND VALUE;
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("Actor is Updated");
            }
        }
    }
}
