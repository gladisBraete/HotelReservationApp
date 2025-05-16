using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gladis_Holtelz
{

    public partial class FormAddRoom : Form
    {
        IDataAcces dataAcces;
        public FormAddRoom()
        {
            InitializeComponent();
            this.Load += FormAddRoom_Load;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            dataAcces = new DataAcces();
        }

        private void FormAddRoom_Load(object sender, EventArgs e)
        {
            this.cbRoomType.DataSource = MainForm.RoomTypes.Keys.ToArray();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string roomType = cbRoomType.SelectedValue.ToString();
            Room room = new Room(roomType);
            tbRoomPrice.Text = room.Price.ToString("N2");
        }

        private void btnSaveRoom_Click(object sender, EventArgs e)
        {
            bool valid = validate();
            string roomType = cbRoomType.Text.ToString();
            if (valid == true)
            {
                Room room = new Room(roomType, tbRoomNo.Text);
                this.dataAcces.SaveRoom(room);
                MessageBox.Show("The room has been saved successfully");
                this.Close();
            }
            else MessageBox.Show("Please review the red fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool validate()
        {
            bool ok = true;
            if (string.IsNullOrWhiteSpace(tbRoomNo.Text))
            {
                ok = false;
                labelRoomNumber.ForeColor = Color.Red;
            }
            else
            {
                labelRoomNumber.ForeColor = Color.Black;
            }
            if (cbRoomType.SelectedIndex == -1)
            {
                ok = false;
                labelRoomType.ForeColor = Color.Red;
                labelRoomPrice.ForeColor = Color.Red;
            }
            else
            {
                labelRoomType.ForeColor = Color.Black;
                labelRoomPrice.ForeColor = Color.Black;
            }
            return ok;
        }

       
    }
}
