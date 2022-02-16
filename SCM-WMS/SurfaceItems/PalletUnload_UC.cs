using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SCM_WMS.BLL;

namespace SCM_WMS.SurfaceItems
{
    public partial class PalletUnload_UC : UserControl
    {
        PalletTransferIn_BLL _PalletTransferin = new PalletTransferIn_BLL();
        Global global = new Global();
        DataTable DT = new DataTable();
        int Enroll;
        string Msg;
        public PalletUnload_UC()
        {
            InitializeComponent();
            DT = global.UserProfile();
            Enroll = Int32.Parse(DT.Rows[0]["intEmployeeID"].ToString());
        }

        private void PalletUnload_UC_Load(object sender, EventArgs e)
        {
            DT = _PalletTransferin.PlateTransferEntry(5, "", 0, 0, "", ref Msg);
            ddlWh.DisplayMember = "strName";
            ddlWh.ValueMember = "Id";
            ddlWh.DataSource = DT;
            DateSet();
        }
        public void DateSet()
        {
            TimeSpan start = new TimeSpan(0, 0, 0);
            TimeSpan end = new TimeSpan(06, 0, 0);
            DateTime datetime = DateTime.Now;
            TimeSpan now = datetime.TimeOfDay;

            //if (start <= now && now <= end)
            //{
            //    DateTime datetime1 = DateTime.Now.AddDays(-1);
            //    txtTransectionDate.Value = datetime1;
            //}
        }
        public bool DateDiffrence()
        {
            DateTime date1 = DateTime.Parse(txtTransectionDate.Text);
            DateTime date2 = DateTime.Today;
            int daysDiff = ((TimeSpan)(date2 - date1)).Days;
            if (daysDiff == 1 || daysDiff == 0)
            {
                return true;
            }
            else
            {
                return true;
            }
        }
        private void BindGread(DataTable dt)
        {
            dataGridView1.DataSource = null;
            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.ColumnCount = 6;
            dataGridView1.DataSource = dt;
            //Add Columns
            dataGridView1.Columns[0].Name = "int Sl";
            dataGridView1.Columns[0].HeaderText = "SL";
            dataGridView1.Columns[0].DataPropertyName = "intSl";
            dataGridView1.Columns[0].Width = 77;

            dataGridView1.Columns[1].HeaderText = "strCode";
            dataGridView1.Columns[1].Name = "Bar Code";
            dataGridView1.Columns[1].DataPropertyName = "strCode";
            dataGridView1.Columns[1].Width = 200;

            dataGridView1.Columns[2].HeaderText = "ItemName";
            dataGridView1.Columns[2].Name = "Item Name";
            dataGridView1.Columns[2].DataPropertyName = "strItemName";
            dataGridView1.Columns[2].Width = 290;      

            dataGridView1.Columns[3].Name = "Quantity";
            dataGridView1.Columns[3].HeaderText = "Quantity";
            dataGridView1.Columns[3].DataPropertyName = "numQuantity";
            dataGridView1.Columns[3].Width = 100;

            dataGridView1.Columns[4].Name = "FillerCounter";
            dataGridView1.Columns[4].HeaderText = "Filler Counter";
            dataGridView1.Columns[4].DataPropertyName = "strFillerCounter";
            dataGridView1.Columns[4].Width = 150;

            dataGridView1.Columns[5].Name = "Manufacture";
            dataGridView1.Columns[5].HeaderText = "Manufacture Date";
            dataGridView1.Columns[5].DataPropertyName = "dteManufacture";
            dataGridView1.Columns[5].Width = 200;

           // lblCounter.Text = dt.Rows.Count.ToString();

        }

        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string barcode = txtBarcode.Text.ToString();
                    int plateId = 0; //Convert.ToInt32(txtBarcode.Text);

                    if (barcode.Length > 2 && !string.IsNullOrEmpty(txtTransectionDate.Text) && Convert.ToDecimal(ddlWh.SelectedValue.ToString()) > 0 &&
                    DateTime.Parse(txtTransectionDate.Text) <= DateTime.Now && DateDiffrence())
                    {
                        int whId = Convert.ToInt32(ddlWh.SelectedValue);
                        DateTime dteTransection = DateTime.Parse(txtTransectionDate.Text);
                        string xml = "<voucher><voucherentry shift=" + '"' + ddlShift.SelectedItem.ToString() + '"' + " intActionBy=" +
                                     '"' + Enroll + '"' + " dteTransection=" + '"' + dteTransection + '"' + "/></voucher>".ToString();
                        DT = _PalletTransferin.PlateTransferIn(3, xml, whId, plateId, barcode, ref Msg);                   
                        BindGread(DT);
                        if (Msg.Length > 1)
                        {
                            lblMessege.Text = Msg;
                        }
                        txtBarcode.Text = "";
                        txtBarcode.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Please Enter the Correct Value");
                        txtBarcode.Text = "";
                        txtBarcode.Focus();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Faield");
                    txtBarcode.Text = "";
                    txtBarcode.Focus();
                }
            }
        }

 

        public void BindGrid()
        {
            try
            {
                int whId = Convert.ToInt32(ddlWh.SelectedValue);
                DateTime dteTransection = DateTime.Parse(txtTransectionDate.Text);
                string xml = "<voucher><voucherentry shift=" + '"' + ddlShift.SelectedItem.ToString() + '"' + " intActionBy=" +
                             '"' + Enroll + '"' + " dteTransection=" + '"' + dteTransection + '"' + "/></voucher>".ToString();
                DT = _PalletTransferin.PlateTransferEntry(9, xml, whId, 0, "0", ref Msg);
                BindGread(DT);
                if (Msg.Length > 1)
                {
                    lblMessege.Text = Msg;
                }
                txtBarcode.Text = "";
                txtBarcode.Focus();
            }
            catch
            {
               
            }
        }

        private void showUnload_Click(object sender, EventArgs e)
        {
            BindGrid();
        }
    }
}
