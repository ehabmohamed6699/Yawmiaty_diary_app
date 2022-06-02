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

namespace ODP1_Connected_Start
{
    public partial class EventsForm : Form
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;
        int maxId, newId = -1;
        public static EventsForm instance;
        public EventsForm()
        {
            InitializeComponent();
            instance = this;
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == null)
            {
                MessageBox.Show("Please Choose Day To Display Events");
                return;
            }
            if (event_name.Text.Equals(""))
            {
                MessageBox.Show("Please Enter Name Of Event");
                return;
            }
            DataTable dt = (DataTable)dataGridView1.DataSource;
            DataRow newRow = dt.NewRow();
            newRow[0] = newId;
            newRow[1] = Convert.ToDateTime(date_picker.Value.Year.ToString() + "-" + date_picker.Value.Month.ToString() + "-" + date_picker.Value.Day.ToString());
            newRow[2] = event_name.Text;
            newId++;
            dt.Rows.Add(newRow);
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
            adapter.Update(ds.Tables[1]);
            MessageBox.Show("Data Updated");
        }

        private void date_picker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void show_events_btn_Click(object sender, EventArgs e)
        {
            string constr = "User Id=scott;Password=tiger;Data Source=orcl";
            string cmdstr = @"select max(id) from events";
            adapter = new OracleDataAdapter(cmdstr, constr);
            ds = new DataSet();
            adapter.Fill(ds);
            try
            {
                maxId = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                newId = maxId + 1;
            }
            catch
            {
                newId = 1;
            }

            cmdstr = @"select * FROM days where day_date = :days";
            adapter = new OracleDataAdapter(cmdstr, constr);
            adapter.SelectCommand.Parameters.Add("day", Convert.ToDateTime(date_picker.Value.Year.ToString() + "-" + date_picker.Value.Month.ToString() + "-" + date_picker.Value.Day.ToString()));
            ds = new DataSet();
            ds.Tables.Add(new DataTable());
            adapter.Fill(ds.Tables[0]);

            if (ds.Tables[0].Select().Length == 0)
            {
                DataTable dt2 = ds.Tables[0];
                DataRow newRow2 = dt2.NewRow();
                newRow2[0] = Convert.ToDateTime(date_picker.Value.Year.ToString() + "-" + date_picker.Value.Month.ToString() + "-" + date_picker.Value.Day.ToString());
                newRow2[1] = 0;
                dt2.Rows.Add(newRow2);
            }

            cmdstr = @"select * from events where day_id = :day";
            adapter = new OracleDataAdapter(cmdstr, constr);
            adapter.SelectCommand.Parameters.Add("day", Convert.ToDateTime(date_picker.Value.Year.ToString() + "-" + date_picker.Value.Month.ToString() + "-" + date_picker.Value.Day.ToString()));
            ds.Tables.Add(new DataTable());
            adapter.Fill(ds.Tables[1]);
            dataGridView1.DataSource = ds.Tables[1];
        }
    }
}
