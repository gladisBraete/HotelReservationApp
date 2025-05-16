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
    public partial class FormAddClient : Form
    {
        IDataAcces dataAcces;
        public FormAddClient()
        {
            InitializeComponent();
            this.dataAcces = new DataAcces();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnSaveClient_Click(object sender, EventArgs e)
        {
            bool valid = validateInput();
            if (valid)
            {
                Client client = new Client(tbFirstName.Text, tbLastName.Text, tbEmail.Text);
                this.dataAcces.AddClient(client);
                MessageBox.Show("The client has been saved successfully");
                this.Close();
            }
            else MessageBox.Show("Please review the red filds","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private bool validateInput()
        {
            bool ok = true;
            if (string.IsNullOrWhiteSpace(tbFirstName.Text))
            {
                ok = false;
                labelFirstName.ForeColor = Color.Red;
            }
            else
            {
                labelFirstName.ForeColor = Color.Black;
            }
            if (string.IsNullOrWhiteSpace(tbLastName.Text))
            {
                ok = false;
                labelLastName.ForeColor = Color.Red;
            }
            else
            {
                labelLastName.ForeColor = Color.Black;
            }
            if (string.IsNullOrWhiteSpace(tbEmail.Text))
            {
                ok = false;
                labelEmail.ForeColor = Color.Red;
            }
            else
            {
                labelEmail.ForeColor = Color.Black;
            }

            return ok;
        }
    }
}
