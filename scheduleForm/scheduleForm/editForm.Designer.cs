namespace scheduleForm
{
    partial class editForm
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmb_Rooms = new System.Windows.Forms.ComboBox();
            this.btn_deleteRoom = new System.Windows.Forms.Button();
            this.btn_addRoom = new System.Windows.Forms.Button();
            this.txt_room = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmb_servers = new System.Windows.Forms.ComboBox();
            this.btn_deleteServer = new System.Windows.Forms.Button();
            this.btn_addServer = new System.Windows.Forms.Button();
            this.txt_server = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_connected);
            this.groupBox1.Location = new System.Drawing.Point(3, 513);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 50);
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
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(10, 9);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(35, 13);
            this.lbl_name.TabIndex = 37;
            this.lbl_name.Text = "Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmb_Rooms);
            this.groupBox3.Controls.Add(this.btn_deleteRoom);
            this.groupBox3.Controls.Add(this.btn_addRoom);
            this.groupBox3.Controls.Add(this.txt_room);
            this.groupBox3.Location = new System.Drawing.Point(15, 40);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(362, 187);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Edit Rooms";
            // 
            // cmb_Rooms
            // 
            this.cmb_Rooms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Rooms.FormattingEnabled = true;
            this.cmb_Rooms.Location = new System.Drawing.Point(215, 53);
            this.cmb_Rooms.Name = "cmb_Rooms";
            this.cmb_Rooms.Size = new System.Drawing.Size(121, 21);
            this.cmb_Rooms.TabIndex = 3;
            // 
            // btn_deleteRoom
            // 
            this.btn_deleteRoom.Location = new System.Drawing.Point(231, 104);
            this.btn_deleteRoom.Name = "btn_deleteRoom";
            this.btn_deleteRoom.Size = new System.Drawing.Size(87, 23);
            this.btn_deleteRoom.TabIndex = 2;
            this.btn_deleteRoom.Text = "Delete Room";
            this.btn_deleteRoom.UseVisualStyleBackColor = true;
            this.btn_deleteRoom.Click += new System.EventHandler(this.btn_deleteRoom_Click);
            // 
            // btn_addRoom
            // 
            this.btn_addRoom.Location = new System.Drawing.Point(37, 104);
            this.btn_addRoom.Name = "btn_addRoom";
            this.btn_addRoom.Size = new System.Drawing.Size(75, 23);
            this.btn_addRoom.TabIndex = 1;
            this.btn_addRoom.Text = "Add Room";
            this.btn_addRoom.UseVisualStyleBackColor = true;
            this.btn_addRoom.Click += new System.EventHandler(this.btn_addRoom_Click);
            // 
            // txt_room
            // 
            this.txt_room.Location = new System.Drawing.Point(25, 53);
            this.txt_room.Name = "txt_room";
            this.txt_room.Size = new System.Drawing.Size(100, 20);
            this.txt_room.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmb_servers);
            this.groupBox4.Controls.Add(this.btn_deleteServer);
            this.groupBox4.Controls.Add(this.btn_addServer);
            this.groupBox4.Controls.Add(this.txt_server);
            this.groupBox4.Location = new System.Drawing.Point(15, 270);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(362, 187);
            this.groupBox4.TabIndex = 39;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Edit Servers";
            // 
            // cmb_servers
            // 
            this.cmb_servers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_servers.FormattingEnabled = true;
            this.cmb_servers.Location = new System.Drawing.Point(215, 66);
            this.cmb_servers.Name = "cmb_servers";
            this.cmb_servers.Size = new System.Drawing.Size(121, 21);
            this.cmb_servers.TabIndex = 4;
            // 
            // btn_deleteServer
            // 
            this.btn_deleteServer.Location = new System.Drawing.Point(231, 119);
            this.btn_deleteServer.Name = "btn_deleteServer";
            this.btn_deleteServer.Size = new System.Drawing.Size(87, 23);
            this.btn_deleteServer.TabIndex = 3;
            this.btn_deleteServer.Text = "Delete Server";
            this.btn_deleteServer.UseVisualStyleBackColor = true;
            this.btn_deleteServer.Click += new System.EventHandler(this.btn_deleteServer_Click);
            // 
            // btn_addServer
            // 
            this.btn_addServer.Location = new System.Drawing.Point(37, 119);
            this.btn_addServer.Name = "btn_addServer";
            this.btn_addServer.Size = new System.Drawing.Size(75, 23);
            this.btn_addServer.TabIndex = 2;
            this.btn_addServer.Text = "Add Server";
            this.btn_addServer.UseVisualStyleBackColor = true;
            this.btn_addServer.Click += new System.EventHandler(this.btn_addServer_Click);
            // 
            // txt_server
            // 
            this.txt_server.Location = new System.Drawing.Point(25, 66);
            this.txt_server.Name = "txt_server";
            this.txt_server.Size = new System.Drawing.Size(100, 20);
            this.txt_server.TabIndex = 1;
            // 
            // editForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 571);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.groupBox1);
            this.Name = "editForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "editForm";
            this.Load += new System.EventHandler(this.editForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_connected;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_addRoom;
        private System.Windows.Forms.TextBox txt_room;
        private System.Windows.Forms.Button btn_addServer;
        private System.Windows.Forms.TextBox txt_server;
        private System.Windows.Forms.ComboBox cmb_Rooms;
        private System.Windows.Forms.Button btn_deleteRoom;
        private System.Windows.Forms.ComboBox cmb_servers;
        private System.Windows.Forms.Button btn_deleteServer;
    }
}