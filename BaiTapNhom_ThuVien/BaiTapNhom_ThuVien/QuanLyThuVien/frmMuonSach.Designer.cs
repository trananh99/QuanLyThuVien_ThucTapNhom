namespace QuanLyThuVien
{
    partial class frmMuonSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMuonSach));
            this.gbMuonTaiLieu = new System.Windows.Forms.GroupBox();
            this.txtMaTL = new System.Windows.Forms.TextBox();
            this.lblMaTL = new System.Windows.Forms.Label();
            this.btnMuon = new System.Windows.Forms.Button();
            this.txtMaBD = new System.Windows.Forms.TextBox();
            this.lblMaBD = new System.Windows.Forms.Label();
            this.gbDaMuon = new System.Windows.Forms.GroupBox();
            this.dgvSachDaMuon = new System.Windows.Forms.DataGridView();
            this.gbMuonMoi = new System.Windows.Forms.GroupBox();
            this.dgvSachMuon = new System.Windows.Forms.DataGridView();
            this.gbButton = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhanDe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbMuonTaiLieu.SuspendLayout();
            this.gbDaMuon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachDaMuon)).BeginInit();
            this.gbMuonMoi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachMuon)).BeginInit();
            this.gbButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMuonTaiLieu
            // 
            this.gbMuonTaiLieu.BackColor = System.Drawing.Color.Cornsilk;
            this.gbMuonTaiLieu.Controls.Add(this.txtMaTL);
            this.gbMuonTaiLieu.Controls.Add(this.lblMaTL);
            this.gbMuonTaiLieu.Controls.Add(this.btnMuon);
            this.gbMuonTaiLieu.Controls.Add(this.txtMaBD);
            this.gbMuonTaiLieu.Controls.Add(this.lblMaBD);
            this.gbMuonTaiLieu.Cursor = System.Windows.Forms.Cursors.Default;
            this.gbMuonTaiLieu.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbMuonTaiLieu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMuonTaiLieu.ForeColor = System.Drawing.Color.Maroon;
            this.gbMuonTaiLieu.Location = new System.Drawing.Point(0, 0);
            this.gbMuonTaiLieu.Name = "gbMuonTaiLieu";
            this.gbMuonTaiLieu.Size = new System.Drawing.Size(1383, 156);
            this.gbMuonTaiLieu.TabIndex = 0;
            this.gbMuonTaiLieu.TabStop = false;
            this.gbMuonTaiLieu.Text = "Mượn tài liệu";
            // 
            // txtMaTL
            // 
            this.txtMaTL.Location = new System.Drawing.Point(972, 53);
            this.txtMaTL.Name = "txtMaTL";
            this.txtMaTL.Size = new System.Drawing.Size(246, 30);
            this.txtMaTL.TabIndex = 4;
            // 
            // lblMaTL
            // 
            this.lblMaTL.AutoSize = true;
            this.lblMaTL.ForeColor = System.Drawing.Color.Blue;
            this.lblMaTL.Location = new System.Drawing.Point(826, 56);
            this.lblMaTL.Name = "lblMaTL";
            this.lblMaTL.Size = new System.Drawing.Size(100, 23);
            this.lblMaTL.TabIndex = 3;
            this.lblMaTL.Text = "Mã tài liệu";
            // 
            // btnMuon
            // 
            this.btnMuon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnMuon.Location = new System.Drawing.Point(580, 94);
            this.btnMuon.Name = "btnMuon";
            this.btnMuon.Size = new System.Drawing.Size(104, 45);
            this.btnMuon.TabIndex = 2;
            this.btnMuon.Text = "Mượn sách";
            this.btnMuon.UseVisualStyleBackColor = false;
            this.btnMuon.Click += new System.EventHandler(this.btnMuon_Click);
            // 
            // txtMaBD
            // 
            this.txtMaBD.Location = new System.Drawing.Point(187, 58);
            this.txtMaBD.Name = "txtMaBD";
            this.txtMaBD.Size = new System.Drawing.Size(207, 30);
            this.txtMaBD.TabIndex = 1;
            this.txtMaBD.TextChanged += new System.EventHandler(this.txtMaBD_TextChanged);
            // 
            // lblMaBD
            // 
            this.lblMaBD.AutoSize = true;
            this.lblMaBD.ForeColor = System.Drawing.Color.Blue;
            this.lblMaBD.Location = new System.Drawing.Point(24, 56);
            this.lblMaBD.Name = "lblMaBD";
            this.lblMaBD.Size = new System.Drawing.Size(107, 23);
            this.lblMaBD.TabIndex = 0;
            this.lblMaBD.Text = "Mã bạn đọc";
            // 
            // gbDaMuon
            // 
            this.gbDaMuon.Controls.Add(this.dgvSachDaMuon);
            this.gbDaMuon.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDaMuon.Location = new System.Drawing.Point(0, 162);
            this.gbDaMuon.Name = "gbDaMuon";
            this.gbDaMuon.Size = new System.Drawing.Size(553, 517);
            this.gbDaMuon.TabIndex = 1;
            this.gbDaMuon.TabStop = false;
            this.gbDaMuon.Text = "Tài liệu đã mượn";
            // 
            // dgvSachDaMuon
            // 
            this.dgvSachDaMuon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvSachDaMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSachDaMuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTL,
            this.NhanDe,
            this.TacGia,
            this.NgayMuon,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dgvSachDaMuon.EnableHeadersVisualStyles = false;
            this.dgvSachDaMuon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvSachDaMuon.Location = new System.Drawing.Point(4, 27);
            this.dgvSachDaMuon.Name = "dgvSachDaMuon";
            this.dgvSachDaMuon.RowHeadersVisible = false;
            this.dgvSachDaMuon.RowHeadersWidth = 51;
            this.dgvSachDaMuon.RowTemplate.Height = 24;
            this.dgvSachDaMuon.Size = new System.Drawing.Size(545, 484);
            this.dgvSachDaMuon.TabIndex = 0;
            // 
            // gbMuonMoi
            // 
            this.gbMuonMoi.Controls.Add(this.dgvSachMuon);
            this.gbMuonMoi.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMuonMoi.Location = new System.Drawing.Point(830, 162);
            this.gbMuonMoi.Name = "gbMuonMoi";
            this.gbMuonMoi.Size = new System.Drawing.Size(553, 517);
            this.gbMuonMoi.TabIndex = 2;
            this.gbMuonMoi.TabStop = false;
            this.gbMuonMoi.Text = "Tài liệu muốn mượn";
            // 
            // dgvSachMuon
            // 
            this.dgvSachMuon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvSachMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSachMuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.colum2,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvSachMuon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSachMuon.EnableHeadersVisualStyles = false;
            this.dgvSachMuon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvSachMuon.Location = new System.Drawing.Point(3, 26);
            this.dgvSachMuon.Name = "dgvSachMuon";
            this.dgvSachMuon.RowHeadersVisible = false;
            this.dgvSachMuon.RowHeadersWidth = 51;
            this.dgvSachMuon.Size = new System.Drawing.Size(547, 488);
            this.dgvSachMuon.TabIndex = 1;
            // 
            // gbButton
            // 
            this.gbButton.BackColor = System.Drawing.Color.Gold;
            this.gbButton.Controls.Add(this.btnHuy);
            this.gbButton.Controls.Add(this.btnOK);
            this.gbButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbButton.Location = new System.Drawing.Point(598, 266);
            this.gbButton.Name = "gbButton";
            this.gbButton.Size = new System.Drawing.Size(199, 297);
            this.gbButton.TabIndex = 3;
            this.gbButton.TabStop = false;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Aqua;
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(41, 176);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(121, 82);
            this.btnHuy.TabIndex = 1;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Aqua;
            this.btnOK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(41, 51);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(121, 82);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "Hoàn tất ";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaDauSach";
            this.Column1.HeaderText = "Mã đầu sách";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // colum2
            // 
            this.colum2.DataPropertyName = "NhanĐe";
            this.colum2.HeaderText = "Nhan đề";
            this.colum2.MinimumWidth = 6;
            this.colum2.Name = "colum2";
            this.colum2.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TacGia";
            this.Column2.HeaderText = "Tác giả";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SoLuong";
            this.Column3.HeaderText = "Số lượng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DoMat";
            this.Column4.HeaderText = "Độ mật";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "NgoNgu";
            this.Column5.HeaderText = "Ngôn ngữ";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "TenTheLoai";
            this.Column6.HeaderText = "Thể Loại";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "TenNXB";
            this.Column7.HeaderText = " NXB";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // MaTL
            // 
            this.MaTL.DataPropertyName = "MaTL";
            this.MaTL.HeaderText = "Mã đầu sách";
            this.MaTL.MinimumWidth = 6;
            this.MaTL.Name = "MaTL";
            this.MaTL.Width = 125;
            // 
            // NhanDe
            // 
            this.NhanDe.DataPropertyName = "NhanDe";
            this.NhanDe.HeaderText = "Nhan đề";
            this.NhanDe.MinimumWidth = 6;
            this.NhanDe.Name = "NhanDe";
            this.NhanDe.Width = 125;
            // 
            // TacGia
            // 
            this.TacGia.DataPropertyName = "TacGia";
            this.TacGia.HeaderText = "Tác giả";
            this.TacGia.MinimumWidth = 6;
            this.TacGia.Name = "TacGia";
            this.TacGia.Width = 125;
            // 
            // NgayMuon
            // 
            this.NgayMuon.DataPropertyName = "NgayMuon";
            this.NgayMuon.HeaderText = "Ngày mượn";
            this.NgayMuon.MinimumWidth = 6;
            this.NgayMuon.Name = "NgayMuon";
            this.NgayMuon.Width = 125;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "NgayTra";
            this.Column8.HeaderText = "Ngày trả";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "HanTra";
            this.Column9.HeaderText = "Hạn Trả";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "GhiChu";
            this.Column10.HeaderText = "Ghi chú";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 125;
            // 
            // frmMuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1383, 673);
            this.Controls.Add(this.gbButton);
            this.Controls.Add(this.gbMuonMoi);
            this.Controls.Add(this.gbDaMuon);
            this.Controls.Add(this.gbMuonTaiLieu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMuonSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mượn Sách";
            this.gbMuonTaiLieu.ResumeLayout(false);
            this.gbMuonTaiLieu.PerformLayout();
            this.gbDaMuon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachDaMuon)).EndInit();
            this.gbMuonMoi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachMuon)).EndInit();
            this.gbButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMuonTaiLieu;
        private System.Windows.Forms.GroupBox gbDaMuon;
        private System.Windows.Forms.Label lblMaTL;
        private System.Windows.Forms.TextBox txtMaBD;
        private System.Windows.Forms.Label lblMaBD;
        private System.Windows.Forms.GroupBox gbMuonMoi;
        private System.Windows.Forms.GroupBox gbButton;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtMaTL;
        private System.Windows.Forms.DataGridView dgvSachDaMuon;
        private System.Windows.Forms.DataGridView dgvSachMuon;
        private System.Windows.Forms.Button btnMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTL;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhanDe;
        private System.Windows.Forms.DataGridViewTextBoxColumn TacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
    }
}