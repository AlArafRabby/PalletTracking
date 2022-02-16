namespace SCM_WMS.SurfaceItems
{
    partial class PalletUnload_UC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCounter = new System.Windows.Forms.Label();
            this.lblMessege = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.txtTransectionDate = new System.Windows.Forms.DateTimePicker();
            this.ddlShift = new System.Windows.Forms.ComboBox();
            this.ddlWh = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.showUnload = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.showUnload);
            this.panel1.Controls.Add(this.lblCounter);
            this.panel1.Controls.Add(this.lblMessege);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtBarcode);
            this.panel1.Controls.Add(this.txtTransectionDate);
            this.panel1.Controls.Add(this.ddlShift);
            this.panel1.Controls.Add(this.ddlWh);
            this.panel1.Location = new System.Drawing.Point(243, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 200);
            this.panel1.TabIndex = 52;
            // 
            // lblCounter
            // 
            this.lblCounter.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounter.ForeColor = System.Drawing.Color.Red;
            this.lblCounter.Location = new System.Drawing.Point(546, 49);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(87, 53);
            this.lblCounter.TabIndex = 44;
            // 
            // lblMessege
            // 
            this.lblMessege.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessege.ForeColor = System.Drawing.Color.Red;
            this.lblMessege.Location = new System.Drawing.Point(3, 172);
            this.lblMessege.Name = "lblMessege";
            this.lblMessege.Size = new System.Drawing.Size(675, 18);
            this.lblMessege.TabIndex = 43;
            this.lblMessege.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Barcode No :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Transection Date :\t";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Shift :\t";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "WH Name :";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(243, 141);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(243, 20);
            this.txtBarcode.TabIndex = 4;
            this.txtBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarcode_KeyDown);
            // 
            // txtTransectionDate
            // 
            this.txtTransectionDate.Location = new System.Drawing.Point(243, 99);
            this.txtTransectionDate.Name = "txtTransectionDate";
            this.txtTransectionDate.Size = new System.Drawing.Size(243, 20);
            this.txtTransectionDate.TabIndex = 3;
            // 
            // ddlShift
            // 
            this.ddlShift.FormattingEnabled = true;
            this.ddlShift.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.ddlShift.Location = new System.Drawing.Point(243, 62);
            this.ddlShift.Name = "ddlShift";
            this.ddlShift.Size = new System.Drawing.Size(243, 21);
            this.ddlShift.TabIndex = 2;
            // 
            // ddlWh
            // 
            this.ddlWh.FormattingEnabled = true;
            this.ddlWh.Location = new System.Drawing.Point(243, 26);
            this.ddlWh.Name = "ddlWh";
            this.ddlWh.Size = new System.Drawing.Size(243, 21);
            this.ddlWh.TabIndex = 1;
            this.ddlWh.Text = "Select";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(481, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "PALLET UNLOAD";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(0, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1179, 38);
            this.panel2.TabIndex = 53;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(53, 283);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(1057, 244);
            this.dataGridView1.TabIndex = 54;
            // 
            // showUnload
            // 
            this.showUnload.Location = new System.Drawing.Point(552, 79);
            this.showUnload.Name = "showUnload";
            this.showUnload.Size = new System.Drawing.Size(75, 36);
            this.showUnload.TabIndex = 45;
            this.showUnload.Text = "Show";
            this.showUnload.UseVisualStyleBackColor = true;
            this.showUnload.Click += new System.EventHandler(this.showUnload_Click);
            // 
            // PalletUnload_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "PalletUnload_UC";
            this.Size = new System.Drawing.Size(1179, 665);
            this.Load += new System.EventHandler(this.PalletUnload_UC_Load);
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
        private System.Windows.Forms.ComboBox ddlWh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblMessege;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.Button showUnload;
    }
}
