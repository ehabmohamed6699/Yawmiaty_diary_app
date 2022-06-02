using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace ODP1_Connected_Start
{
    public partial class Yawmiaty : Form
    {
        string ordb = "data source=orcl; user id=scott; password=tiger;";
        OracleConnection conn;
        List<int> todo_ids = new List<int>();

        public static Yawmiaty instance;
        public Yawmiaty()
        {
            InitializeComponent();
            instance = this;
        }

        private void ActorsForm_Load(object sender, EventArgs e)
        {

            dateLabel.Text = DateTime.Now.ToShortDateString();
            timeLabel.Text = DateTime.Now.ToShortTimeString();


            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GETTODOS";
            cmd.CommandType = CommandType.StoredProcedure;
            //**********************
            cmd.Parameters.Add("day", Convert.ToDateTime(dateTimePicker1.Value.Year.ToString() + "-" + dateTimePicker1.Value.Month.ToString() + "-" + dateTimePicker1.Value.Day.ToString()));
            cmd.Parameters.Add("todos", OracleDbType.RefCursor, ParameterDirection.Output);

            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                todoCheckListBox.Items.Add(dr[0], Convert.ToInt32(dr[1]) == 0 ? false : true);
                todo_ids.Add(Convert.ToInt32(dr[2]));
            }

            dr.Close();

            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn;
            cmd2.CommandText = "GETNONTES";
            // add GETNOTES procedure same as get todos to oracle
            cmd2.CommandType = CommandType.StoredProcedure;
            //**********************
            cmd2.Parameters.Add("day", Convert.ToDateTime(dateTimePicker1.Value.Year.ToString() + "-" + dateTimePicker1.Value.Month.ToString() + "-" + dateTimePicker1.Value.Day.ToString()));
            cmd2.Parameters.Add("notes", OracleDbType.RefCursor, ParameterDirection.Output);

            OracleDataReader dr2 = cmd2.ExecuteReader();

            while (dr2.Read())
            {
                object[] row = {dr2[5], dr2[2], dr2[3], dr2[4], dr2[0]};
                notesdgv.Rows.Insert(0,row);
            }

            dr2.Close();

        }

        private void addNewTodo_Click(object sender, EventArgs e)
        {
            if(newTodo.Text != "")
            {

                int maxId, newId = -1;

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "getMaxId";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("maxId", OracleDbType.Int32, ParameterDirection.Output);
                cmd.ExecuteNonQuery();

                try
                {
                    maxId = Convert.ToInt32(cmd.Parameters["maxId"].Value.ToString());
                    newId = maxId + 1;
                }
                catch
                {
                    newId = 1;
                }

                OracleCommand cmd2 = new OracleCommand();
                cmd2.Connection = conn;
                cmd2.CommandText = @"insert into todo 
                                    values (:id, :datex, :task, 0)";

                cmd2.Parameters.Add("id", newId);
                cmd2.Parameters.Add("datex", Convert.ToDateTime(dateTimePicker1.Value.Year.ToString() + "-" + dateTimePicker1.Value.Month.ToString() + "-" + dateTimePicker1.Value.Day.ToString()));
                cmd2.Parameters.Add("task",newTodo.Text);
                int r = cmd2.ExecuteNonQuery();
                if (r != -1)
                {
                    todoCheckListBox.Items.Add(newTodo.Text);
                    newTodo.Text = "";
                    MessageBox.Show("new todo added");

                }
            }
        }

        private void saveNote_Click(object sender, EventArgs e)
        {
            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn;
            cmd2.CommandText = @"INSERT INTO notes VALUES (:id,:dayy,:pr,:ra,:fa,:te)";

            int maxId, newId = -1;

            OracleCommand cmd3 = new OracleCommand();
            cmd3.Connection = conn;
            cmd3.CommandText = "select max(id) from notes";
            cmd3.CommandType = CommandType.Text;
            OracleDataReader dr3 = cmd3.ExecuteReader();

            if (dr3.Read())
            {
                try
                {
                    maxId = Convert.ToInt32(dr3[0]);
                    newId = maxId + 1;
                }
                catch
                {
                    newId = 1;
                }
            }
            cmd2.Parameters.Add("id", newId);
            cmd2.Parameters.Add("dayy", Convert.ToDateTime(dateTimePicker1.Value.Year.ToString() + "-" + dateTimePicker1.Value.Month.ToString() + "-" + dateTimePicker1.Value.Day.ToString()));
            cmd2.Parameters.Add("pr", Convert.ToInt32(notePriorityComboBox.SelectedItem.ToString()));
            cmd2.Parameters.Add("ra", Convert.ToInt32(noteRateComboBox.SelectedItem.ToString()));
            cmd2.Parameters.Add("fa", favCheck.Checked ? 1 : 0);
            cmd2.Parameters.Add("te", noteTextbox.Text);
            //*********************
            cmd2.CommandType = CommandType.Text;
            int r2 = cmd2.ExecuteNonQuery();
            if (r2 != -1)
            {
                object[] row = {noteTextbox.Text,
                                Convert.ToInt32(notePriorityComboBox.SelectedItem.ToString()),
                                Convert.ToInt32(noteRateComboBox.SelectedItem.ToString()),
                                favCheck.Checked ? 1 : 0};
                notesdgv.Rows.Add(row);
                MessageBox.Show("note saved");
            }
        }

        private void notesdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            noteTextbox.Text = notesdgv.CurrentRow.Cells[0].Value.ToString();
            notePriorityComboBox.SelectedIndex = Convert.ToInt32(notesdgv.CurrentRow.Cells[1].Value.ToString()) - 1;
            noteRateComboBox.SelectedIndex = Convert.ToInt32(notesdgv.CurrentRow.Cells[2].Value.ToString()) - 1;
            favCheck.Checked = Convert.ToInt32(notesdgv.CurrentRow.Cells[3].Value.ToString()) == 1 ? true : false;
        }

        private void updateNotebtn_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            int tempID = 0;
            cmd.CommandText = @"update notes 
                                set priority = :p,
                                rate = :r,
                                favourite = :f, 
                                text = :t where id = :id";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("p", Convert.ToInt32(notePriorityComboBox.SelectedItem.ToString()));
            cmd.Parameters.Add("r", Convert.ToInt32(noteRateComboBox.SelectedItem.ToString()));
            cmd.Parameters.Add("f", favCheck.Checked ? 1 : 0);
            cmd.Parameters.Add("t", noteTextbox.Text);
            //************************
            cmd.Parameters.Add("id", Convert.ToInt32(notesdgv.CurrentRow.Cells[4].Value.ToString()));
            int r = cmd.ExecuteNonQuery();

            if (r != 0)
            {
                notesdgv.CurrentRow.Cells[0].Value = noteTextbox.Text;
                notesdgv.CurrentRow.Cells[1].Value = notePriorityComboBox.SelectedItem.ToString();
                notesdgv.CurrentRow.Cells[2].Value = noteRateComboBox.SelectedItem.ToString();
                notesdgv.CurrentRow.Cells[3].Value = favCheck.Checked ? 1 : 0;
                MessageBox.Show("note updated");
            }
        }

        private void events_btn_Click(object sender, EventArgs e)
        {
            EventsForm form = new EventsForm();
            form.Show();
        }

        private void todoCheckListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void todoCheckListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            
        }

        private void save_btn_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < todo_ids.Count(); i++)
            {
                OracleCommand saveTodo = new OracleCommand();
                saveTodo.Connection = conn;
                saveTodo.CommandText = "update todo set checked = :checked WHERE id = :id";
                saveTodo.CommandType = CommandType.Text;
                saveTodo.Parameters.Add("checked", todoCheckListBox.GetItemChecked(i) ? 1.ToString() : 0.ToString());
                saveTodo.Parameters.Add("id", todo_ids[i]);
                saveTodo.ExecuteNonQuery();
            }
            MessageBox.Show("Progress Saved");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            OracleCommand addDate = new OracleCommand();
            addDate.Connection = conn;
            addDate.CommandText = @"select * FROM days where day_date = :days";
            addDate.Parameters.Add("day", Convert.ToDateTime(dateTimePicker1.Value.Year.ToString() + "-" + dateTimePicker1.Value.Month.ToString() + "-" + dateTimePicker1.Value.Day.ToString()));
            addDate.CommandType = CommandType.Text;

            OracleDataReader drDate = addDate.ExecuteReader();
            if (!drDate.Read())
            {
                OracleCommand addDate2 = new OracleCommand();
                addDate2.Connection = conn;
                addDate2.CommandText = @"insert into days values(:dayID,0)";
                addDate2.CommandType = CommandType.Text;
                DateTime x = Convert.ToDateTime(dateTimePicker1.Value.Year.ToString() + "-" + dateTimePicker1.Value.Month.ToString() + "-" + dateTimePicker1.Value.Day.ToString());
                addDate2.Parameters.Add("dayID", x);
                addDate2.ExecuteNonQuery();
            }


            todoCheckListBox.Items.Clear();
            todo_ids.Clear();
            notesdgv.Rows.Clear();
            dateLabel.Text = DateTime.Now.ToShortDateString();
            timeLabel.Text = DateTime.Now.ToShortTimeString();


            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GETTODOS";
            cmd.CommandType = CommandType.StoredProcedure;
            //**********************
            cmd.Parameters.Add("day", Convert.ToDateTime(dateTimePicker1.Value.Year.ToString() + "-" + dateTimePicker1.Value.Month.ToString() + "-" + dateTimePicker1.Value.Day.ToString()));
            cmd.Parameters.Add("todos", OracleDbType.RefCursor, ParameterDirection.Output);

            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                todoCheckListBox.Items.Add(dr[0], Convert.ToInt32(dr[1]) == 0 ? false : true);
                todo_ids.Add(Convert.ToInt32(dr[2]));
            }

            dr.Close();

            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn;
            cmd2.CommandText = "GETNONTES";
            // add GETNOTES procedure same as get todos to oracle
            cmd2.CommandType = CommandType.StoredProcedure;
            //**********************
            cmd2.Parameters.Add("day", Convert.ToDateTime(dateTimePicker1.Value.Year.ToString() + "-" + dateTimePicker1.Value.Month.ToString() + "-" + dateTimePicker1.Value.Day.ToString()));
            cmd2.Parameters.Add("notes", OracleDbType.RefCursor, ParameterDirection.Output);

            OracleDataReader dr2 = cmd2.ExecuteReader();

            while (dr2.Read())
            {
                object[] row = { dr2[5], dr2[2], dr2[3], dr2[4], dr2[0] };
                notesdgv.Rows.Insert(0, row);
            }

            dr2.Close();
        }

        private void rate_report_Click(object sender, EventArgs e)
        {
            RateReport form = new RateReport();
            form.Show();
        }

        private void events_report_Click(object sender, EventArgs e)
        {
            EventsReport form = new EventsReport();
            form.Show();
        }
    }
}
