using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gladis_Holtelz
{
    public partial class FormViewReservations : Form
    {
        IDataAcces dataAcces;
        public FormViewReservations()
        {
            InitializeComponent();
            this.dataAcces = new DataAcces();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var dt = this.dataAcces.ViewDetails(this.tbSearchClient.Text, this.CBRoomType.Text, this.DTPStartDate.Value.Date, this.DTPEndDate.Value.Date);
            this.DGVDetails.DataSource = dt;
            this.DGVDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVDetails.AutoResizeColumns();
        }

        private void exportBTN_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML files (*.xml)|*.xml";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var dt = this.DGVDetails.DataSource as DataTable;

                if (dt != null)
                {
                    dt.TableName = saveFileDialog.FileName;
                    dt.WriteXml(saveFileDialog.FileName);
                    MessageBox.Show("The XML file has been saved succefully");
                }
                else
                {
                    MessageBox.Show("Can't save an empty file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
