using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using System.IO;
using System.Windows.Forms.VisualStyles;

namespace Gladis_Holtelz
{
    public partial class MainForm : Form
    {
        public static Dictionary<string, decimal> RoomTypes;  
        IDataAcces dataAcces;
        public MainForm()
        {
            InitializeComponent();
            this.Load += MainForm_Load;
            this.dataAcces = new DataAcces();

            this.DGVRoomsAvailable.AutoGenerateColumns = false;
            this.DGVRoomsAvailable.AllowUserToAddRows = false;
            this.DGVRoomsAvailable.RowHeadersVisible = false;

            this.LoadAvailableRooms();

            this.DGVRoomsAvailable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVRoomsAvailable.AutoResizeColumns();

            this.DGVRoomsAvailable.CellValueChanged += DGVRoomsAvailable_CellValueChanged;
            this.DGVRoomsAvailable.CurrentCellDirtyStateChanged += DGVRoomsAvailable_CurrentCellDirtyStateChanged;
            this.DGVRoomsAvailable.CellFormatting += DGVRoomsAvailable_CellFormatting;
        }

        private void DGVRoomsAvailable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == this.RoomPrice.DisplayIndex)
            {
                if (e.Value != null && decimal.TryParse(e.Value.ToString(), out var value))
                {
                    e.Value = value.ToString("N2");
                }
            }
        }

        private void DGVRoomsAvailable_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (this.DGVRoomsAvailable.IsCurrentCellDirty)
            {
                this.DGVRoomsAvailable.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.DGVRoomsAvailable.Focus();
            RoomTypes = this.dataAcces.GetRoomTypes();
        }

        private void DGVRoomsAvailable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.Selected.DisplayIndex)
            {
                this.LoadInvoiceInformation();
            }
        }

        public string CreateDirectoryToSaveInvoices(string fileName, string fileContent)
        {
            string root = Directory.GetCurrentDirectory();
            string invoicesDirectory = Path.Combine(root, "Invoices");
            if (!Directory.Exists(invoicesDirectory))
            {
                Directory.CreateDirectory(invoicesDirectory);
            }
            string filePath = Path.Combine(invoicesDirectory, fileName);
            File.WriteAllText(filePath, fileContent);

            return filePath;
        }

        private void LoadClients()
        {
            this.dataAcces = new DataAcces();
            Client[] clients = this.dataAcces.GetAllClients();
            for (int i = 0; i < clients.Length; i++)
            {
                this.cbGetAllClients.Items.Add(clients[i].Email);
            }
        }

        private void LoadInvoiceInformation()
        {
            this.RTBDetails.Clear();
            StringBuilder stringBuilder = new StringBuilder();

            var dt = (this.DGVRoomsAvailable.DataSource as DataTable);
            var rooms = dt.AsEnumerable().Where(r => r.Field<bool>("Selected") == true);
            List<Room> list = new List<Room>();
            List<ReservationDetails> reservationDetails = new List<ReservationDetails>();
            foreach (var room in rooms)
            {
                var nRoom = new Room();
                nRoom.Id = (int)room["Id"];
                nRoom.RoomType =  room["RoomType"].ToString();
                nRoom.Price = (decimal)room["Price"];
                nRoom.Number = room["Number"].ToString();
                list.Add(nRoom);
                ReservationDetails rd = new ReservationDetails() { CurrentRoom = nRoom };
                reservationDetails.Add(rd);
            }

            string email = this.cbGetAllClients.Text;

            Client client = this.dataAcces.GetClient(email);
            if (client != null)
            {

                stringBuilder.Append("The client ");
                stringBuilder.Append(client.ToString());
                stringBuilder.Append(" have ");


                Reservation reservation = new Reservation() { ClientID = client.Id, CheckIn = DTPCheckIn.Value, CheckOut = DTPCheckOut.Value, Details = reservationDetails.ToArray() };
                stringBuilder.Append(reservation.ToString());
            }

            this.RTBDetails.AppendText(stringBuilder.ToString());
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            FormAddClient form = new FormAddClient();
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                this.LoadClients();
            }
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            FormAddRoom form = new FormAddRoom();
            form.ShowDialog(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormViewReservations form = new FormViewReservations();
            form.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LoadInvoiceInformation();
        }

        private void DTPCheckIn_ValueChanged(object sender, EventArgs e)
        {
            this.LoadAvailableRooms();
            this.LoadInvoiceInformation();
        }

        private void DTPCheckOut_ValueChanged(object sender, EventArgs e)
        {
            this.LoadAvailableRooms();
            this.LoadInvoiceInformation();
        }

        private void LoadAvailableRooms()
        {
            var dt = this.dataAcces.RoomsAvailable(this.DTPCheckIn.Value.Date, this.DTPCheckOut.Value.Date);

            this.DGVRoomsAvailable.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadClients();
        }

        private void btnSaveReservation_Click(object sender, EventArgs e)
        {
            var rez = DateTime.Compare(this.DTPCheckIn.Value, this.DTPCheckOut.Value);
            if (rez > 0)
            {
                MessageBox.Show("The date selected is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var dt = (this.DGVRoomsAvailable.DataSource as DataTable);
                var rooms = dt.AsEnumerable().Where(r => r.Field<bool>("Selected") == true);
                List<Room> list = new List<Room>();
                List<ReservationDetails> reservationDetails = new List<ReservationDetails>();
                foreach (var room in rooms)
                {
                    var nRoom = new Room();
                    nRoom.Id = (int)room["Id"];
                    nRoom.RoomType = room["RoomType"].ToString();
                    nRoom.Price = (decimal)room["Price"];
                    nRoom.Number = room["Number"].ToString();
                    list.Add(nRoom);
                    ReservationDetails rd = new ReservationDetails() { CurrentRoom = nRoom };
                    reservationDetails.Add(rd);
                }
                if ((this.cbGetAllClients.SelectedIndex != -1) && (reservationDetails.Count >= 1))
                {
                    string email = this.cbGetAllClients.Text;
                    Client client = this.dataAcces.GetClient(email);
                    Reservation reservation = new Reservation() { ClientID = client.Id, CheckIn = this.DTPCheckIn.Value, CheckOut = this.DTPCheckOut.Value, Details = reservationDetails.ToArray() };
                    Reservation Rez = this.dataAcces.SaveReservation(reservation);


                    string fileName = $"Invoice{Rez.Id}.txt";
                    string fileContent = this.RTBDetails.Text;
                    string filePath = this.CreateDirectoryToSaveInvoices(fileName, fileContent);
                    this.RTBDetails.Clear();
                    DialogResult result = MessageBox.Show("The reservation has been saved successfully. Do you want to see invoice's details ?");
                    if (result == DialogResult.OK)
                    {
                        try
                        {
                            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                            { FileName = filePath, UseShellExecute = true, Verb = "open" });
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                else MessageBox.Show("The reservation is incomplete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GraphicBTN_Click(object sender, EventArgs e)
        {
            GraphicForm graphicForm = new GraphicForm();
            graphicForm.Show();
        }
    }
}
