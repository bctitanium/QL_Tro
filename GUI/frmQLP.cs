using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;

namespace GUI
{
    public partial class frmQLP : Form
    {
        QLTroBAL qltbal = new QLTroBAL();

        int DongDangChon = 0;

        public frmQLP()
        {
            InitializeComponent();
        }

        private void frmQLP_Load(object sender, EventArgs e)
        {
            dgvPhong.DataSource = qltbal.LoadDGVPhong();
        }

        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //tránh khi nhấn vào biên nó không bị lỗi
            if (e.RowIndex == -1 || e.ColumnIndex == -1)
            {
                return;
            }
            
            //lấy ra dòng đang chọn để về sau xài
            DongDangChon = e.RowIndex;

            //lấy ra mã phòng và mã hóa đơn
            string maphong = qltbal.LayMaPhongTuTenPhong(dgvPhong.Rows[e.RowIndex].Cells[0].Value.ToString());
            string mahoadon = qltbal.LayMHDTuNgayLap(maphong);

            //load vào datagridview khách và chi tiết hóa đơn
            dgvKhach.DataSource = qltbal.LoadDGVKhachOPhongNao(maphong);
            dgvDV.DataSource = qltbal.LoadDGVCTHD(maphong, mahoadon);
            
            //nếu là phòng đang sử dụng thì mới có hóa đơn và mới tính tiền được
            if (dgvPhong.Rows[e.RowIndex].Cells[1].Value.ToString() == "Đang sử dụng")
            {
                //load vào textbox tổng thành tiền của hóa đơn đó
                lbTongThanhTien.Text = qltbal.TinhTienTheoHoaDon(mahoadon) + " đ";
                //ẩn nút chuyển đi
                btnChuyen.Visible = false;
            }
            else
            {
                //nếu là phòng đang đặt cọc thì không có hóa đơn và thành tiền là giá đặt cọc phòng
                if (dgvPhong.Rows[e.RowIndex].Cells[1].Value.ToString() == "Đang đặt cọc")
                {
                    //tắt nút chuyển đi
                    btnChuyen.Visible = true;

                    lbTongThanhTien.Text = qltbal.LayGiaPhong().ToString() + " đ";
                }
                else
                {
                    //tắt nút chuyển đi
                    btnChuyen.Visible = false;
                    //ko có gì thì hóa đơn bằng 0
                    lbTongThanhTien.Text = "0 đ";
                }
            }
        }

        private void lbTitle_Click(object sender, EventArgs e)
        {
            //update danh sách phòng và trạng thái
            dgvPhong.DataSource = qltbal.LoadDGVPhong();
            qltbal.UpdateTrangThaiTatCaPhong();
        }

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            //chuyển trạng thái phòng từ đang đặt cọc sang đang sử dụng
            qltbal.CapNhatTrangThaiPhongSangDangSuDung(qltbal.LayMaPhongTuTenPhong(dgvPhong.Rows[DongDangChon].Cells[0].Value.ToString()));
            dgvPhong.DataSource = qltbal.LoadDGVPhong();
            btnChuyen.Visible = false;
        }
    }
}
