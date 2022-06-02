namespace ODP1_Connected_Start
{
    partial class Yawmiaty
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.updateNotebtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.noteTextbox = new System.Windows.Forms.TextBox();
            this.notesdgv = new System.Windows.Forms.DataGridView();
            this.NoteCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priorityCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.favCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveNote = new System.Windows.Forms.Button();
            this.notePriority = new System.Windows.Forms.Label();
            this.notePriorityComboBox = new System.Windows.Forms.ComboBox();
            this.noteRate = new System.Windows.Forms.Label();
            this.noteRateComboBox = new System.Windows.Forms.ComboBox();
            this.favCheck = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.save_btn = new System.Windows.Forms.Button();
            this.newTodo = new System.Windows.Forms.TextBox();
            this.addNewTodo = new System.Windows.Forms.Button();
            this.todoCheckListBox = new System.Windows.Forms.CheckedListBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.events_btn = new System.Windows.Forms.Button();
            this.events_report = new System.Windows.Forms.Button();
            this.rate_report = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notesdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10);
            this.label2.Size = new System.Drawing.Size(119, 45);
            this.label2.TabIndex = 3;
            this.label2.Text = "CheckList";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 58);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.updateNotebtn);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.noteTextbox);
            this.splitContainer1.Panel1.Controls.Add(this.notesdgv);
            this.splitContainer1.Panel1.Controls.Add(this.saveNote);
            this.splitContainer1.Panel1.Controls.Add(this.notePriority);
            this.splitContainer1.Panel1.Controls.Add(this.notePriorityComboBox);
            this.splitContainer1.Panel1.Controls.Add(this.noteRate);
            this.splitContainer1.Panel1.Controls.Add(this.noteRateComboBox);
            this.splitContainer1.Panel1.Controls.Add(this.favCheck);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.save_btn);
            this.splitContainer1.Panel2.Controls.Add(this.newTodo);
            this.splitContainer1.Panel2.Controls.Add(this.addNewTodo);
            this.splitContainer1.Panel2.Controls.Add(this.todoCheckListBox);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(1022, 380);
            this.splitContainer1.SplitterDistance = 499;
            this.splitContainer1.TabIndex = 4;
            // 
            // updateNotebtn
            // 
            this.updateNotebtn.Location = new System.Drawing.Point(209, 345);
            this.updateNotebtn.Name = "updateNotebtn";
            this.updateNotebtn.Size = new System.Drawing.Size(128, 26);
            this.updateNotebtn.TabIndex = 13;
            this.updateNotebtn.Text = "Update note";
            this.updateNotebtn.UseVisualStyleBackColor = true;
            this.updateNotebtn.Click += new System.EventHandler(this.updateNotebtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Note text";
            // 
            // noteTextbox
            // 
            this.noteTextbox.Location = new System.Drawing.Point(196, 292);
            this.noteTextbox.Multiline = true;
            this.noteTextbox.Name = "noteTextbox";
            this.noteTextbox.Size = new System.Drawing.Size(288, 38);
            this.noteTextbox.TabIndex = 7;
            // 
            // notesdgv
            // 
            this.notesdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.notesdgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NoteCol,
            this.priorityCol,
            this.rateCol,
            this.favCol,
            this.ID});
            this.notesdgv.Location = new System.Drawing.Point(7, 40);
            this.notesdgv.Name = "notesdgv";
            this.notesdgv.ReadOnly = true;
            this.notesdgv.RowHeadersWidth = 51;
            this.notesdgv.RowTemplate.Height = 24;
            this.notesdgv.Size = new System.Drawing.Size(490, 176);
            this.notesdgv.TabIndex = 11;
            this.notesdgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.notesdgv_CellClick);
            // 
            // NoteCol
            // 
            this.NoteCol.HeaderText = "Note";
            this.NoteCol.MinimumWidth = 6;
            this.NoteCol.Name = "NoteCol";
            this.NoteCol.ReadOnly = true;
            this.NoteCol.Width = 125;
            // 
            // priorityCol
            // 
            this.priorityCol.HeaderText = "Priority";
            this.priorityCol.MinimumWidth = 6;
            this.priorityCol.Name = "priorityCol";
            this.priorityCol.ReadOnly = true;
            this.priorityCol.Width = 125;
            // 
            // rateCol
            // 
            this.rateCol.HeaderText = "Rate";
            this.rateCol.MinimumWidth = 6;
            this.rateCol.Name = "rateCol";
            this.rateCol.ReadOnly = true;
            this.rateCol.Width = 125;
            // 
            // favCol
            // 
            this.favCol.HeaderText = "Favourite";
            this.favCol.MinimumWidth = 6;
            this.favCol.Name = "favCol";
            this.favCol.ReadOnly = true;
            this.favCol.Width = 125;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 125;
            // 
            // saveNote
            // 
            this.saveNote.Location = new System.Drawing.Point(356, 345);
            this.saveNote.Name = "saveNote";
            this.saveNote.Size = new System.Drawing.Size(128, 26);
            this.saveNote.TabIndex = 7;
            this.saveNote.Text = "Save note";
            this.saveNote.UseVisualStyleBackColor = true;
            this.saveNote.Click += new System.EventHandler(this.saveNote_Click);
            // 
            // notePriority
            // 
            this.notePriority.AutoSize = true;
            this.notePriority.Location = new System.Drawing.Point(15, 240);
            this.notePriority.Name = "notePriority";
            this.notePriority.Size = new System.Drawing.Size(76, 17);
            this.notePriority.TabIndex = 10;
            this.notePriority.Text = "Set priority";
            // 
            // notePriorityComboBox
            // 
            this.notePriorityComboBox.FormattingEnabled = true;
            this.notePriorityComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.notePriorityComboBox.Location = new System.Drawing.Point(12, 260);
            this.notePriorityComboBox.Name = "notePriorityComboBox";
            this.notePriorityComboBox.Size = new System.Drawing.Size(153, 24);
            this.notePriorityComboBox.TabIndex = 9;
            // 
            // noteRate
            // 
            this.noteRate.AutoSize = true;
            this.noteRate.Location = new System.Drawing.Point(13, 287);
            this.noteRate.Name = "noteRate";
            this.noteRate.Size = new System.Drawing.Size(94, 17);
            this.noteRate.TabIndex = 8;
            this.noteRate.Text = "Rate the note";
            // 
            // noteRateComboBox
            // 
            this.noteRateComboBox.FormattingEnabled = true;
            this.noteRateComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.noteRateComboBox.Location = new System.Drawing.Point(12, 306);
            this.noteRateComboBox.Name = "noteRateComboBox";
            this.noteRateComboBox.Size = new System.Drawing.Size(144, 24);
            this.noteRateComboBox.TabIndex = 7;
            // 
            // favCheck
            // 
            this.favCheck.AutoSize = true;
            this.favCheck.Location = new System.Drawing.Point(16, 345);
            this.favCheck.Name = "favCheck";
            this.favCheck.Size = new System.Drawing.Size(89, 21);
            this.favCheck.TabIndex = 6;
            this.favCheck.Text = "Favourite";
            this.favCheck.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(10);
            this.label3.Size = new System.Drawing.Size(83, 45);
            this.label3.TabIndex = 4;
            this.label3.Text = "Notes";
            // 
            // save_btn
            // 
            this.save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.save_btn.Location = new System.Drawing.Point(425, 336);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(91, 41);
            this.save_btn.TabIndex = 9;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // newTodo
            // 
            this.newTodo.Location = new System.Drawing.Point(3, 339);
            this.newTodo.Multiline = true;
            this.newTodo.Name = "newTodo";
            this.newTodo.Size = new System.Drawing.Size(258, 38);
            this.newTodo.TabIndex = 6;
            // 
            // addNewTodo
            // 
            this.addNewTodo.Location = new System.Drawing.Point(267, 339);
            this.addNewTodo.Name = "addNewTodo";
            this.addNewTodo.Size = new System.Drawing.Size(49, 38);
            this.addNewTodo.TabIndex = 5;
            this.addNewTodo.Text = "Add";
            this.addNewTodo.UseVisualStyleBackColor = true;
            this.addNewTodo.Click += new System.EventHandler(this.addNewTodo_Click);
            // 
            // todoCheckListBox
            // 
            this.todoCheckListBox.FormattingEnabled = true;
            this.todoCheckListBox.Location = new System.Drawing.Point(0, 40);
            this.todoCheckListBox.Name = "todoCheckListBox";
            this.todoCheckListBox.Size = new System.Drawing.Size(516, 276);
            this.todoCheckListBox.TabIndex = 4;
            this.todoCheckListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.todoCheckListBox_ItemCheck);
            this.todoCheckListBox.SelectedIndexChanged += new System.EventHandler(this.todoCheckListBox_SelectedIndexChanged);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.timeLabel.Location = new System.Drawing.Point(12, 9);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(64, 25);
            this.timeLabel.TabIndex = 5;
            this.timeLabel.Text = "label1";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateLabel.Location = new System.Drawing.Point(324, 9);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(64, 25);
            this.dateLabel.TabIndex = 6;
            this.dateLabel.Text = "label1";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(9, 468);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(309, 22);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // events_btn
            // 
            this.events_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.events_btn.Location = new System.Drawing.Point(844, 459);
            this.events_btn.Name = "events_btn";
            this.events_btn.Size = new System.Drawing.Size(156, 43);
            this.events_btn.TabIndex = 8;
            this.events_btn.Text = "Show Events";
            this.events_btn.UseVisualStyleBackColor = true;
            this.events_btn.Click += new System.EventHandler(this.events_btn_Click);
            // 
            // events_report
            // 
            this.events_report.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.events_report.Location = new System.Drawing.Point(504, 459);
            this.events_report.Name = "events_report";
            this.events_report.Size = new System.Drawing.Size(156, 43);
            this.events_report.TabIndex = 9;
            this.events_report.Text = "Events Report";
            this.events_report.UseVisualStyleBackColor = true;
            this.events_report.Click += new System.EventHandler(this.events_report_Click);
            // 
            // rate_report
            // 
            this.rate_report.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.rate_report.Location = new System.Drawing.Point(675, 459);
            this.rate_report.Name = "rate_report";
            this.rate_report.Size = new System.Drawing.Size(156, 43);
            this.rate_report.TabIndex = 10;
            this.rate_report.Text = "Rate Report";
            this.rate_report.UseVisualStyleBackColor = true;
            this.rate_report.Click += new System.EventHandler(this.rate_report_Click);
            // 
            // ActorsForm
            // 
            this.ClientSize = new System.Drawing.Size(1046, 539);
            this.Controls.Add(this.rate_report);
            this.Controls.Add(this.events_report);
            this.Controls.Add(this.events_btn);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(670, 460);
            this.Name = "ActorsForm";
            this.Text = "Yawmiaty";
            this.Load += new System.EventHandler(this.ActorsForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.notesdgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox todoCheckListBox;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TextBox newTodo;
        private System.Windows.Forms.Button addNewTodo;
        private System.Windows.Forms.Button saveNote;
        private System.Windows.Forms.Label notePriority;
        private System.Windows.Forms.ComboBox notePriorityComboBox;
        private System.Windows.Forms.Label noteRate;
        private System.Windows.Forms.ComboBox noteRateComboBox;
        private System.Windows.Forms.CheckBox favCheck;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox noteTextbox;
        private System.Windows.Forms.Button updateNotebtn;
        private System.Windows.Forms.DataGridView notesdgv;
        private System.Windows.Forms.Button events_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoteCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn priorityCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn rateCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn favCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button events_report;
        private System.Windows.Forms.Button rate_report;
    }
}

