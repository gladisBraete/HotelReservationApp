namespace Gladis_Holtelz
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.btnViewReservations = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbGetAllClients = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DTPCheckIn = new System.Windows.Forms.DateTimePicker();
            this.DTPCheckOut = new System.Windows.Forms.DateTimePicker();
            this.RTBDetails = new System.Windows.Forms.RichTextBox();
            this.btnSaveReservation = new System.Windows.Forms.Button();
            this.DGVRoomsAvailable = new System.Windows.Forms.DataGridView();
            this.Selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelRoomsAvailable = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.GraphicBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRoomsAvailable)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "GladisHotelz";
            // 
            // btnAddClient
            // 
            this.btnAddClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClient.Location = new System.Drawing.Point(376, 9);
            this.btnAddClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(168, 33);
            this.btnAddClient.TabIndex = 1;
            this.btnAddClient.Text = "Add Client";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoom.Location = new System.Drawing.Point(549, 9);
            this.btnAddRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(168, 33);
            this.btnAddRoom.TabIndex = 2;
            this.btnAddRoom.Text = "Add Room";
            this.btnAddRoom.UseVisualStyleBackColor = true;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // btnViewReservations
            // 
            this.btnViewReservations.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewReservations.Location = new System.Drawing.Point(723, 9);
            this.btnViewReservations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewReservations.Name = "btnViewReservations";
            this.btnViewReservations.Size = new System.Drawing.Size(168, 33);
            this.btnViewReservations.TabIndex = 3;
            this.btnViewReservations.Text = "View Reservations";
            this.btnViewReservations.UseVisualStyleBackColor = true;
            this.btnViewReservations.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Clients";
            // 
            // cbGetAllClients
            // 
            this.cbGetAllClients.FormattingEnabled = true;
            this.cbGetAllClients.Location = new System.Drawing.Point(128, 172);
            this.cbGetAllClients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbGetAllClients.Name = "cbGetAllClients";
            this.cbGetAllClients.Size = new System.Drawing.Size(200, 24);
            this.cbGetAllClients.TabIndex = 15;
            this.cbGetAllClients.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Check-In";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Check-Out";
            // 
            // DTPCheckIn
            // 
            this.DTPCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPCheckIn.Location = new System.Drawing.Point(128, 91);
            this.DTPCheckIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DTPCheckIn.MinDate = new System.DateTime(2024, 4, 16, 0, 0, 0, 0);
            this.DTPCheckIn.Name = "DTPCheckIn";
            this.DTPCheckIn.Size = new System.Drawing.Size(200, 22);
            this.DTPCheckIn.TabIndex = 8;
            this.DTPCheckIn.ValueChanged += new System.EventHandler(this.DTPCheckIn_ValueChanged);
            // 
            // DTPCheckOut
            // 
            this.DTPCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPCheckOut.Location = new System.Drawing.Point(128, 132);
            this.DTPCheckOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DTPCheckOut.Name = "DTPCheckOut";
            this.DTPCheckOut.Size = new System.Drawing.Size(200, 22);
            this.DTPCheckOut.TabIndex = 9;
            this.DTPCheckOut.ValueChanged += new System.EventHandler(this.DTPCheckOut_ValueChanged);
            // 
            // RTBDetails
            // 
            this.RTBDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTBDetails.Location = new System.Drawing.Point(21, 260);
            this.RTBDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RTBDetails.Name = "RTBDetails";
            this.RTBDetails.ReadOnly = true;
            this.RTBDetails.Size = new System.Drawing.Size(307, 292);
            this.RTBDetails.TabIndex = 10;
            this.RTBDetails.Text = "";
            // 
            // btnSaveReservation
            // 
            this.btnSaveReservation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveReservation.Location = new System.Drawing.Point(160, 545);
            this.btnSaveReservation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveReservation.Name = "btnSaveReservation";
            this.btnSaveReservation.Size = new System.Drawing.Size(168, 31);
            this.btnSaveReservation.TabIndex = 11;
            this.btnSaveReservation.Text = "Save Reservation";
            this.btnSaveReservation.UseVisualStyleBackColor = true;
            this.btnSaveReservation.Click += new System.EventHandler(this.btnSaveReservation_Click);
            // 
            // DGVRoomsAvailable
            // 
            this.DGVRoomsAvailable.AllowUserToResizeColumns = false;
            this.DGVRoomsAvailable.AllowUserToResizeRows = false;
            this.DGVRoomsAvailable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVRoomsAvailable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVRoomsAvailable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selected,
            this.Id,
            this.RoomNumber,
            this.RoomType,
            this.RoomPrice});
            this.DGVRoomsAvailable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVRoomsAvailable.Location = new System.Drawing.Point(0, 47);
            this.DGVRoomsAvailable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGVRoomsAvailable.Name = "DGVRoomsAvailable";
            this.DGVRoomsAvailable.RowHeadersWidth = 51;
            this.DGVRoomsAvailable.Size = new System.Drawing.Size(905, 543);
            this.DGVRoomsAvailable.TabIndex = 12;
            // 
            // Selected
            // 
            this.Selected.DataPropertyName = "Selected";
            this.Selected.HeaderText = "Selected";
            this.Selected.MinimumWidth = 6;
            this.Selected.Name = "Selected";
            this.Selected.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Selected.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // RoomNumber
            // 
            this.RoomNumber.DataPropertyName = "Number";
            this.RoomNumber.HeaderText = "RoomNumber";
            this.RoomNumber.MinimumWidth = 6;
            this.RoomNumber.Name = "RoomNumber";
            this.RoomNumber.ReadOnly = true;
            // 
            // RoomType
            // 
            this.RoomType.DataPropertyName = "RoomType";
            this.RoomType.HeaderText = "Room Type";
            this.RoomType.MinimumWidth = 6;
            this.RoomType.Name = "RoomType";
            this.RoomType.ReadOnly = true;
            // 
            // RoomPrice
            // 
            this.RoomPrice.DataPropertyName = "Price";
            this.RoomPrice.HeaderText = "Room Price";
            this.RoomPrice.MinimumWidth = 6;
            this.RoomPrice.Name = "RoomPrice";
            this.RoomPrice.ReadOnly = true;
            // 
            // labelRoomsAvailable
            // 
            this.labelRoomsAvailable.AutoSize = true;
            this.labelRoomsAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoomsAvailable.Location = new System.Drawing.Point(-3, 25);
            this.labelRoomsAvailable.Name = "labelRoomsAvailable";
            this.labelRoomsAvailable.Size = new System.Drawing.Size(130, 16);
            this.labelRoomsAvailable.TabIndex = 13;
            this.labelRoomsAvailable.Text = "Available Rooms ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Invoice Details";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DTPCheckIn);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnSaveReservation);
            this.panel1.Controls.Add(this.DTPCheckOut);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbGetAllClients);
            this.panel1.Controls.Add(this.RTBDetails);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 590);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DGVRoomsAvailable);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(356, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(905, 590);
            this.panel2.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.GraphicBTN);
            this.panel3.Controls.Add(this.btnViewReservations);
            this.panel3.Controls.Add(this.labelRoomsAvailable);
            this.panel3.Controls.Add(this.btnAddClient);
            this.panel3.Controls.Add(this.btnAddRoom);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(905, 47);
            this.panel3.TabIndex = 14;
            // 
            // GraphicBTN
            // 
            this.GraphicBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GraphicBTN.Location = new System.Drawing.Point(207, 9);
            this.GraphicBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GraphicBTN.Name = "GraphicBTN";
            this.GraphicBTN.Size = new System.Drawing.Size(163, 32);
            this.GraphicBTN.TabIndex = 14;
            this.GraphicBTN.Text = "Total Receipts";
            this.GraphicBTN.UseVisualStyleBackColor = true;
            this.GraphicBTN.Click += new System.EventHandler(this.GraphicBTN_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 590);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1279, 637);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gladis Hotelz";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVRoomsAvailable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.Button btnViewReservations;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbGetAllClients;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DTPCheckIn;
        private System.Windows.Forms.DateTimePicker DTPCheckOut;
        private System.Windows.Forms.RichTextBox RTBDetails;
        private System.Windows.Forms.Button btnSaveReservation;
        private System.Windows.Forms.DataGridView DGVRoomsAvailable;
        private System.Windows.Forms.Label labelRoomsAvailable;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selected;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button GraphicBTN;
    }
}

