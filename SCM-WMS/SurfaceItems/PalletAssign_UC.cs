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
    public partial class PalletAssign_UC : UserControl
    {
        DataTable dt = new DataTable();
        PalletAssign_BLL obj = new PalletAssign_BLL();
        Global global = new Global();
        string message;

        string xmlString = "";
        int Enroll;
        public PalletAssign_UC()
        {
            InitializeComponent();          
            dt = global.UserProfile();
            Enroll = Int32.Parse(dt.Rows[0]["intEmployeeID"].ToString());
        }

        private void PalletAssign_UC_Load(object sender, EventArgs e)
        {
            LoadWh();
            dt = obj.SearchProduct(Int32.Parse(ddlWH.SelectedValue.ToString()));
            ddlProduct.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            ddlProduct.AutoCompleteSource = AutoCompleteSource.ListItems;
            ddlProduct.DataSource = dt;
            ddlProduct.ValueMember = "intItem";
            ddlProduct.DisplayMember = "strItem";
        }

        public void LoadWh()
        {
            try
            {
                string xml = "<voucher><voucherentry enroll=" + '"' + Enroll + '"' + " whid=" +
                             '"' + ddlWH.SelectedValue + '"' + "/></voucher>".ToString();

                dt = obj.PlateAssign(xml,5,ref message);

                ddlWH.DataSource = dt;
                ddlWH.DisplayMember = "strName";
                ddlWH.ValueMember = "Id";

                ddlWH.SelectedIndex = 0;

                dt = obj.PlateAssign(xml, 4, ref message);

                ddlPlant.DisplayMember = "strPlantName";
                ddlPlant.ValueMember = "intID";
                ddlPlant.DataSource = dt;
                ddlPlant.SelectedIndex = 0;

                ddlShift.DisplayMember = "Text";
                ddlShift.ValueMember = "Value";

                ddlShift.SelectedIndex = 0;
            }
            catch { }

        }

        private void ddlWH_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = ddlWH.SelectedValue.ToString();
        }

        private void ddlProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(ddlProduct.Text) && ddlWH.SelectedValue.ToString() != "0")
                {
                    int intwh = int.Parse(ddlWH.SelectedValue.ToString());
                    int ProductId = int.Parse(ddlProduct.SelectedValue.ToString());
                    string xml = "<voucher><voucherentry productId=" + '"' + ProductId.ToString() + '"' + " whid=" +
                                 '"' + intwh.ToString() + '"' + "/></voucher>".ToString();
                    dt = obj.PlateAssign(xml, 3, ref message);

                    if (dt.Rows.Count > 0)
                    {
                        TxtQuantity.Text = dt.Rows[0]["numQuantity"].ToString();
                    }
                }
            }
            catch { }
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
            
            dataGridView1.Columns[1].Name = "Bar Code";
            dataGridView1.Columns[1].HeaderText = "Bar Code";
            dataGridView1.Columns[1].DataPropertyName = "strCode";
            dataGridView1.Columns[1].Width = 200;
         
            dataGridView1.Columns[2].Name = "Item Name";
            dataGridView1.Columns[2].HeaderText = "Item Name";
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



        private void txtbarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (txtbarcode.Text.Length > 0)
                    {
                        if (!string.IsNullOrEmpty(TxtQuantity.Text) && !string.IsNullOrEmpty(TxtBatch.Text) && !string.IsNullOrEmpty(TxtFExpiredate.Text)
                        && !string.IsNullOrEmpty(ddlWH.SelectedValue.ToString()) && !string.IsNullOrEmpty(txtProductionDate.Text) && !string.IsNullOrEmpty(txtFillerCounter.Text)
                        && Convert.ToDecimal(TxtQuantity.Text.ToString()) > 0 && Convert.ToDecimal(ddlPlant.SelectedValue.ToString()) > 0
                        && Convert.ToDecimal(ddlWH.SelectedValue.ToString()) > 0)
                        {
                            string plateBarcode = txtbarcode.Text;
                            int intwh = int.Parse(ddlWH.SelectedValue.ToString());
                            int ProductId = int.Parse(ddlProduct.SelectedValue.ToString());
                            string Quantity = TxtQuantity.Text;
                            string batch = TxtBatch.Text;
                            string product = ddlProduct.SelectedValue.ToString();
                            string shift = ddlShift.SelectedItem.ToString();
                            DateTime expire = DateTime.Parse(TxtFExpiredate.Text);
                            DateTime dteProduction = DateTime.Parse(txtProductionDate.Text);
                            string fillerCounter = txtFillerCounter.Text;
                            string plantId = ddlPlant.SelectedValue.ToString();
                            xmlString = "<voucher><voucherentry plateid=" + '"' + "0" + '"' + " barcode=" + '"' + plateBarcode + '"'
                                         + " productId=" + '"' + ProductId + '"'
                                         + " quantity=" + '"' + Quantity + '"'
                                         + " whId=" + '"' + intwh + '"'
                                         + " batch=" + '"' + batch + '"'
                                         + " expireDate=" + '"' + expire + '"'
                                         + " enroll=" + '"' + Enroll + '"'
                                         + " ProductName=" + '"' + product + '"'
                                         + " shift=" + '"' + shift + '"'
                                         + " plantId=" + '"' + plantId + '"'
                                         + " fillerCounter=" + '"' + fillerCounter + '"'
                                         + " dteProduction=" + '"' + dteProduction + '"'
                                         + "/></voucher>".ToString();

                            dt = obj.PlateAssign(xmlString, 1, ref message);
                            lblMessege.Text = message.ToString();
                            txtbarcode.Focus();
                            BindGread(dt);
                            txtbarcode.Text = "";
                            txtbarcode.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Please Enter the Correct Value");
                            txtbarcode.Text = "";
                            txtbarcode.Focus();
                        }
                    }
                    else
                    {
                    }
                }
                catch (Exception)
                {
                    txtbarcode.Focus();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string plateBarcode = txtbarcode.Text;
                int intwh = int.Parse(ddlWH.SelectedValue.ToString());
                int ProductId = int.Parse(ddlProduct.SelectedValue.ToString());
                string Quantity = TxtQuantity.Text;
                string batch = TxtBatch.Text;
                string product = ddlProduct.SelectedValue.ToString();
                string shift = ddlShift.SelectedItem.ToString();
                DateTime expire = DateTime.Parse(TxtFExpiredate.Text);
                DateTime dteProduction = DateTime.Parse(txtProductionDate.Text);
                string fillerCounter = txtFillerCounter.Text;
                string plantId = ddlPlant.SelectedValue.ToString();
                xmlString = "<voucher><voucherentry plateid=" + '"' + "0" + '"' + " barcode=" + '"' + plateBarcode + '"'
                                         + " productId=" + '"' + ProductId + '"'
                                         + " quantity=" + '"' + Quantity + '"'
                                         + " whId=" + '"' + intwh + '"'
                                         + " batch=" + '"' + batch + '"'
                                         + " expireDate=" + '"' + expire + '"'
                                         + " enroll=" + '"' + Enroll + '"'
                                         + " ProductName=" + '"' + product + '"'
                                         + " shift=" + '"' + shift + '"'
                                         + " plantId=" + '"' + plantId + '"'
                                         + " fillerCounter=" + '"' + fillerCounter + '"'
                                         + " dteProduction=" + '"' + dteProduction + '"'
                                         + "/></voucher>".ToString();

                dt = obj.PlateAssign(xmlString, 10, ref message);
               
                txtbarcode.Focus();
                BindGread(dt);
                txtbarcode.Text = "";
                txtbarcode.Focus();
            }
            catch
            {
                
            }
        }
    }
}
