namespace Lab04_04
{
    partial class ProductOrder
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpBegin = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ckbAll = new System.Windows.Forms.CheckBox();
            this.dgvTong = new System.Windows.Forms.DataGridView();
            this.clmSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSoHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNgayDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNgayGiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txbSum = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTong)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpEnd);
            this.groupBox1.Controls.Add(this.dtpBegin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ckbAll);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(780, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Đơn Hàng";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(521, 71);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 20);
            this.dtpEnd.TabIndex = 2;
            this.dtpEnd.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dtpBegin
            // 
            this.dtpBegin.Location = new System.Drawing.Point(147, 70);
            this.dtpBegin.Name = "dtpBegin";
            this.dtpBegin.Size = new System.Drawing.Size(200, 20);
            this.dtpBegin.TabIndex = 2;
            this.dtpBegin.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(417, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "đến";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thời Gian Giao Hàng";
            // 
            // ckbAll
            // 
            this.ckbAll.AutoSize = true;
            this.ckbAll.Location = new System.Drawing.Point(19, 29);
            this.ckbAll.Name = "ckbAll";
            this.ckbAll.Size = new System.Drawing.Size(152, 19);
            this.ckbAll.TabIndex = 0;
            this.ckbAll.Text = "Xem tất cả trong tháng";
            this.ckbAll.UseVisualStyleBackColor = true;
            this.ckbAll.CheckedChanged += new System.EventHandler(this.ckbAll_CheckedChanged);
            // 
            // dgvTong
            // 
            this.dgvTong.AllowUserToAddRows = false;
            this.dgvTong.AllowUserToDeleteRows = false;
            this.dgvTong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmSTT,
            this.clmSoHD,
            this.clmNgayDat,
            this.clmNgayGiao,
            this.clmThanhTien});
            this.dgvTong.Location = new System.Drawing.Point(13, 151);
            this.dgvTong.Name = "dgvTong";
            this.dgvTong.ReadOnly = true;
            this.dgvTong.RowHeadersWidth = 51;
            this.dgvTong.Size = new System.Drawing.Size(779, 360);
            this.dgvTong.TabIndex = 1;
            // 
            // clmSTT
            // 
            this.clmSTT.HeaderText = "STT";
            this.clmSTT.MinimumWidth = 6;
            this.clmSTT.Name = "clmSTT";
            this.clmSTT.ReadOnly = true;
            // 
            // clmSoHD
            // 
            this.clmSoHD.HeaderText = "Số HD";
            this.clmSoHD.MinimumWidth = 6;
            this.clmSoHD.Name = "clmSoHD";
            this.clmSoHD.ReadOnly = true;
            // 
            // clmNgayDat
            // 
            this.clmNgayDat.HeaderText = "Ngày Đặt Hàng";
            this.clmNgayDat.MinimumWidth = 6;
            this.clmNgayDat.Name = "clmNgayDat";
            this.clmNgayDat.ReadOnly = true;
            // 
            // clmNgayGiao
            // 
            this.clmNgayGiao.HeaderText = "Ngày Giao";
            this.clmNgayGiao.MinimumWidth = 6;
            this.clmNgayGiao.Name = "clmNgayGiao";
            this.clmNgayGiao.ReadOnly = true;
            // 
            // clmThanhTien
            // 
            this.clmThanhTien.HeaderText = "Thành Tiền";
            this.clmThanhTien.MinimumWidth = 6;
            this.clmThanhTien.Name = "clmThanhTien";
            this.clmThanhTien.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(588, 540);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tổng Cộng:";
            // 
            // txbSum
            // 
            this.txbSum.Location = new System.Drawing.Point(657, 533);
            this.txbSum.Name = "txbSum";
            this.txbSum.ReadOnly = true;
            this.txbSum.Size = new System.Drawing.Size(135, 20);
            this.txbSum.TabIndex = 2;
            this.txbSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ProductOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 565);
            this.Controls.Add(this.txbSum);
            this.Controls.Add(this.dgvTong);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Name = "ProductOrder";
            this.Text = "Pruduct Order";
            this.Load += new System.EventHandler(this.ProductOrder_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpBegin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckbAll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvTong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSoHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNgayDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNgayGiao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmThanhTien;
    }
}

