namespace scheduleForm
{
    partial class infoForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_connected = new System.Windows.Forms.Label();
            this.cmb_rooms = new System.Windows.Forms.ComboBox();
            this.cmb_servers = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_resetTimes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_schedule = new System.Windows.Forms.Button();
            this.cmb_times = new System.Windows.Forms.ComboBox();
            this.btn_check = new System.Windows.Forms.Button();
            this.rad_rooms = new System.Windows.Forms.RadioButton();
            this.rad_servers = new System.Windows.Forms.RadioButton();
            this.rad_both = new System.Windows.Forms.RadioButton();
            this.btn_delete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_connected);
            this.groupBox1.Location = new System.Drawing.Point(4, 274);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 54);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection Status";
            // 
            // lbl_connected
            // 
            this.lbl_connected.AutoSize = true;
            this.lbl_connected.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_connected.Location = new System.Drawing.Point(8, 22);
            this.lbl_connected.Name = "lbl_connected";
            this.lbl_connected.Size = new System.Drawing.Size(129, 20);
            this.lbl_connected.TabIndex = 0;
            this.lbl_connected.Text = "Not Connected";
            // 
            // cmb_rooms
            // 
            this.cmb_rooms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_rooms.FormattingEnabled = true;
            this.cmb_rooms.Location = new System.Drawing.Point(19, 71);
            this.cmb_rooms.Name = "cmb_rooms";
            this.cmb_rooms.Size = new System.Drawing.Size(121, 21);
            this.cmb_rooms.TabIndex = 13;
            this.cmb_rooms.SelectedIndexChanged += new System.EventHandler(this.cmb_rooms_SelectedIndexChanged);
            // 
            // cmb_servers
            // 
            this.cmb_servers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_servers.FormattingEnabled = true;
            this.cmb_servers.Location = new System.Drawing.Point(19, 33);
            this.cmb_servers.Name = "cmb_servers";
            this.cmb_servers.Size = new System.Drawing.Size(121, 21);
            this.cmb_servers.TabIndex = 14;
            this.cmb_servers.SelectedIndexChanged += new System.EventHandler(this.cmb_servers_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rad_both);
            this.groupBox2.Controls.Add(this.rad_servers);
            this.groupBox2.Controls.Add(this.rad_rooms);
            this.groupBox2.Controls.Add(this.btn_check);
            this.groupBox2.Controls.Add(this.cmb_servers);
            this.groupBox2.Controls.Add(this.cmb_rooms);
            this.groupBox2.Location = new System.Drawing.Point(4, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(163, 214);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Server Info";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_resetTimes);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btn_schedule);
            this.groupBox3.Controls.Add(this.cmb_times);
            this.groupBox3.Location = new System.Drawing.Point(173, 45);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(274, 130);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Current Appointments";
            // 
            // btn_resetTimes
            // 
            this.btn_resetTimes.Location = new System.Drawing.Point(155, 81);
            this.btn_resetTimes.Name = "btn_resetTimes";
            this.btn_resetTimes.Size = new System.Drawing.Size(75, 23);
            this.btn_resetTimes.TabIndex = 17;
            this.btn_resetTimes.Text = "Clear";
            this.btn_resetTimes.UseVisualStyleBackColor = true;
            this.btn_resetTimes.Click += new System.EventHandler(this.btn_resetTimes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Click To View Appointments";
            // 
            // btn_schedule
            // 
            this.btn_schedule.Location = new System.Drawing.Point(57, 81);
            this.btn_schedule.Name = "btn_schedule";
            this.btn_schedule.Size = new System.Drawing.Size(75, 23);
            this.btn_schedule.TabIndex = 17;
            this.btn_schedule.Text = "Schedule ";
            this.btn_schedule.UseVisualStyleBackColor = true;
            this.btn_schedule.Click += new System.EventHandler(this.btn_schedule_Click);
            // 
            // cmb_times
            // 
            this.cmb_times.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_times.FormatString = "t";
            this.cmb_times.FormattingEnabled = true;
            this.cmb_times.Location = new System.Drawing.Point(6, 48);
            this.cmb_times.Name = "cmb_times";
            this.cmb_times.Size = new System.Drawing.Size(262, 21);
            this.cmb_times.TabIndex = 17;
            // 
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(39, 175);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(75, 23);
            this.btn_check.TabIndex = 15;
            this.btn_check.Text = "Check";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // rad_rooms
            // 
            this.rad_rooms.AutoSize = true;
            this.rad_rooms.Location = new System.Drawing.Point(19, 122);
            this.rad_rooms.Name = "rad_rooms";
            this.rad_rooms.Size = new System.Drawing.Size(58, 17);
            this.rad_rooms.TabIndex = 16;
            this.rad_rooms.TabStop = true;
            this.rad_rooms.Text = "Rooms";
            this.rad_rooms.UseVisualStyleBackColor = true;
            // 
            // rad_servers
            // 
            this.rad_servers.AutoSize = true;
            this.rad_servers.Location = new System.Drawing.Point(19, 98);
            this.rad_servers.Name = "rad_servers";
            this.rad_servers.Size = new System.Drawing.Size(61, 17);
            this.rad_servers.TabIndex = 17;
            this.rad_servers.TabStop = true;
            this.rad_servers.Text = "Servers";
            this.rad_servers.UseVisualStyleBackColor = true;
            // 
            // rad_both
            // 
            this.rad_both.AutoSize = true;
            this.rad_both.Location = new System.Drawing.Point(19, 145);
            this.rad_both.Name = "rad_both";
            this.rad_both.Size = new System.Drawing.Size(47, 17);
            this.rad_both.TabIndex = 18;
            this.rad_both.TabStop = true;
            this.rad_both.Text = "Both";
            this.rad_both.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(276, 209);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 17;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // infoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 345);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "infoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "infoForm";
            this.Load += new System.EventHandler(this.infoForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_connected;
        private System.Windows.Forms.ComboBox cmb_rooms;
        private System.Windows.Forms.ComboBox cmb_servers;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmb_times;
        private System.Windows.Forms.Button btn_schedule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_resetTimes;
        private System.Windows.Forms.RadioButton rad_both;
        private System.Windows.Forms.RadioButton rad_servers;
        private System.Windows.Forms.RadioButton rad_rooms;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.Button btn_delete;
    }
}