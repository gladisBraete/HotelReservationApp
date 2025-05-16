namespace Gladis_Holtelz
{
    partial class FormAddRoom
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
            this.cbRoomType = new System.Windows.Forms.ComboBox();
            this.labelRoomType = new System.Windows.Forms.Label();
            this.labelRoomPrice = new System.Windows.Forms.Label();
            this.tbRoomPrice = new System.Windows.Forms.TextBox();
            this.tbRoomNo = new System.Windows.Forms.TextBox();
            this.labelRoomNumber = new System.Windows.Forms.Label();
            this.btnSaveRoom = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbRoomType
            // 
            this.cbRoomType.FormattingEnabled = true;
            this.cbRoomType.Location = new System.Drawing.Point(169, 50);
            this.cbRoomType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbRoomType.Name = "cbRoomType";
            this.cbRoomType.Size = new System.Drawing.Size(177, 24);
            this.cbRoomType.TabIndex = 0;
            this.cbRoomType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelRoomType
            // 
            this.labelRoomType.AutoSize = true;
            this.labelRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoomType.Location = new System.Drawing.Point(56, 58);
            this.labelRoomType.Name = "labelRoomType";
            this.labelRoomType.Size = new System.Drawing.Size(88, 16);
            this.labelRoomType.TabIndex = 1;
            this.labelRoomType.Text = "Room Type";
            // 
            // labelRoomPrice
            // 
            this.labelRoomPrice.AutoSize = true;
            this.labelRoomPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoomPrice.Location = new System.Drawing.Point(56, 95);
            this.labelRoomPrice.Name = "labelRoomPrice";
            this.labelRoomPrice.Size = new System.Drawing.Size(88, 16);
            this.labelRoomPrice.TabIndex = 2;
            this.labelRoomPrice.Text = "Room Price";
            // 
            // tbRoomPrice
            // 
            this.tbRoomPrice.Location = new System.Drawing.Point(169, 89);
            this.tbRoomPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbRoomPrice.Name = "tbRoomPrice";
            this.tbRoomPrice.Size = new System.Drawing.Size(177, 22);
            this.tbRoomPrice.TabIndex = 3;
            // 
            // tbRoomNo
            // 
            this.tbRoomNo.Location = new System.Drawing.Point(169, 128);
            this.tbRoomNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbRoomNo.Name = "tbRoomNo";
            this.tbRoomNo.Size = new System.Drawing.Size(177, 22);
            this.tbRoomNo.TabIndex = 4;
            // 
            // labelRoomNumber
            // 
            this.labelRoomNumber.AutoSize = true;
            this.labelRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoomNumber.Location = new System.Drawing.Point(56, 131);
            this.labelRoomNumber.Name = "labelRoomNumber";
            this.labelRoomNumber.Size = new System.Drawing.Size(106, 16);
            this.labelRoomNumber.TabIndex = 5;
            this.labelRoomNumber.Text = "Room Number";
            // 
            // btnSaveRoom
            // 
            this.btnSaveRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveRoom.Location = new System.Drawing.Point(239, 168);
            this.btnSaveRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveRoom.MinimumSize = new System.Drawing.Size(107, 34);
            this.btnSaveRoom.Name = "btnSaveRoom";
            this.btnSaveRoom.Size = new System.Drawing.Size(107, 37);
            this.btnSaveRoom.TabIndex = 6;
            this.btnSaveRoom.Text = "Save Room";
            this.btnSaveRoom.UseVisualStyleBackColor = true;
            this.btnSaveRoom.Click += new System.EventHandler(this.btnSaveRoom_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelRoomType);
            this.panel1.Controls.Add(this.btnSaveRoom);
            this.panel1.Controls.Add(this.cbRoomType);
            this.panel1.Controls.Add(this.tbRoomNo);
            this.panel1.Controls.Add(this.labelRoomNumber);
            this.panel1.Controls.Add(this.labelRoomPrice);
            this.panel1.Controls.Add(this.tbRoomPrice);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 253);
            this.panel1.TabIndex = 7;
            // 
            // FormAddRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 253);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormAddRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Room";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbRoomType;
        private System.Windows.Forms.Label labelRoomType;
        private System.Windows.Forms.Label labelRoomPrice;
        private System.Windows.Forms.TextBox tbRoomPrice;
        private System.Windows.Forms.TextBox tbRoomNo;
        private System.Windows.Forms.Label labelRoomNumber;
        private System.Windows.Forms.Button btnSaveRoom;
        private System.Windows.Forms.Panel panel1;
    }
}