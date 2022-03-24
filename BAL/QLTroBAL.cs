using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BAL
{
    public class QLTroBAL
    {
        QLTroDAL qltdal = new QLTroDAL();

        public bool CheckAccount(string user, string pass)
        {
            //hàm kiểm tra sự tồn tại của account với username và password là user và pass được nhập vào

            bool kq; //nếu là false thì account không tòn tại, true thì account này đã tồn tại

            if (qltdal.CheckAccount(user, pass))
            {
                kq = true; //tồn tại account này, cho phép đăng nhập
            }
            else
            {
                kq = false; //không tồn tại account này, thông báo đăng nhập thất bại
            }

            return kq; //trả về kết quả của kq
        }

        public System.Data.DataTable LoadDGVPhong()
        {
            return qltdal.LoadDataGridViewPhong(); //load dữ liệu lên datagridview
        }

        public System.Data.DataTable LoadDGVKhach()
        {
            return qltdal.LoadDataGridViewKhach(); //load dữ liệu lên datagridview
        }

        public string LayMaPhongTuTenPhong(string TenPhong)
        {
            return qltdal.LayMaPhongTuTenPhong(TenPhong); //load dữ liệu lên datagridview
        }

        public string LayMHDTuNgayLap(string MaPhong)
        {
            return qltdal.LayMaHoaDonCuaPhongNaoTuNgayLapLonNhat(MaPhong);
        }

        public System.Data.DataTable LoadDGVKhachOPhongNao(string MaPhong)
        {
            return qltdal.LoadDataGridViewKhachOPhongNao(MaPhong);
        }

        public System.Data.DataTable LoadDGVCTHD(string MaPhong, string MaHoaDon)
        {
            return qltdal.LoadDataGridViewCTHD(MaPhong, MaHoaDon);
        }

        public string TinhTienTheoHoaDon(string MaHoaDon)
        {
            return qltdal.TinhTienTheoHoaDon(MaHoaDon);
        }

        public System.Data.DataTable LoadDGVMaNV()
        {
            return qltdal.LoadDataGridViewMaNV();
        }

        public System.Data.DataTable LoadDGVMP()
        {
            return qltdal.LoadDataGridViewMaPhong();
        }

        public System.Data.DataTable LoadDGVMPTrong()
        {
            return qltdal.LoadDataGridViewMaPhongTrong();
        }

        public string LayMKTuMP(string MaPhong)
        {
            return qltdal.LayMaKhachTuMaPhong(MaPhong);
        }

        //public string LayMHDCuTuMK(string MaKhach)
        //{
        //    return qltdal.LayMaHoaDonTruocTuMaKhach(MaKhach);
        //}

        public int LaySoDien(string MaHoaDon)
        {
            return qltdal.LaySoDien(MaHoaDon);
        }

        public int LaySoNuoc(string MaHoaDon)
        {
            return qltdal.LaySoNuoc(MaHoaDon);
        }

        public bool LapHoaDon(string MaHoaDon, DateTime NgayLap, string MaNV, string MaKhach)
        {
            bool kq; //nếu là false thì không lập được, nếu là true thì lập được

            if (qltdal.LapHoaDon(MaHoaDon, NgayLap, MaNV, MaKhach))
            {
                kq = true; //lập thành công
            }
            else
            {
                kq = false; //lập không thành công
            }

            return kq; //trả về kết quả của kq
        }

        public bool LapChiTietHoaDon(string MaHoaDon, int SoDienCu, int SoDienMoi, int SoNuocCu, int SoNuocMoi)
        {
            bool kq; //nếu là false thì không lập được, nếu là true thì lập được

            if (qltdal.LapChiTietHoaDon(MaHoaDon, SoDienCu, SoDienMoi, SoNuocCu, SoNuocMoi))
            {
                kq = true; //lập thành công
            }
            else
            {
                kq = false; //lập không thành công
            }

            return kq; //trả về kết quả của kq
        }

        public bool ThemKhach(string MaKhach, string Ten, string CMND, string SDT, string MaPhong)
        {
            bool kq; //nếu là false thì không lập được, nếu là true thì lập được

            if (qltdal.ThemKhach(MaKhach, Ten, CMND, SDT, MaPhong))
            {
                kq = true; //lập thành công
            }
            else
            {
                kq = false; //lập không thành công
            }

            return kq; //trả về kết quả của kq
        }
        
        public bool CapNhatTrangThaiPhongSangDatCoc(string MaPhong)
        {
            bool kq; //nếu là false thì không lập được, nếu là true thì lập được

            if (qltdal.CapNhatTrangThaiPhongSangDatCoc(MaPhong))
            {
                kq = true; //lập thành công
            }
            else
            {
                kq = false; //lập không thành công
            }

            return kq; //trả về kết quả của kq
        }

        public bool CapNhatTrangThaiPhongSangDangSuDung(string MaPhong)
        {
            bool kq; //nếu là false thì không lập được, nếu là true thì lập được

            if (qltdal.CapNhatTrangThaiPhongSangDangSuDung(MaPhong))
            {
                kq = true; //lập thành công
            }
            else
            {
                kq = false; //lập không thành công
            }

            return kq; //trả về kết quả của kq
        }

        public bool LapPhieuDatPhong(string MaKhach, string Ten, string CMND, string SDT, string MaPhong, 
            string MaPDP, DateTime NgayDat, string MaNV, string MaHD, DateTime NgayTra)
        {
            bool kq; //nếu là false thì không lập được, nếu là true thì lập được

            if (qltdal.LapPhieuDatPhong(MaKhach, Ten, CMND, SDT, MaPhong, MaPDP, NgayDat, MaNV, MaHD, NgayTra))
            {
                kq = true; //lập thành công
            }
            else
            {
                kq = false; //lập không thành công
            }

            return kq; //trả về kết quả của kq
        }

        public string LayMHDLonNhat()
        {
            return qltdal.LayMaHoaDonLonNhat();
        }

        public string LayMKLonNhat()
        {
            return qltdal.LayMaKhachLonNhat();
        }

        public string LayMPDPLonNhat()
        {
            return qltdal.LayMaPhieuDatPhongLonNhat();
        }

        public string LayThongBao()
        {
            return qltdal.LayThongBao();
        }

        public bool DangThongBao(string NoiDung)
        {
            bool kq; //nếu là false thì không lập được, nếu là true thì lập được

            if (qltdal.DangThongBao(NoiDung))
            {
                kq = true; //lập thành công
            }
            else
            {
                kq = false; //lập không thành công
            }

            return kq; //trả về kết quả của kq
        }

        public bool UpdateTrangThaiTatCaPhong()
        {
            bool kq; //nếu là false thì không lập được, nếu là true thì lập được

            if (qltdal.UpdateTrangThaiTatCaPhong())
            {
                kq = true; //lập thành công
            }
            else
            {
                kq = false; //lập không thành công
            }

            return kq; //trả về kết quả của kq
        }

        public int LayGiaPhong()
        {
            return qltdal.LayGiaPhong();
        }
    }
}
