namespace scheduleForm
{
    partial class scheduleMakerForm
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
            this.mtc_calender = new System.Windows.Forms.MonthCalendar();
            this.btn_enter = new System.Windows.Forms.Button();
            this.lbl_name = new System.Windows.Forms.Label();
            this.btn_editData = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_connected);
            this.groupBox1.Location = new System.Drawing.Point(12, 318);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 54);
            this.groupBox1.TabIndex = 11;
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
            // mtc_calender
            // 
            this.mtc_calender.BackColor = System.Drawing.SystemColors.Menu;
            this.mtc_calender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtc_calender.Location = new System.Drawing.Point(29, 53);
            this.mtc_calender.MaxSelectionCount = 1;
            this.mtc_calender.Name = "mtc_calender";
            this.mtc_calender.TabIndex = 34;
            // 
            // btn_enter
            // 
            this.btn_enter.Location = new System.Drawing.Point(104, 227);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(75, 23);
            this.btn_enter.TabIndex = 35;
            this.btn_enter.Text = "Enter";
            this.btn_enter.UseVisualStyleBackColor = true;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(26, 20);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(35, 13);
            this.lbl_name.TabIndex = 36;
            this.lbl_name.Text = "Name";
            // 
            // btn_editData
            // 
            this.btn_editData.Location = new System.Drawing.Point(104, 275);
            this.btn_editData.Name = "btn_editData";
            this.btn_editData.Size = new System.Drawing.Size(75, 23);
            this.btn_editData.TabIndex = 37;
            this.btn_editData.Text = "Edit Data";
            this.btn_editData.UseVisualStyleBackColor = true;
            this.btn_editData.Visible = false;
            this.btn_editData.Click += new System.EventHandler(this.btn_editData_Click);
            // 
            // scheduleMakerForm
            // 
            this.AcceptButton = this.btn_enter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 385);
            this.Controls.Add(this.btn_editData);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.mtc_calender);
            this.Controls.Add(this.groupBox1);
            this.Name = "scheduleMakerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Month Select";
            this.Load += new System.EventHandler(this.scheduleMakerForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_connected;
        private System.Windows.Forms.MonthCalendar mtc_calender;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Button btn_editData;
    }
}

