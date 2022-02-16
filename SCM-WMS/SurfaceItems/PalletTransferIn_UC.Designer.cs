namespace SCM_WMS.SurfaceItems
{
    partial class PalletTransferIn_UC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Show = new System.Windows.Forms.Button();
            this.lblMessege = new System.Windows.Forms.Label();
            this.ddlWh = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.txtTransectionDate = new System.Windows.Forms.DateTimePicker();
            this.ddlShift = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.Show);
            this.panel1.Controls.Add(this.lblMessege);
            this.panel1.Controls.Add(this.ddlWh);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtBarcode);
            this.panel1.Controls.Add(this.txtTransectionDate);
            this.panel1.Controls.Add(this.ddlShift);
            this.panel1.Location = new System.Drawing.Point(312, 58);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 246);
            this.panel1.TabIndex = 3;
            // 
            // Show
            // 
            this.Show.Location = new System.Drawing.Point(709, 92);
            this.Show.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(109, 48);
            this.Show.TabIndex = 45;
            this.Show.Text = "Show";
            this.Show.UseVisualStyleBackColor = true;
            this.Show.Click += new System.EventHandler(this.Show_Click);
            // 
            // lblMessege
            // 
            this.lblMessege.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessege.ForeColor = System.Drawing.Color.Red;
            this.lblMessege.Location = new System.Drawing.Point(4, 213);
            this.lblMessege.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessege.Name = "lblMessege";
            this.lblMessege.Size = new System.Drawing.Size(900, 22);
            this.lblMessege.TabIndex = 42;
            this.lblMessege.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ddlWh
            // 
            this.ddlWh.FormattingEnabled = true;
            this.ddlWh.Location = new System.Drawing.Point(324, 31);
            this.ddlWh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ddlWh.Name = "ddlWh";
            this.ddlWh.Size = new System.Drawing.Size(323, 24);
            this.ddlWh.TabIndex = 10;
            this.ddlWh.Text = "Select";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(197, 174);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Barcode No :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Transection Date :\t";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Shift :\t";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "WH Name :";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(324, 172);
            this.txtBarcode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(323, 22);
            this.txtBarcode.TabIndex = 4;
            this.txtBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarcode_KeyDown);
            // 
            // txtTransectionDate
            // 
            this.txtTransectionDate.Location = new System.Drawing.Point(324, 121);
            this.txtTransectionDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTransectionDate.Name = "txtTransectionDate";
            this.txtTransectionDate.Size = new System.Drawing.Size(323, 22);
            this.txtTransectionDate.TabIndex = 3;
            // 
            // ddlShift
            // 
            this.ddlShift.FormattingEnabled = true;
            this.ddlShift.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.ddlShift.Location = new System.Drawing.Point(324, 75);
            this.ddlShift.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ddlShift.Name = "ddlShift";
            this.ddlShift.Size = new System.Drawing.Size(323, 24);
            this.ddlShift.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(527, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(434, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "INVENTORY PALLET TRANSFER IN";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(0, -1);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1572, 47);
            this.panel2.TabIndex = 47;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(76, 335);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(1409, 300);
            this.dataGridView1.TabIndex = 48;
            // 
            // PalletTransferIn_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PalletTransferIn_UC";
            this.Size = new System.Drawing.Size(1572, 818);
            this.Load += new System.EventHandler(this.PalletTransferIn_UC_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.DateTimePicker txtTransectionDate;
        private System.Windows.Forms.ComboBox ddlShift;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox ddlWh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblMessege;
        private System.Windows.Forms.Button Show;
    }
}
