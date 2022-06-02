using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace ODP1_Connected_Start
{
    public partial class EventsReport : Form
    {
        CrystalReport2 cr;
        public EventsReport()
        {
            InitializeComponent();
        }

        private void EventsReport_Load(object sender, EventArgs e)
        {
            cr = new CrystalReport2();

            foreach (ParameterDiscreteValue v in cr.ParameterFields[0].DefaultValues)
                comboBox1.Items.Add(v.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cr.SetParameterValue(0, comboBox1.Text);
            crystalReportViewer1.ReportSource = cr;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
