namespace Gladis_Holtelz
{
    partial class FormViewReservations
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSearchClient = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.DGVDetails = new System.Windows.Forms.DataGridView();
            this.labelRoomType = new System.Windows.Forms.Label();
            this.CBRoomType = new System.Windows.Forms.ComboBox();
            this.labelCheckIn = new System.Windows.Forms.Label();
            this.DTPStartDate = new System.Windows.Forms.DateTimePicker();
            this.DTPEndDate = new System.Windows.Forms.DateTimePicker();
            this.labelCheckOut = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exportBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDetails)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client\'s email";
            // 
            // tbSearchClient
            // 
            this.tbSearchClient.Location = new System.Drawing.Point(131, 18);
            this.tbSearchClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSearchClient.Name = "tbSearchClient";
            this.tbSearchClient.Size = new System.Drawing.Size(173, 22);
            this.tbSearchClient.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(628, 18);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 57);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // DGVDetails
            // 
            this.DGVDetails.AllowUserToAddRows = false;
            this.DGVDetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVDetails.DefaultCellStyle = dataGridViewCellStyle5;
            this.DGVDetails.Location = new System.Drawing.Point(12, 87);
            this.DGVDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGVDetails.Name = "DGVDetails";
            this.DGVDetails.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DGVDetails.RowHeadersVisible = false;
            this.DGVDetails.RowHeadersWidth = 51;
            this.DGVDetails.RowTemplate.Height = 24;
            this.DGVDetails.Size = new System.Drawing.Size(1046, 408);
            this.DGVDetails.TabIndex = 3;
            // 
            // labelRoomType
            // 
            this.labelRoomType.AutoSize = true;
            this.labelRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoomType.Location = new System.Drawing.Point(12, 54);
            this.labelRoomType.Name = "labelRoomType";
            this.labelRoomType.Size = new System.Drawing.Size(84, 16);
            this.labelRoomType.TabIndex = 4;
            this.labelRoomType.Text = "RoomType";
            // 
            // CBRoomType
            // 
            this.CBRoomType.FormattingEnabled = true;
            this.CBRoomType.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Premium",
            "Deluxe"});
            this.CBRoomType.Location = new System.Drawing.Point(131, 51);
            this.CBRoomType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBRoomType.Name = "CBRoomType";
            this.CBRoomType.Size = new System.Drawing.Size(173, 24);
            this.CBRoomType.TabIndex = 5;
            // 
            // labelCheckIn
            // 
            this.labelCheckIn.AutoSize = true;
            this.labelCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCheckIn.Location = new System.Drawing.Point(310, 21);
            this.labelCheckIn.Name = "labelCheckIn";
            this.labelCheckIn.Size = new System.Drawing.Size(74, 16);
            this.labelCheckIn.TabIndex = 6;
            this.labelCheckIn.Text = "Start date";
            // 
            // DTPStartDate
            // 
            this.DTPStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPStartDate.Location = new System.Drawing.Point(393, 18);
            this.DTPStartDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DTPStartDate.MinDate = new System.DateTime(2024, 4, 1, 0, 0, 0, 0);
            this.DTPStartDate.Name = "DTPStartDate";
            this.DTPStartDate.Size = new System.Drawing.Size(214, 22);
            this.DTPStartDate.TabIndex = 7;
            this.DTPStartDate.Value = new System.DateTime(2024, 4, 17, 16, 28, 5, 0);
            // 
            // DTPEndDate
            // 
            this.DTPEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPEndDate.Location = new System.Drawing.Point(393, 49);
            this.DTPEndDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DTPEndDate.MinDate = new System.DateTime(2024, 4, 17, 0, 0, 0, 0);
            this.DTPEndDate.Name = "DTPEndDate";
            this.DTPEndDate.Size = new System.Drawing.Size(214, 22);
            this.DTPEndDate.TabIndex = 8;
            // 
            // labelCheckOut
            // 
            this.labelCheckOut.AutoSize = true;
            this.labelCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCheckOut.Location = new System.Drawing.Point(310, 54);
            this.labelCheckOut.Name = "labelCheckOut";
            this.labelCheckOut.Size = new System.Drawing.Size(71, 16);
            this.labelCheckOut.TabIndex = 9;
            this.labelCheckOut.Text = "End Date";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.Controls.Add(this.exportBTN);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.DGVDetails);
            this.panel1.Controls.Add(this.DTPEndDate);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.labelCheckOut);
            this.panel1.Controls.Add(this.tbSearchClient);
            this.panel1.Controls.Add(this.labelRoomType);
            this.panel1.Controls.Add(this.DTPStartDate);
            this.panel1.Controls.Add(this.CBRoomType);
            this.panel1.Controls.Add(this.labelCheckIn);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1076, 494);
            this.panel1.TabIndex = 10;
            // 
            // exportBTN
            // 
            this.exportBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportBTN.Location = new System.Drawing.Point(805, 18);
            this.exportBTN.Name = "exportBTN";
            this.exportBTN.Size = new System.Drawing.Size(145, 57);
            this.exportBTN.TabIndex = 10;
            this.exportBTN.Text = "Export";
            this.exportBTN.UseVisualStyleBackColor = true;
            this.exportBTN.Click += new System.EventHandler(this.exportBTN_Click);
            // 
            // FormViewReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 518);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1110, 565);
            this.Name = "FormViewReservations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormViewReservations";
            ((System.ComponentModel.ISupportInitialize)(this.DGVDetails)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSearchClient;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView DGVDetails;
        private System.Windows.Forms.Label labelRoomType;
        private System.Windows.Forms.ComboBox CBRoomType;
        private System.Windows.Forms.Label labelCheckIn;
        private System.Windows.Forms.DateTimePicker DTPStartDate;
        private System.Windows.Forms.DateTimePicker DTPEndDate;
        private System.Windows.Forms.Label labelCheckOut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exportBTN;
    }
}