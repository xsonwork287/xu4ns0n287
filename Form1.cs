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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //ket noi sql
        string chuoiketnoi = @"Data Source=LAPTOP-SAT3SA0H\SQLEXPRESS;Initial Catalog=De4QLDiemThi;Integrated Security=True;";
        SqlConnection conn = null;
        SqlDataAdapter dataD;
        DataTable dtD;
        DataView dvD;

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(chuoiketnoi);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                string sql_select = "Select [Masv], [Tensv], [Diemtoan], [Diemvan], [Diemngoaingu], (([Diemtoan]+[Diemvan]+[Diemngoaingu])/3) as [Diemtrungbinh]  from ThongTinDiem";
                dataD = new SqlDataAdapter(sql_select, conn);
                dtD = new DataTable();
                dataD.Fill(dtD);
                dgvD.DataSource = dtD;
                dgvD1.DataSource = dtD;
                //phần tìm kiếm
                dvD = new DataView(dtD);
                //dgvD.DataSource = dvD;
                dgvD1.DataSource = dvD;

                if (conn.State == ConnectionState.Open)
                    conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                string sql_insert = "Insert into ThongTinDiem values (@Masv, @Tensv, @Diemtoan, @Diemvan, @Diemngoaingu)";
                SqlCommand cmd = new SqlCommand(sql_insert, conn);
                cmd.Parameters.AddWithValue("@Masv", cboMasv.Text);
                cmd.Parameters.AddWithValue("@Tensv", txtTensv.Text);
                cmd.Parameters.AddWithValue("@Diemtoan", txtDiemtoan.Text);
                cmd.Parameters.AddWithValue("@Diemvan", txtDiemvan.Text);
                cmd.Parameters.AddWithValue("@Diemngoaingu", txtDiemngoaingu.Text);

                //bắt lỗi sai về điểm
                if (Convert.ToInt32(txtDiemtoan.Text) < 0 || Convert.ToInt32(txtDiemtoan.Text) > 10 ||
                    Convert.ToInt32(txtDiemvan.Text) < 0 || Convert.ToInt32(txtDiemvan.Text) > 10 ||
                    Convert.ToInt32(txtDiemngoaingu.Text) < 0 || Convert.ToInt32(txtDiemngoaingu.Text) > 10)
                {
                    MessageBox.Show("Vui lòng nhập lại điểm (0-10) !");
                }
                else
                {
                    cmd.ExecuteNonQuery();
                    Form1_Load(sender, e);
                }
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvD.RowCount > 0)
            {
                cboMasv.Text = dgvD.CurrentRow.Cells[0].Value.ToString();
                txtTensv.Text = dgvD.CurrentRow.Cells[1].Value.ToString();
                txtDiemtoan.Text = dgvD.CurrentRow.Cells[2].Value.ToString();
                txtDiemvan.Text = dgvD.CurrentRow.Cells[3].Value.ToString();
                txtDiemngoaingu.Text = dgvD.CurrentRow.Cells[4].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                string sql_delete = "Delete from ThongTinDiem where Masv = @Masv";
                SqlCommand cmd = new SqlCommand(sql_delete, conn);
                cmd.Parameters.AddWithValue("@Masv", cboMasv.Text);
                cmd.ExecuteNonQuery();
                Form1_Load(sender, e);
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                string sql_update = "Update ThongTinDiem set Tensv = @Tensv, Diemtoan = @Diemtoan, Diemvan = @Diemvan, Diemngoaingu = @Diemngoaingu where Masv = @Masv";
                SqlCommand cmd = new SqlCommand(sql_update, conn);
                cmd.Parameters.AddWithValue("@Masv", cboMasv.Text);
                cmd.Parameters.AddWithValue("@Tensv", txtTensv.Text);
                cmd.Parameters.AddWithValue("@Diemtoan", txtDiemtoan.Text);
                cmd.Parameters.AddWithValue("@Diemvan", txtDiemvan.Text);
                cmd.Parameters.AddWithValue("@Diemngoaingu", txtDiemngoaingu.Text);
                cmd.ExecuteNonQuery();
                Form1_Load(sender, e);

                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboMasv_SelectedIndexChanged(object sender, EventArgs e)
        {
            string masinhvien = cboMasv.SelectedIndex.ToString();

        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
               
                if(cboPhanloai.Text == "Giỏi")
                {
                    dvD.RowFilter = "Diemtrungbinh >= 8";
                    dgvD1.DataSource = dvD;
                }else if(cboPhanloai.Text == "Khá")
                {
                    dvD.RowFilter = "Diemtrungbinh < 8 and Diemtrungbinh >= 6.5";
                    dgvD1.DataSource= dvD;
                }
                else if(cboPhanloai.Text == "Trung bình")
                {
                    dvD.RowFilter = "Diemtrungbinh <6.5";
                    dgvD1.DataSource = dvD;
                }

                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
