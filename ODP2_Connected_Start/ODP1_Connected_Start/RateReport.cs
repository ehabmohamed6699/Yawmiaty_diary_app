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
    public partial class RateReport : Form
    {
        CrystalReport1 cr;
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;
        List<object> jokes = new List<object>();
        public RateReport()
        {
            InitializeComponent();
        }

        private void RateReport_Load(object sender, EventArgs e)
        {
            cr = new CrystalReport1();
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select text from jokes";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                jokes.Add(dr[0]);
            }
            dr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn;
            cmd2.CommandText = "select * from days where day_date = :dayx";
            cmd2.Parameters.Add("dayx", Convert.ToDateTime(dateTimePicker2.Value.Year.ToString() + "-" + dateTimePicker2.Value.Month.ToString() + "-" + dateTimePicker2.Value.Day.ToString()));
            OracleDataReader dr = cmd2.ExecuteReader();
            

            cr.SetParameterValue(0, (Convert.ToDateTime(dateTimePicker2.Value.Year.ToString() + "-" + dateTimePicker2.Value.Month.ToString() + "-" + dateTimePicker2.Value.Day.ToString())));

            crystalReportViewer1.ReportSource = cr;


            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GETAVGRATE";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("day", Convert.ToDateTime(dateTimePicker2.Value.Year.ToString() + "-" + dateTimePicker2.Value.Month.ToString() + "-" + dateTimePicker2.Value.Day.ToString()));
            cmd.Parameters.Add("avgRate", OracleDbType.BinaryFloat, ParameterDirection.Output);
            cmd.ExecuteNonQuery();
            if (dr.Read())
            {
                label1.Text = cmd.Parameters["avgRate"].Value.ToString();
                if (!(cmd.Parameters["avgRate"].Value.ToString().Equals("null")))
                {
                    float n = float.Parse((cmd.Parameters["avgRate"].Value.ToString()));
                    if (n <= 2.0)
                    {
                        Random rnd = new Random();
                        int num = rnd.Next(7);
                        MessageBox.Show(jokes[num].ToString());

                    }
                    else
                    {
                        MessageBox.Show("You're in a good mood!");
                    }
                }
                
            }
            
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

    }
}
