using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace De4QuanLiDiemThi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dgvD = new DataGridView();
            Masv = new DataGridViewTextBoxColumn();
            Tensv = new DataGridViewTextBoxColumn();
            Diemtoan = new DataGridViewTextBoxColumn();
            Diemvan = new DataGridViewTextBoxColumn();
            Diemngoaingu = new DataGridViewTextBoxColumn();
            Diemtrungbinh = new DataGridViewTextBoxColumn();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtDiemngoaingu = new TextBox();
            txtDiemvan = new TextBox();
            txtDiemtoan = new TextBox();
            txtTensv = new TextBox();
            cboMasv = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tabPage2 = new TabPage();
            dgvD1 = new DataGridView();
            Masv1 = new DataGridViewTextBoxColumn();
            Tensv1 = new DataGridViewTextBoxColumn();
            Diemtoan1 = new DataGridViewTextBoxColumn();
            Diemvan1 = new DataGridViewTextBoxColumn();
            Diemngoaingu1 = new DataGridViewTextBoxColumn();
            Diemtrungbinh1 = new DataGridViewTextBoxColumn();
            cboPhanloai = new ComboBox();
            btnThongke = new Button();
            label6 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((ISupportInitialize)dgvD).BeginInit();
            tabPage2.SuspendLayout();
            ((ISupportInitialize)dgvD1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvD);
            tabPage1.Controls.Add(btnXoa);
            tabPage1.Controls.Add(btnSua);
            tabPage1.Controls.Add(btnThem);
            tabPage1.Controls.Add(txtDiemngoaingu);
            tabPage1.Controls.Add(txtDiemvan);
            tabPage1.Controls.Add(txtDiemtoan);
            tabPage1.Controls.Add(txtTensv);
            tabPage1.Controls.Add(cboMasv);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label5);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 417);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Quản lí điểm";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvD
            // 
            dgvD.AllowUserToAddRows = false;
            dgvD.AllowUserToDeleteRows = false;
            dgvD.AllowUserToResizeColumns = false;
            dgvD.AllowUserToResizeRows = false;
            dgvD.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvD.Columns.AddRange(new DataGridViewColumn[] { Masv, Tensv, Diemtoan, Diemvan, Diemngoaingu, Diemtrungbinh });
            dgvD.Location = new Point(3, 153);
            dgvD.Name = "dgvD";
            dgvD.ReadOnly = true;
            dgvD.RowHeadersWidth = 51;
            dgvD.Size = new Size(786, 261);
            dgvD.TabIndex = 14;
            dgvD.CellContentClick += dgvD_CellContentClick;
            // 
            // Masv
            // 
            Masv.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Masv.DataPropertyName = "Masv";
            Masv.HeaderText = "Mã SV ";
            Masv.MinimumWidth = 6;
            Masv.Name = "Masv";
            Masv.ReadOnly = true;
            // 
            // Tensv
            // 
            Tensv.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Tensv.DataPropertyName = "Tensv";
            Tensv.HeaderText = "Tên SV";
            Tensv.MinimumWidth = 6;
            Tensv.Name = "Tensv";
            Tensv.ReadOnly = true;
            // 
            // Diemtoan
            // 
            Diemtoan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Diemtoan.DataPropertyName = "Diemtoan";
            Diemtoan.HeaderText = "Điểm toán";
            Diemtoan.MinimumWidth = 6;
            Diemtoan.Name = "Diemtoan";
            Diemtoan.ReadOnly = true;
            // 
            // Diemvan
            // 
            Diemvan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Diemvan.DataPropertyName = "Diemvan";
            Diemvan.HeaderText = "Điểm văn";
            Diemvan.MinimumWidth = 6;
            Diemvan.Name = "Diemvan";
            Diemvan.ReadOnly = true;
            // 
            // Diemngoaingu
            // 
            Diemngoaingu.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Diemngoaingu.DataPropertyName = "Diemngoaingu";
            Diemngoaingu.HeaderText = "Điểm ngoại ngữ";
            Diemngoaingu.MinimumWidth = 6;
            Diemngoaingu.Name = "Diemngoaingu";
            Diemngoaingu.ReadOnly = true;
            // 
            // Diemtrungbinh
            // 
            Diemtrungbinh.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Diemtrungbinh.DataPropertyName = "Diemtrungbinh";
            Diemtrungbinh.HeaderText = "Điểm trung bình";
            Diemtrungbinh.MinimumWidth = 6;
            Diemtrungbinh.Name = "Diemtrungbinh";
            Diemtrungbinh.ReadOnly = true;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = SystemColors.AppWorkspace;
            btnXoa.Location = new Point(467, 106);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 41);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = SystemColors.AppWorkspace;
            btnSua.Location = new Point(330, 106);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 41);
            btnSua.TabIndex = 6;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = SystemColors.AppWorkspace;
            btnThem.Location = new Point(199, 106);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 41);
            btnThem.TabIndex = 5;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // txtDiemngoaingu
            // 
            txtDiemngoaingu.BorderStyle = BorderStyle.FixedSingle;
            txtDiemngoaingu.Location = new Point(592, 59);
            txtDiemngoaingu.Name = "txtDiemngoaingu";
            txtDiemngoaingu.Size = new Size(125, 27);
            txtDiemngoaingu.TabIndex = 4;
            // 
            // txtDiemvan
            // 
            txtDiemvan.BorderStyle = BorderStyle.FixedSingle;
            txtDiemvan.Location = new Point(311, 59);
            txtDiemvan.Name = "txtDiemvan";
            txtDiemvan.Size = new Size(125, 27);
            txtDiemvan.TabIndex = 3;
            // 
            // txtDiemtoan
            // 
            txtDiemtoan.BorderStyle = BorderStyle.FixedSingle;
            txtDiemtoan.Location = new Point(81, 59);
            txtDiemtoan.Name = "txtDiemtoan";
            txtDiemtoan.Size = new Size(137, 27);
            txtDiemtoan.TabIndex = 2;
            // 
            // txtTensv
            // 
            txtTensv.BorderStyle = BorderStyle.FixedSingle;
            txtTensv.Location = new Point(467, 17);
            txtTensv.Name = "txtTensv";
            txtTensv.Size = new Size(250, 27);
            txtTensv.TabIndex = 8;
            // 
            // cboMasv
            // 
            cboMasv.FormattingEnabled = true;
            cboMasv.Items.AddRange(new object[] { "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120" });
            cboMasv.Location = new Point(81, 17);
            cboMasv.Name = "cboMasv";
            cboMasv.Size = new Size(224, 28);
            cboMasv.TabIndex = 1;
            cboMasv.SelectedIndexChanged += cboMasv_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 20);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 1;
            label1.Text = "Mã SV";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 62);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 2;
            label2.Text = "Điểm toán";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(233, 62);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 3;
            label3.Text = "Điểm văn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(386, 17);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 4;
            label4.Text = "Họ tên SV";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(467, 62);
            label5.Name = "label5";
            label5.Size = new Size(117, 20);
            label5.TabIndex = 5;
            label5.Text = "Điểm ngoại ngữ";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvD1);
            tabPage2.Controls.Add(cboPhanloai);
            tabPage2.Controls.Add(btnThongke);
            tabPage2.Controls.Add(label6);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 417);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Thống kê";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvD1
            // 
            dgvD1.AllowUserToAddRows = false;
            dgvD1.AllowUserToDeleteRows = false;
            dgvD1.AllowUserToResizeColumns = false;
            dgvD1.AllowUserToResizeRows = false;
            dgvD1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvD1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvD1.Columns.AddRange(new DataGridViewColumn[] { Masv1, Tensv1, Diemtoan1, Diemvan1, Diemngoaingu1, Diemtrungbinh1 });
            dgvD1.Location = new Point(3, 91);
            dgvD1.Name = "dgvD1";
            dgvD1.ReadOnly = true;
            dgvD1.RowHeadersWidth = 51;
            dgvD1.Size = new Size(786, 323);
            dgvD1.TabIndex = 4;
            // 
            // Masv1
            // 
            Masv1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Masv1.DataPropertyName = "Masv";
            Masv1.HeaderText = "Mã SV";
            Masv1.MinimumWidth = 6;
            Masv1.Name = "Masv1";
            Masv1.ReadOnly = true;
            // 
            // Tensv1
            // 
            Tensv1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Tensv1.DataPropertyName = "Tensv";
            Tensv1.HeaderText = "Tên SV";
            Tensv1.MinimumWidth = 6;
            Tensv1.Name = "Tensv1";
            Tensv1.ReadOnly = true;
            // 
            // Diemtoan1
            // 
            Diemtoan1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Diemtoan1.DataPropertyName = "Diemtoan";
            Diemtoan1.HeaderText = "Điểm toán";
            Diemtoan1.MinimumWidth = 6;
            Diemtoan1.Name = "Diemtoan1";
            Diemtoan1.ReadOnly = true;
            // 
            // Diemvan1
            // 
            Diemvan1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Diemvan1.DataPropertyName = "Diemvan";
            Diemvan1.HeaderText = "Điểm văn";
            Diemvan1.MinimumWidth = 6;
            Diemvan1.Name = "Diemvan1";
            Diemvan1.ReadOnly = true;
            // 
            // Diemngoaingu1
            // 
            Diemngoaingu1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Diemngoaingu1.DataPropertyName = "Diemngoaingu";
            Diemngoaingu1.HeaderText = "Điểm ngoại ngữ";
            Diemngoaingu1.MinimumWidth = 6;
            Diemngoaingu1.Name = "Diemngoaingu1";
            Diemngoaingu1.ReadOnly = true;
            // 
            // Diemtrungbinh1
            // 
            Diemtrungbinh1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Diemtrungbinh1.DataPropertyName = "Diemtrungbinh";
            Diemtrungbinh1.HeaderText = "Điểm trung bình";
            Diemtrungbinh1.MinimumWidth = 6;
            Diemtrungbinh1.Name = "Diemtrungbinh1";
            Diemtrungbinh1.ReadOnly = true;
            // 
            // cboPhanloai
            // 
            cboPhanloai.FormattingEnabled = true;
            cboPhanloai.Items.AddRange(new object[] { "Giỏi", "Khá", "Trung bình" });
            cboPhanloai.Location = new Point(265, 34);
            cboPhanloai.Name = "cboPhanloai";
            cboPhanloai.Size = new Size(256, 28);
            cboPhanloai.TabIndex = 3;
            // 
            // btnThongke
            // 
            btnThongke.BackColor = Color.Silver;
            btnThongke.Location = new Point(564, 25);
            btnThongke.Name = "btnThongke";
            btnThongke.Size = new Size(102, 45);
            btnThongke.TabIndex = 2;
            btnThongke.Text = "Thống kê";
            btnThongke.UseVisualStyleBackColor = false;
            btnThongke.Click += btnThongke_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(128, 37);
            label6.Name = "label6";
            label6.Size = new Size(131, 20);
            label6.TabIndex = 0;
            label6.Text = "Phân loại sinh viên";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((ISupportInitialize)dgvD).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((ISupportInitialize)dgvD1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ComboBox cboMasv;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtDiemngoaingu;
        private TextBox txtDiemvan;
        private TextBox txtDiemtoan;
        private TextBox txtTensv;
        private DataGridView dgvD;
        private DataGridViewTextBoxColumn Masv;
        private DataGridViewTextBoxColumn Tensv;
        private DataGridViewTextBoxColumn Diemtoan;
        private DataGridViewTextBoxColumn Diemvan;
        private DataGridViewTextBoxColumn Diemngoaingu;
        private DataGridViewTextBoxColumn Diemtrungbinh;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private ComboBox cboPhanloai;
        private Button btnThongke;
        private Label label6;
        private DataGridView dgvD1;
        private DataGridViewTextBoxColumn Masv1;
        private DataGridViewTextBoxColumn Tensv1;
        private DataGridViewTextBoxColumn Diemtoan1;
        private DataGridViewTextBoxColumn Diemvan1;
        private DataGridViewTextBoxColumn Diemngoaingu1;
        private DataGridViewTextBoxColumn Diemtrungbinh1;
    }
}
