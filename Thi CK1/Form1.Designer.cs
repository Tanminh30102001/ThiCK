
namespace Thi_CK1
{
    partial class Form1
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnSua = new System.Windows.Forms.Button();
            this.Xóa = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdD = new System.Windows.Forms.RadioButton();
            this.rdC = new System.Windows.Forms.RadioButton();
            this.rdB = new System.Windows.Forms.RadioButton();
            this.rdA = new System.Windows.Forms.RadioButton();
            this.dtpNgaytra = new System.Windows.Forms.DateTimePicker();
            this.dtpNgaythue = new System.Windows.Forms.DateTimePicker();
            this.txtSongaythue = new System.Windows.Forms.TextBox();
            this.txtTenkhachhang = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaphong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgv.Location = new System.Drawing.Point(36, 200);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(732, 204);
            this.dgv.TabIndex = 34;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(693, 79);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 33;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // Xóa
            // 
            this.Xóa.Location = new System.Drawing.Point(693, 108);
            this.Xóa.Name = "Xóa";
            this.Xóa.Size = new System.Drawing.Size(75, 23);
            this.Xóa.TabIndex = 32;
            this.Xóa.Text = "Xóa";
            this.Xóa.UseVisualStyleBackColor = true;
            this.Xóa.Click += new System.EventHandler(this.Xóa_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(693, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 31;
            this.button2.Text = "Lưu File";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(693, 46);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 30;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdD);
            this.groupBox1.Controls.Add(this.rdC);
            this.groupBox1.Controls.Add(this.rdB);
            this.groupBox1.Controls.Add(this.rdA);
            this.groupBox1.Location = new System.Drawing.Point(484, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(124, 139);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loại Phòng";
            // 
            // rdD
            // 
            this.rdD.AutoSize = true;
            this.rdD.Location = new System.Drawing.Point(7, 101);
            this.rdD.Name = "rdD";
            this.rdD.Size = new System.Drawing.Size(39, 21);
            this.rdD.TabIndex = 3;
            this.rdD.TabStop = true;
            this.rdD.Text = "D";
            this.rdD.UseVisualStyleBackColor = true;
            // 
            // rdC
            // 
            this.rdC.AutoSize = true;
            this.rdC.Location = new System.Drawing.Point(7, 73);
            this.rdC.Name = "rdC";
            this.rdC.Size = new System.Drawing.Size(38, 21);
            this.rdC.TabIndex = 2;
            this.rdC.TabStop = true;
            this.rdC.Text = "C";
            this.rdC.UseVisualStyleBackColor = true;
            // 
            // rdB
            // 
            this.rdB.AutoSize = true;
            this.rdB.Location = new System.Drawing.Point(7, 50);
            this.rdB.Name = "rdB";
            this.rdB.Size = new System.Drawing.Size(38, 21);
            this.rdB.TabIndex = 1;
            this.rdB.TabStop = true;
            this.rdB.Text = "B";
            this.rdB.UseVisualStyleBackColor = true;
            // 
            // rdA
            // 
            this.rdA.AutoSize = true;
            this.rdA.Location = new System.Drawing.Point(7, 22);
            this.rdA.Name = "rdA";
            this.rdA.Size = new System.Drawing.Size(38, 21);
            this.rdA.TabIndex = 0;
            this.rdA.TabStop = true;
            this.rdA.Text = "A";
            this.rdA.UseVisualStyleBackColor = true;
            // 
            // dtpNgaytra
            // 
            this.dtpNgaytra.Location = new System.Drawing.Point(160, 109);
            this.dtpNgaytra.Name = "dtpNgaytra";
            this.dtpNgaytra.Size = new System.Drawing.Size(200, 22);
            this.dtpNgaytra.TabIndex = 28;
            // 
            // dtpNgaythue
            // 
            this.dtpNgaythue.Location = new System.Drawing.Point(160, 77);
            this.dtpNgaythue.Name = "dtpNgaythue";
            this.dtpNgaythue.Size = new System.Drawing.Size(200, 22);
            this.dtpNgaythue.TabIndex = 27;
            // 
            // txtSongaythue
            // 
            this.txtSongaythue.Location = new System.Drawing.Point(159, 162);
            this.txtSongaythue.Name = "txtSongaythue";
            this.txtSongaythue.Size = new System.Drawing.Size(201, 22);
            this.txtSongaythue.TabIndex = 26;
            // 
            // txtTenkhachhang
            // 
            this.txtTenkhachhang.Location = new System.Drawing.Point(160, 137);
            this.txtTenkhachhang.Name = "txtTenkhachhang";
            this.txtTenkhachhang.Size = new System.Drawing.Size(201, 22);
            this.txtTenkhachhang.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 24;
            // 
            // txtMaphong
            // 
            this.txtMaphong.Location = new System.Drawing.Point(160, 48);
            this.txtMaphong.Name = "txtMaphong";
            this.txtMaphong.Size = new System.Drawing.Size(200, 22);
            this.txtMaphong.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Ngày Thuê";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Ngày trả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Tên Khách Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Số ngày thuê";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mã Phòng";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaPT";
            this.Column1.HeaderText = "Mã Phòng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "NgayBD";
            this.Column2.HeaderText = "Ngày Thuê";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NgayKT";
            this.Column3.HeaderText = "Ngày trả";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TenKH";
            this.Column4.HeaderText = "Tên Khách hàng";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "SoNgayThue";
            this.Column5.HeaderText = "Số Ngày Thuê";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "LoaiPhong";
            this.Column6.HeaderText = "Loại phòng";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.Xóa);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpNgaytra);
            this.Controls.Add(this.dtpNgaythue);
            this.Controls.Add(this.txtSongaythue);
            this.Controls.Add(this.txtTenkhachhang);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMaphong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button Xóa;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdD;
        private System.Windows.Forms.RadioButton rdC;
        private System.Windows.Forms.RadioButton rdB;
        private System.Windows.Forms.RadioButton rdA;
        private System.Windows.Forms.DateTimePicker dtpNgaytra;
        private System.Windows.Forms.DateTimePicker dtpNgaythue;
        private System.Windows.Forms.TextBox txtSongaythue;
        private System.Windows.Forms.TextBox txtTenkhachhang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaphong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}

