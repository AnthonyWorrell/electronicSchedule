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
            this.cmb_times = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_connected);
            this.groupBox1.Location = new System.Drawing.Point(12, 220);
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
            this.cmb_rooms.FormattingEnabled = true;
            this.cmb_rooms.Location = new System.Drawing.Point(6, 80);
            this.cmb_rooms.Name = "cmb_rooms";
            this.cmb_rooms.Size = new System.Drawing.Size(121, 21);
            this.cmb_rooms.TabIndex = 13;
            // 
            // cmb_servers
            // 
            this.cmb_servers.FormattingEnabled = true;
            this.cmb_servers.Location = new System.Drawing.Point(6, 33);
            this.cmb_servers.Name = "cmb_servers";
            this.cmb_servers.Size = new System.Drawing.Size(121, 21);
            this.cmb_servers.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmb_servers);
            this.groupBox2.Controls.Add(this.cmb_rooms);
            this.groupBox2.Location = new System.Drawing.Point(24, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(143, 153);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Server Info";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmb_times);
            this.groupBox3.Location = new System.Drawing.Point(216, 39);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(134, 105);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Available Times";
            // 
            // cmb_times
            // 
            this.cmb_times.FormattingEnabled = true;
            this.cmb_times.Location = new System.Drawing.Point(6, 48);
            this.cmb_times.Name = "cmb_times";
            this.cmb_times.Size = new System.Drawing.Size(121, 21);
            this.cmb_times.TabIndex = 17;
            // 
            // infoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 303);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "infoForm";
            this.Text = "infoForm";
            this.Load += new System.EventHandler(this.infoForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
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
    }
}