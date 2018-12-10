namespace BaiTapNhom
{
    partial class frmBanSach
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
            this.components = new System.ComponentModel.Container();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.maSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongMuaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTHDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txt_tongTien = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_tenNV = new System.Windows.Forms.ComboBox();
            this.txt_ngayLap = new System.Windows.Forms.TextBox();
            this.txt_soHD = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_themTTKH = new System.Windows.Forms.Button();
            this.btn_hoanThanh = new System.Windows.Forms.Button();
            this.cbb_maSach = new System.Windows.Forms.ComboBox();
            this.btn_mua = new System.Windows.Forms.Button();
            this.txt_gia = new System.Windows.Forms.TextBox();
            this.txt_soLuong = new System.Windows.Forms.TextBox();
            this.txt_TenSach = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTHDBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Controls.Add(this.txt_tongTien);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(305, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(483, 301);
            this.panel3.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSachDataGridViewTextBoxColumn,
            this.tenSachDataGridViewTextBoxColumn,
            this.soLuongMuaDataGridViewTextBoxColumn,
            this.thanhTienDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.cTHDBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(14, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(456, 233);
            this.dataGridView2.TabIndex = 13;
            // 
            // maSachDataGridViewTextBoxColumn
            // 
            this.maSachDataGridViewTextBoxColumn.DataPropertyName = "maSach";
            this.maSachDataGridViewTextBoxColumn.HeaderText = "Mã Sách";
            this.maSachDataGridViewTextBoxColumn.Name = "maSachDataGridViewTextBoxColumn";
            this.maSachDataGridViewTextBoxColumn.Width = 80;
            // 
            // tenSachDataGridViewTextBoxColumn
            // 
            this.tenSachDataGridViewTextBoxColumn.DataPropertyName = "tenSach";
            this.tenSachDataGridViewTextBoxColumn.HeaderText = "Tên Sách";
            this.tenSachDataGridViewTextBoxColumn.Name = "tenSachDataGridViewTextBoxColumn";
            this.tenSachDataGridViewTextBoxColumn.Width = 140;
            // 
            // soLuongMuaDataGridViewTextBoxColumn
            // 
            this.soLuongMuaDataGridViewTextBoxColumn.DataPropertyName = "soLuongMua";
            this.soLuongMuaDataGridViewTextBoxColumn.HeaderText = "Số Lượng Mua";
            this.soLuongMuaDataGridViewTextBoxColumn.Name = "soLuongMuaDataGridViewTextBoxColumn";
            // 
            // thanhTienDataGridViewTextBoxColumn
            // 
            this.thanhTienDataGridViewTextBoxColumn.DataPropertyName = "thanhTien";
            this.thanhTienDataGridViewTextBoxColumn.HeaderText = "Thành Tiền";
            this.thanhTienDataGridViewTextBoxColumn.Name = "thanhTienDataGridViewTextBoxColumn";
            // 
            // cTHDBindingSource
            // 
            this.cTHDBindingSource.DataSource = typeof(BaiTapNhom.CTHD);
            // 
            // txt_tongTien
            // 
            this.txt_tongTien.Location = new System.Drawing.Point(317, 271);
            this.txt_tongTien.Name = "txt_tongTien";
            this.txt_tongTien.ReadOnly = true;
            this.txt_tongTien.Size = new System.Drawing.Size(108, 20);
            this.txt_tongTien.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(242, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Tổng Tiền:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên NV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày Lập:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbb_tenNV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_ngayLap);
            this.groupBox1.Controls.Add(this.txt_soHD);
            this.groupBox1.Location = new System.Drawing.Point(13, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 138);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa Đơn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số HĐ:";
            // 
            // cbb_tenNV
            // 
            this.cbb_tenNV.FormattingEnabled = true;
            this.cbb_tenNV.Location = new System.Drawing.Point(82, 94);
            this.cbb_tenNV.Name = "cbb_tenNV";
            this.cbb_tenNV.Size = new System.Drawing.Size(185, 21);
            this.cbb_tenNV.TabIndex = 5;
            // 
            // txt_ngayLap
            // 
            this.txt_ngayLap.Location = new System.Drawing.Point(82, 62);
            this.txt_ngayLap.Name = "txt_ngayLap";
            this.txt_ngayLap.Size = new System.Drawing.Size(185, 20);
            this.txt_ngayLap.TabIndex = 4;
            // 
            // txt_soHD
            // 
            this.txt_soHD.Location = new System.Drawing.Point(82, 30);
            this.txt_soHD.Name = "txt_soHD";
            this.txt_soHD.Size = new System.Drawing.Size(185, 20);
            this.txt_soHD.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_themTTKH);
            this.groupBox2.Controls.Add(this.btn_hoanThanh);
            this.groupBox2.Controls.Add(this.cbb_maSach);
            this.groupBox2.Controls.Add(this.btn_mua);
            this.groupBox2.Controls.Add(this.txt_gia);
            this.groupBox2.Controls.Add(this.txt_soLuong);
            this.groupBox2.Controls.Add(this.txt_TenSach);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(13, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 247);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập Sách";
            // 
            // btn_themTTKH
            // 
            this.btn_themTTKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themTTKH.Location = new System.Drawing.Point(35, 181);
            this.btn_themTTKH.Name = "btn_themTTKH";
            this.btn_themTTKH.Size = new System.Drawing.Size(62, 40);
            this.btn_themTTKH.TabIndex = 14;
            this.btn_themTTKH.Text = "Thêm TTKH";
            this.btn_themTTKH.UseVisualStyleBackColor = true;
            this.btn_themTTKH.Click += new System.EventHandler(this.btn_themTTKH_Click);
            // 
            // btn_hoanThanh
            // 
            this.btn_hoanThanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hoanThanh.Location = new System.Drawing.Point(120, 181);
            this.btn_hoanThanh.Name = "btn_hoanThanh";
            this.btn_hoanThanh.Size = new System.Drawing.Size(62, 40);
            this.btn_hoanThanh.TabIndex = 13;
            this.btn_hoanThanh.Text = "Tạo lại hóa đơn";
            this.btn_hoanThanh.UseVisualStyleBackColor = true;
            // 
            // cbb_maSach
            // 
            this.cbb_maSach.FormattingEnabled = true;
            this.cbb_maSach.Location = new System.Drawing.Point(82, 30);
            this.cbb_maSach.Name = "cbb_maSach";
            this.cbb_maSach.Size = new System.Drawing.Size(185, 21);
            this.cbb_maSach.TabIndex = 11;
            this.cbb_maSach.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_mua
            // 
            this.btn_mua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mua.Location = new System.Drawing.Point(205, 181);
            this.btn_mua.Name = "btn_mua";
            this.btn_mua.Size = new System.Drawing.Size(62, 40);
            this.btn_mua.TabIndex = 10;
            this.btn_mua.Text = "Chọn Mua";
            this.btn_mua.UseVisualStyleBackColor = true;
            this.btn_mua.Click += new System.EventHandler(this.btn_mua_Click);
            // 
            // txt_gia
            // 
            this.txt_gia.Location = new System.Drawing.Point(82, 141);
            this.txt_gia.Name = "txt_gia";
            this.txt_gia.ReadOnly = true;
            this.txt_gia.Size = new System.Drawing.Size(185, 20);
            this.txt_gia.TabIndex = 9;
            // 
            // txt_soLuong
            // 
            this.txt_soLuong.Location = new System.Drawing.Point(82, 107);
            this.txt_soLuong.Name = "txt_soLuong";
            this.txt_soLuong.Size = new System.Drawing.Size(185, 20);
            this.txt_soLuong.TabIndex = 8;
            this.txt_soLuong.Text = "1";
            // 
            // txt_TenSach
            // 
            this.txt_TenSach.Location = new System.Drawing.Point(82, 67);
            this.txt_TenSach.Name = "txt_TenSach";
            this.txt_TenSach.ReadOnly = true;
            this.txt_TenSach.Size = new System.Drawing.Size(185, 20);
            this.txt_TenSach.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Giá:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Số Lượng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tên Sách:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã Sách:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(534, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 40);
            this.button1.TabIndex = 11;
            this.button1.Text = "Thanh toán và In hóa đơn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(652, 372);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 40);
            this.button2.TabIndex = 12;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(424, 372);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 40);
            this.button3.TabIndex = 13;
            this.button3.Text = "Thanh toán";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmBanSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Name = "frmBanSach";
            this.Text = "Bán sách";
            this.Load += new System.EventHandler(this.frmBanSach_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTHDBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_tenNV;
        private System.Windows.Forms.TextBox txt_ngayLap;
        private System.Windows.Forms.TextBox txt_soHD;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_mua;
        private System.Windows.Forms.TextBox txt_gia;
        private System.Windows.Forms.TextBox txt_soLuong;
        private System.Windows.Forms.TextBox txt_TenSach;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_tongTien;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.ComboBox cbb_maSach;
        private System.Windows.Forms.Button btn_hoanThanh;
        private System.Windows.Forms.Button btn_themTTKH;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn soHDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cTHDBindingSource;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongMuaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhTienDataGridViewTextBoxColumn;
    }
}