
namespace ODP1_Connected_Start
{
    partial class EventsForm
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
            this.date_picker = new System.Windows.Forms.DateTimePicker();
            this.show_events_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.update_btn = new System.Windows.Forms.Button();
            this.event_name = new System.Windows.Forms.TextBox();
            this.insert_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // date_picker
            // 
            this.date_picker.Location = new System.Drawing.Point(289, 43);
            this.date_picker.Name = "date_picker";
            this.date_picker.Size = new System.Drawing.Size(236, 22);
            this.date_picker.TabIndex = 0;
            this.date_picker.ValueChanged += new System.EventHandler(this.date_picker_ValueChanged);
            // 
            // show_events_btn
            // 
            this.show_events_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.show_events_btn.Location = new System.Drawing.Point(305, 95);
            this.show_events_btn.Name = "show_events_btn";
            this.show_events_btn.Size = new System.Drawing.Size(200, 41);
            this.show_events_btn.TabIndex = 1;
            this.show_events_btn.Text = "Show Events";
            this.show_events_btn.UseVisualStyleBackColor = true;
            this.show_events_btn.Click += new System.EventHandler(this.show_events_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(132, 230);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(566, 239);
            this.dataGridView1.TabIndex = 2;
            // 
            // update_btn
            // 
            this.update_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.update_btn.Location = new System.Drawing.Point(588, 496);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(184, 46);
            this.update_btn.TabIndex = 3;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // event_name
            // 
            this.event_name.Location = new System.Drawing.Point(132, 168);
            this.event_name.Name = "event_name";
            this.event_name.Size = new System.Drawing.Size(320, 22);
            this.event_name.TabIndex = 4;
            // 
            // insert_btn
            // 
            this.insert_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.insert_btn.Location = new System.Drawing.Point(557, 156);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(141, 41);
            this.insert_btn.TabIndex = 5;
            this.insert_btn.Text = "Insert";
            this.insert_btn.UseVisualStyleBackColor = true;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
            // 
            // EventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 579);
            this.Controls.Add(this.insert_btn);
            this.Controls.Add(this.event_name);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.show_events_btn);
            this.Controls.Add(this.date_picker);
            this.Name = "EventsForm";
            this.Text = "EventsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker date_picker;
        private System.Windows.Forms.Button show_events_btn;
        private System.Windows.Forms.TextBox event_name;
        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button update_btn;
    }
}