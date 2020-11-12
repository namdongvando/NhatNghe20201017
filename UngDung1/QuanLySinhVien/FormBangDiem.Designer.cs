namespace QuanLySinhVien
{
    partial class FormBangDiem
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
            this.dgvBangDiem = new System.Windows.Forms.DataGridView();
            this.cbbSinhVien = new System.Windows.Forms.ComboBox();
            this.cbbLopHoc = new System.Windows.Forms.ComboBox();
            this.txtToan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLy = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHoa = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBangDiem
            // 
            this.dgvBangDiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBangDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBangDiem.Location = new System.Drawing.Point(12, 71);
            this.dgvBangDiem.Name = "dgvBangDiem";
            this.dgvBangDiem.Size = new System.Drawing.Size(776, 367);
            this.dgvBangDiem.TabIndex = 0;
            // 
            // cbbSinhVien
            // 
            this.cbbSinhVien.FormattingEnabled = true;
            this.cbbSinhVien.Location = new System.Drawing.Point(23, 27);
            this.cbbSinhVien.Name = "cbbSinhVien";
            this.cbbSinhVien.Size = new System.Drawing.Size(121, 21);
            this.cbbSinhVien.TabIndex = 1;
            // 
            // cbbLopHoc
            // 
            this.cbbLopHoc.FormattingEnabled = true;
            this.cbbLopHoc.Location = new System.Drawing.Point(163, 27);
            this.cbbLopHoc.Name = "cbbLopHoc";
            this.cbbLopHoc.Size = new System.Drawing.Size(121, 21);
            this.cbbLopHoc.TabIndex = 2;
            // 
            // txtToan
            // 
            this.txtToan.Location = new System.Drawing.Point(290, 27);
            this.txtToan.Name = "txtToan";
            this.txtToan.Size = new System.Drawing.Size(47, 20);
            this.txtToan.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sinh Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lớp Học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Toán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Lý";
            // 
            // txtLy
            // 
            this.txtLy.Location = new System.Drawing.Point(343, 27);
            this.txtLy.Name = "txtLy";
            this.txtLy.Size = new System.Drawing.Size(43, 20);
            this.txtLy.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(389, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Hóa";
            // 
            // txtHoa
            // 
            this.txtHoa.Location = new System.Drawing.Point(392, 28);
            this.txtHoa.Name = "txtHoa";
            this.txtHoa.Size = new System.Drawing.Size(41, 20);
            this.txtHoa.TabIndex = 9;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(450, 25);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 11;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(607, 24);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(41, 23);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // FormBangDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHoa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtToan);
            this.Controls.Add(this.cbbLopHoc);
            this.Controls.Add(this.cbbSinhVien);
            this.Controls.Add(this.dgvBangDiem);
            this.Name = "FormBangDiem";
            this.Text = "FormBangDiem";
            this.Load += new System.EventHandler(this.FormBangDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangDiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBangDiem;
        private System.Windows.Forms.ComboBox cbbSinhVien;
        private System.Windows.Forms.ComboBox cbbLopHoc;
        private System.Windows.Forms.TextBox txtToan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
    }
}