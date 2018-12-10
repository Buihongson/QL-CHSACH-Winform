namespace BaiTapNhom
{
    partial class frmTimKiemNCC
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
            this.label7 = new System.Windows.Forms.Label();
            this.cbb_timKiem = new System.Windows.Forms.ComboBox();
            this.btn_timKiem = new System.Windows.Forms.Button();
            this.txt_timKiem = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Tìm Kiếm:";
            // 
            // cbb_timKiem
            // 
            this.cbb_timKiem.FormattingEnabled = true;
            this.cbb_timKiem.Items.AddRange(new object[] {
            "Mã NCC",
            "Tên NCC"});
            this.cbb_timKiem.Location = new System.Drawing.Point(118, 118);
            this.cbb_timKiem.Name = "cbb_timKiem";
            this.cbb_timKiem.Size = new System.Drawing.Size(168, 21);
            this.cbb_timKiem.TabIndex = 34;
            // 
            // btn_timKiem
            // 
            this.btn_timKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timKiem.Location = new System.Drawing.Point(595, 108);
            this.btn_timKiem.Name = "btn_timKiem";
            this.btn_timKiem.Size = new System.Drawing.Size(120, 40);
            this.btn_timKiem.TabIndex = 33;
            this.btn_timKiem.Text = "Hiển thị";
            this.btn_timKiem.UseVisualStyleBackColor = true;
            this.btn_timKiem.Click += new System.EventHandler(this.btn_timKiem_Click);
            // 
            // txt_timKiem
            // 
            this.txt_timKiem.Location = new System.Drawing.Point(321, 118);
            this.txt_timKiem.Name = "txt_timKiem";
            this.txt_timKiem.Size = new System.Drawing.Size(214, 20);
            this.txt_timKiem.TabIndex = 32;
            this.txt_timKiem.TextChanged += new System.EventHandler(this.txt_timKiem_TextChanged_1);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(13, 189);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(775, 249);
            this.panel3.TabIndex = 31;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Thistle;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(773, 246);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaNCC";
            this.Column1.HeaderText = "Mã NCC";
            this.Column1.Name = "Column1";
            this.Column1.Width = 119;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenNCC";
            this.Column2.HeaderText = "Tên NCC";
            this.Column2.Name = "Column2";
            this.Column2.Width = 250;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DiaChi";
            this.Column3.HeaderText = "Địa Chỉ";
            this.Column3.Name = "Column3";
            this.Column3.Width = 250;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DienThoai";
            this.Column4.HeaderText = "Điện Thoại";
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 31);
            this.label1.TabIndex = 36;
            this.label1.Text = "TÌM KIẾM NHÀ CUNG CẤP";
            // 
            // frmTimKiemNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbb_timKiem);
            this.Controls.Add(this.btn_timKiem);
            this.Controls.Add(this.txt_timKiem);
            this.Controls.Add(this.panel3);
            this.Name = "frmTimKiemNCC";
            this.Text = "Tìm kiếm nhà cung cấp";
            this.Load += new System.EventHandler(this.frmTimKiemNCC_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbb_timKiem;
        private System.Windows.Forms.Button btn_timKiem;
        private System.Windows.Forms.TextBox txt_timKiem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label1;
    }
}