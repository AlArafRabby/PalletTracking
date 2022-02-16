using SCM_WMS.SurfaceItems;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCM_WMS
{
    public partial class ManePage : Form
    {
        public ManePage()
        {
            InitializeComponent();
        }
        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            pnlSurface.Controls.Clear();
            pnlSurface.Controls.Add(c);
        }
        private void btnPalletAssign_Click(object sender, EventArgs e)
        {
            PalletAssign_UC prod = new PalletAssign_UC();
            AddControlsToPanel(prod);
        }

        private void btnPalletTransferIn_Click(object sender, EventArgs e)
        {
            PalletTransferIn_UC prod = new PalletTransferIn_UC();
            AddControlsToPanel(prod);
        }

        private void btnPalletTransferOut_Click(object sender, EventArgs e)
        {
            PalletTransferOut prod = new PalletTransferOut();
            AddControlsToPanel(prod);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnPalletUnload_Click(object sender, EventArgs e)
        {
            PalletUnload_UC prod = new PalletUnload_UC();
            AddControlsToPanel(prod);
        }
    }
}
