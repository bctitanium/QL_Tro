using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class QLTroDAL : DatabaseService
    {
        public bool CheckAccount(string user, string pass)
        {
            //hàm kiểm tra sự tồn tại của account với username và password là user và pass được nhập vào

            bool kq; //nếu là false thì account không tòn tại, true thì account này đã tồn tại

            try
            {
                //truy vấn vào database để tìm kiếm account
                string sql = "Select UserName, PassWord " +
                    "from Account " +
                    "where UserName = @Username and PassWord = @Password and MaLoai = @ML";
                //2 parameter là username và password do người dùng nhập truyền vào
                SqlParameter parUser = new SqlParameter("@Username", SqlDbType.NVarChar) { Value = user };
                SqlParameter parPass = new SqlParameter("@Password", SqlDbType.NVarChar) { Value = pass };
                SqlParameter parML = new SqlParameter("@ML", SqlDbType.Char) { Value = "L1" };

                //truyền parameter vào để đọc dữ liệu
                if (ReadDataPars(sql, new[] { parUser, parPass, parML }).Read()) //kết quả trả về là true hoặc false
                {
                    //nếu kết quả trả về là true thì tức là đọc dữ liệu thành công
                    //account này đã tòn tại trong database, không thể tạo thêm account với username này

                    kq = true; //cho phép đăng nhập vào account này
                }
                else
                {
                    //nếu kết quả trả về là false thì tức là đọc dữ liệu không thành công
                    //account này không tồn tại trong database, có thể tạo thêm account với username này

                    kq = false; //không cho phép đăng nhập, chỉ có thể tạo mới
                }
            }
            finally
            {
                CloseConnection(); //đóng kết nối
            }

            return kq; //trả về giá trị của kq
        }

        public DataTable LoadDataGridViewPhong()
        {
            //1 bảng cho Admin quản lý phòng

            DataTable dt = new DataTable(); //tạo mới bảng dữ liệu

            string sql = "Select a.TenPhong, b.TrangThai " +
                "from Phong a, LoaiTrangThai b " +
                "where a.MaTT = b.MaTT";
            SqlDataAdapter da = new SqlDataAdapter(sql, connection); //truyền câu truy vấn và kết nối vào cổng kết nối
            da.Fill(dt); //đổ dữ liệu lấy từ câu truy vấn vào bảng

            return dt; //trả về dữ liệu của bảng
        }

        public DataTable LoadDataGridViewKhach()
        {
            //1 bảng cho Admin quản lý khách

            DataTable dt = new DataTable(); //tạo mới bảng dữ liệu

            string sql = "Select a.MaKhach, a.Ten, a.CMND, a.SDT, b.TenPhong " +
                "from Khach a, Phong b " +
                "where a.MaPhong = b.MaPhong";
            SqlDataAdapter da = new SqlDataAdapter(sql, connection); //truyền câu truy vấn và kết nối vào cổng kết nối
            da.Fill(dt); //đổ dữ liệu lấy từ câu truy vấn vào bảng

            return dt; //trả về dữ liệu của bảng
        }

        public string LayMaPhongTuTenPhong(string TenPhong)
        {
            //hàm lấy ra mã phòng từ tên phòng

            string mp = ""; //khởi tạo biến lưu mã phòng

            try
            {
                //câu truy vấn select
                string sql = "Select MaPhong " +
                    "from Phong " +
                    "where TenPhong = @TP";
                //truyền vào parameter
                SqlParameter parTenPhong = new SqlParameter("@TP", SqlDbType.Char) { Value = TenPhong };

                SqlDataReader reader = ReadDataPars(sql, new[] { parTenPhong }); //thực thi đọc dữ liệu

                if (reader.Read()) //nếu đọc được
                {
                    //chắc chắn đọc được chỉ 1 dòng duy nhất
                    mp = reader.GetString(0); //lấy ra dữ liệu từ dòng đọc được
                }
                else
                {
                    //để trống
                }
            }
            finally
            {
                CloseConnection(); //đóng kết nối
            }

            return mp; //trả về tên phòng lấy được từ việc đọc
        }

        public string LayMaHoaDonCuaPhongNaoTuNgayLapLonNhat(string MaPhong)
        {
            //hàm lấy ra mã hóa đơn từ ngày lập

            string mhd = ""; //khởi tạo biến lưu mã phòng

            try
            {
                //câu truy vấn select
                string sql = "Select top 1 a.MaHoaDon " +
                    "from HoaDon a, Khach b, Phong c " +
                    "where a.MaKhach = b.MaKhach and b.MaPhong = c.MaPhong and b.MaPhong = @MP order by a.NgayLap desc";
                //truyền vào parameter
                SqlParameter parMaPhong = new SqlParameter("@MP", SqlDbType.Char) { Value = MaPhong };

                SqlDataReader reader = ReadDataPars(sql, new[] { parMaPhong }); //thực thi đọc dữ liệu

                if (reader.Read()) //nếu đọc được
                {
                    //chắc chắn đọc được chỉ 1 dòng duy nhất
                    mhd = reader.GetString(0); //lấy ra dữ liệu từ dòng đọc được
                }
                else
                {
                    //để trống
                }
            }
            finally
            {
                CloseConnection(); //đóng kết nối
            }

            return mhd; //trả về mã hóa đơn lấy được từ việc đọc
        }

        public DataTable LoadDataGridViewKhachOPhongNao(string MaPhong)
        {
            //1 bảng cho Admin quản lý khách

            DataTable dt = new DataTable(); //tạo mới bảng dữ liệu

            string sql = "Select a.Ten, a.CMND, a.SDT, a.ID " +
                "from Khach a " +
                "where a.MaPhong = @MP";
            SqlDataAdapter da = new SqlDataAdapter(sql, connection); //truyền câu truy vấn và kết nối vào cổng kết nối
            da.SelectCommand.Parameters.Add("@MP", SqlDbType.Char).Value = MaPhong; //thêm parameter do người dùng nhập
            da.Fill(dt); //đổ dữ liệu lấy từ câu truy vấn vào bảng

            return dt; //trả về dữ liệu của bảng
        }

        public DataTable LoadDataGridViewCTHD(string MaPhong, string MaHoaDon)
        {
            //1 bảng cho Admin quản lý khách

            DataTable dt = new DataTable(); //tạo mới bảng dữ liệu

            string sql = "Select a.NgayLap, d.TenDichVu, c.SoCu, c.SoMoi, " +
                "(case d.MaDichVu " +
                    "when 'DV1' then c.SoMoi-c.SoCu " +
                    "when 'DV2' then c.SoMoi-c.SoCu " +
                    "when 'DV3' then 1 " +
                    "when 'DV4' then 1 " +
                    "when 'DV5' then 1 " +
                  "end)  as 'SoLuong' " +
                "from HoaDon a, Khach b, ChiTietHoaDonDV c, DichVu d " +
                "where a.MaKhach = b.MaKhach and a.MaHoaDon = c.MaHoaDon " +
                "and c.MaDichVu = d.MaDichVu and b.MaPhong = @MP and a.MaHoaDon = @MHD";
            SqlDataAdapter da = new SqlDataAdapter(sql, connection); //truyền câu truy vấn và kết nối vào cổng kết nối

            da.SelectCommand.Parameters.Add("@MP", SqlDbType.Char).Value = MaPhong; //thêm parameter do người dùng nhập
            da.SelectCommand.Parameters.Add("@MHD", SqlDbType.Char).Value = MaHoaDon; //thêm parameter do người dùng nhập
            da.Fill(dt); //đổ dữ liệu lấy từ câu truy vấn vào bảng

            return dt; //trả về dữ liệu của bảng
        }

        public string TinhTienTheoHoaDon(string MaHoaDon)
        {
            //hàm tính tiền từ mã hóa đơn

            string tt = ""; //khởi tạo biến lưu tổng số tiền

            try
            {
                //câu truy vấn select
                string sql = "Select dbo.TinhTienCuaHoaDon(@MHD)";
                //truyền vào parameter
                SqlParameter parMHD = new SqlParameter("@MHD", SqlDbType.Char) { Value = MaHoaDon };

                SqlDataReader reader = ReadDataPars(sql, new[] { parMHD }); //thực thi đọc dữ liệu

                if (reader.Read()) //nếu đọc được
                {
                    //chắc chắn đọc được chỉ 1 dòng duy nhất
                    tt = reader.GetInt32(0).ToString(); //lấy ra dữ liệu từ dòng đọc được
                }
                else
                {
                    //để trống
                }
            }
            finally
            {
                CloseConnection(); //đóng kết nối
            }

            return tt; //trả về tổng số tiền lấy được từ việc đọc
        }

        public DataTable LoadDataGridViewMaNV()
        {
            //load mã nhân viên vào combobox

            DataTable dt = new DataTable(); //tạo mới bảng dữ liệu

            string sql = "Select MaNhanVien from NhanVien";
            SqlDataAdapter da = new SqlDataAdapter(sql, connection); //truyền câu truy vấn và kết nối vào cổng kết nối
            da.Fill(dt); //đổ dữ liệu lấy từ câu truy vấn vào bảng

            return dt; //trả về dữ liệu của bảng
        }

        public DataTable LoadDataGridViewMaPhong()
        {
            //load mã phòng vào combobox

            DataTable dt = new DataTable(); //tạo mới bảng dữ liệu

            string sql = "Select MaPhong from Phong where MaTT != @MTT";
            SqlDataAdapter da = new SqlDataAdapter(sql, connection); //truyền câu truy vấn và kết nối vào cổng kết nối
            da.SelectCommand.Parameters.Add("@MTT", SqlDbType.Char).Value = "TT1";
            da.Fill(dt); //đổ dữ liệu lấy từ câu truy vấn vào bảng

            return dt; //trả về dữ liệu của bảng
        }

        public DataTable LoadDataGridViewMaPhongTrong()
        {
            //load mã phòng vào combobox

            DataTable dt = new DataTable(); //tạo mới bảng dữ liệu

            string sql = "Select MaPhong from Phong where MaTT = @MTT";
            SqlDataAdapter da = new SqlDataAdapter(sql, connection); //truyền câu truy vấn và kết nối vào cổng kết nối
            da.SelectCommand.Parameters.Add("@MTT", SqlDbType.Char).Value = "TT1";
            da.Fill(dt); //đổ dữ liệu lấy từ câu truy vấn vào bảng

            return dt; //trả về dữ liệu của bảng
        }

        public string LayMaKhachTuMaPhong(string MaPhong)
        {
            //hàm lấy mã khách từ mã phòng để ghi hóa đơn

            string mk = ""; //khởi tạo biến lưu mã khách

            try
            {
                //câu truy vấn select
                string sql = "Select top 1 a.MaKhach " +
                    "from HoaDon a, Khach b " +
                    "where a.MaKhach = b.MaKhach and b.MaPhong = @MP";
                //truyền vào parameter
                SqlParameter parMaPhong = new SqlParameter("@MP", SqlDbType.Char) { Value = MaPhong };

                SqlDataReader reader = ReadDataPars(sql, new[] { parMaPhong }); //thực thi đọc dữ liệu

                if (reader.Read()) //nếu đọc được
                {
                    //chắc chắn đọc được chỉ 1 dòng duy nhất
                    mk = reader.GetString(0); //lấy ra dữ liệu từ dòng đọc được
                }
                else
                {
                    //để trống
                }
            }
            finally
            {
                CloseConnection(); //đóng kết nối
            }

            return mk; //trả về mã khách lấy được từ việc đọc
        }

        //public string LayMaHoaDonTruocTuMaKhach(string MaKhach)
        //{
        //    //hàm lấy mã hóa đơn trước đó để lấy số điện nước cũ

        //    string mhd = ""; //khởi tạo biến lưu mã hóa đơn

        //    try
        //    {
        //        //câu truy vấn select
        //        string sql = "Select top 1 MaHoaDon " +
        //            "from HoaDon " +
        //            "where MaKhach = @MK and " +
        //            "MaHoaDon < (select top 1 MaHoaDon from HoaDon where MaKhach = @MK order by NgayLap desc) " +
        //            "order by NgayLap desc";
        //        //truyền vào parameter
        //        SqlParameter parMaKhach = new SqlParameter("@MK", SqlDbType.Char) { Value = MaKhach };

        //        SqlDataReader reader = ReadDataPars(sql, new[] { parMaKhach }); //thực thi đọc dữ liệu

        //        if (reader.Read()) //nếu đọc được
        //        {
        //            //chắc chắn đọc được chỉ 1 dòng duy nhất
        //            mhd = reader.GetString(0); //lấy ra dữ liệu từ dòng đọc được
        //        }
        //        else
        //        {
        //            //để trống
        //        }
        //    }
        //    finally
        //    {
        //        CloseConnection(); //đóng kết nối
        //    }

        //    return mhd; //trả về mã hóa đơn lấy được từ việc đọc
        //}

        public int LaySoDien(string MaHoaDon)
        {
            //hàm lấy số điện

            int sd = 0; //khởi tạo biến lưu số điện

            try
            {
                //câu truy vấn select
                string sql = "Select SoMoi " +
                    "from ChiTietHoaDonDV " +
                    "where MaHoaDon = @MHD and MaDichVu = @MDV";
                //truyền vào parameter
                SqlParameter parMHD = new SqlParameter("@MHD", SqlDbType.Char) { Value = MaHoaDon };
                SqlParameter parMDV = new SqlParameter("@MDV", SqlDbType.Char) { Value = "DV1" };

                SqlDataReader reader = ReadDataPars(sql, new[] { parMHD, parMDV }); //thực thi đọc dữ liệu

                if (reader.Read()) //nếu đọc được
                {
                    //chắc chắn đọc được chỉ 1 dòng duy nhất
                    sd = reader.GetInt32(0); //lấy ra dữ liệu từ dòng đọc được
                }
                else
                {
                    //để trống
                }
            }
            finally
            {
                CloseConnection(); //đóng kết nối
            }

            return sd; //trả về số điện lấy được từ việc đọc
        }

        public int LaySoNuoc(string MaHoaDon)
        {
            //hàm lấy số nước

            int sn = 0; //khởi tạo biến lưu số nước

            try
            {
                //câu truy vấn select
                string sql = "Select SoMoi " +
                    "from ChiTietHoaDonDV " +
                    "where MaHoaDon = @MHD and MaDichVu = @MDV";
                //truyền vào parameter
                SqlParameter parMHD = new SqlParameter("@MHD", SqlDbType.Char) { Value = MaHoaDon };
                SqlParameter parMDV = new SqlParameter("@MDV", SqlDbType.Char) { Value = "DV2" };

                SqlDataReader reader = ReadDataPars(sql, new[] { parMHD, parMDV }); //thực thi đọc dữ liệu

                if (reader.Read()) //nếu đọc được
                {
                    //chắc chắn đọc được chỉ 1 dòng duy nhất
                    sn = reader.GetInt32(0); //lấy ra dữ liệu từ dòng đọc được
                }
                else
                {
                    //để trống
                }
            }
            finally
            {
                CloseConnection(); //đóng kết nối
            }

            return sn; //trả về số nước lấy được từ việc đọc
        }

        public bool LapHoaDon(string MaHoaDon, DateTime NgayLap, string MaNV, string MaKhach)
        {
            //hàm lập hóa đơn

            bool kq; //nếu là false thì không lập được, nếu là true thì lập được

            try
            {
                string sql = "Insert into HoaDon(MaHoaDon, NgayLap, MaNhanVien, MaKhach) values(@MHD, @NL, @MNV, @MK)";

                SqlParameter parMaHoaDon = new SqlParameter("@MHD", SqlDbType.Char) { Value = MaHoaDon };
                SqlParameter parNgayLap = new SqlParameter("@NL", SqlDbType.Date) { Value = NgayLap };
                SqlParameter parMaNhanVien = new SqlParameter("@MNV", SqlDbType.Char) { Value = MaNV };
                SqlParameter parMaKhach = new SqlParameter("@MK", SqlDbType.Char) { Value = MaKhach };

                //truyền parameter vào để đọc dữ liệu
                if (WriteDataPars(sql, new[] { parMaHoaDon, parNgayLap, parMaNhanVien, parMaKhach })) //kết quả trả về là true hoặc false
                {
                    kq = true; //lập thành công
                }
                else
                {
                    kq = false; //lập không thành công
                }
            }
            finally
            {
                CloseConnection(); //đóng kết nối
            }

            return kq; //trả về giá trị của kq
        }

        public bool LapChiTietHoaDon(string MaHoaDon, int SoDienCu, int SoDienMoi, int SoNuocCu, int SoNuocMoi)
        {
            //hàm lập hóa đơn

            bool kq; //nếu là false thì không lập được, nếu là true thì lập được

            try
            {
                string sql = "Insert into ChiTietHoaDonDV(MaHoaDon, MaDichVu, SoCu, SoMoi) values(@MHD, @MDV1, @SDC, @SDM) " +
                    "Insert into ChiTietHoaDonDV(MaHoaDon, MaDichVu, SoCu, SoMoi) values(@MHD, @MDV2, @SNC, @SNM) " +
                    "Insert into ChiTietHoaDonDV(MaHoaDon, MaDichVu, SoCu, SoMoi) values(@MHD, @MDV3, @SoGiongNhau, @SoGiongNhau) " +
                    "Insert into ChiTietHoaDonDV(MaHoaDon, MaDichVu, SoCu, SoMoi) values(@MHD, @MDV4, @SoGiongNhau, @SoGiongNhau) " +
                    "Insert into ChiTietHoaDonDV(MaHoaDon, MaDichVu, SoCu, SoMoi) values(@MHD, @MDV5, @SoGiongNhau, @SoGiongNhau)";

                SqlParameter parMaHoaDon = new SqlParameter("@MHD", SqlDbType.Char) { Value = MaHoaDon };

                SqlParameter parDichVu1 = new SqlParameter("@MDV1", SqlDbType.Char) { Value = "DV1" };
                SqlParameter parDichVu2 = new SqlParameter("@MDV2", SqlDbType.Char) { Value = "DV2" };
                SqlParameter parDichVu3 = new SqlParameter("@MDV3", SqlDbType.Char) { Value = "DV3" };
                SqlParameter parDichVu4 = new SqlParameter("@MDV4", SqlDbType.Char) { Value = "DV4" };
                SqlParameter parDichVu5 = new SqlParameter("@MDV5", SqlDbType.Char) { Value = "DV5" };

                SqlParameter parSoDienCu = new SqlParameter("@SDC", SqlDbType.Int) { Value = SoDienCu };
                SqlParameter parSoDienMoi = new SqlParameter("@SDM", SqlDbType.Int) { Value = SoDienMoi };
                SqlParameter parSoNuocCu = new SqlParameter("@SNC", SqlDbType.Int) { Value = SoNuocCu };
                SqlParameter parSoNuocMoi = new SqlParameter("@SNM", SqlDbType.Int) { Value = SoNuocMoi };

                SqlParameter parSoGiongNhau = new SqlParameter("SoGiongNhau", SqlDbType.Int) { Value = 1 };

                //truyền parameter vào để đọc dữ liệu
                if (WriteDataPars(sql, new[] { parMaHoaDon, parDichVu1, parDichVu2, parDichVu3, parDichVu4, parDichVu5, 
                    parSoDienCu, parSoDienMoi, parSoNuocCu, parSoNuocMoi, parSoGiongNhau })) //kết quả trả về là true hoặc false
                {
                    kq = true; //lập thành công
                }
                else
                {
                    kq = false; //lập không thành công
                }
            }
            finally
            {
                CloseConnection(); //đóng kết nối
            }

            return kq; //trả về giá trị của kq
        }

        public bool ThemKhach(string MaKhach, string Ten, string CMND, string SDT, string MaPhong)
        {
            //hàm thêm khách

            bool kq; //nếu là false thì không lập được, nếu là true thì lập được

            try
            {
                string sql = "Insert into Khach(MaKhach, Ten, CMND, SDT, MaPhong) values(@MK, @Ten, @CMND, @SDT, @MP)";

                SqlParameter parMaKhach = new SqlParameter("@MK", SqlDbType.Char) { Value =  MaKhach};
                SqlParameter parTen = new SqlParameter("@Ten", SqlDbType.NVarChar) { Value = Ten };
                SqlParameter parCMND = new SqlParameter("@CMND", SqlDbType.Text) { Value = CMND };
                SqlParameter parSDT = new SqlParameter("@SDT", SqlDbType.Text) { Value = SDT };
                SqlParameter parMaPhong = new SqlParameter("@MP", SqlDbType.Char) { Value = MaPhong };

                //truyền parameter vào để đọc dữ liệu
                if (WriteDataPars(sql, new[] { parMaKhach, parTen, parCMND, parSDT, parMaPhong })) //kết quả trả về là true hoặc false
                {
                    kq = true; //lập thành công
                }
                else
                {
                    kq = false; //lập không thành công
                }
            }
            finally
            {
                CloseConnection(); //đóng kết nối
            }

            return kq; //trả về giá trị của kq
        }

        public bool CapNhatTrangThaiPhongSangDatCoc(string MaPhong)
        {
            //hàm cập nhật trạng thái phòng sang đang đặt cọc

            bool kq; //nếu là false thì không lập được, nếu là true thì lập được

            try
            {
                string sql = "Update Phong set MaTT = @MaTT where MaPhong = @MP";

                SqlParameter parMaTT = new SqlParameter("@MaTT", SqlDbType.Char) { Value = "TT3" };
                SqlParameter parMaPhong = new SqlParameter("@MP", SqlDbType.Char) { Value = MaPhong };

                //truyền parameter vào để đọc dữ liệu
                if (WriteDataPars(sql, new[] { parMaTT, parMaPhong })) //kết quả trả về là true hoặc false
                {
                    kq = true; //lập thành công
                }
                else
                {
                    kq = false; //lập không thành công
                }
            }
            finally
            {
                CloseConnection(); //đóng kết nối
            }

            return kq; //trả về giá trị của kq
        }

        public bool CapNhatTrangThaiPhongSangDangSuDung(string MaPhong)
        {
            //hàm cập nhật trạng thái phòng sang đang sử dụng

            bool kq; //nếu là false thì không lập được, nếu là true thì lập được

            try
            {
                string sql = "Update Phong set MaTT = @MaTT where MaPhong = @MP";

                SqlParameter parMaTT = new SqlParameter("@MaTT", SqlDbType.Char) { Value = "TT2" };
                SqlParameter parMaPhong = new SqlParameter("@MP", SqlDbType.Char) { Value = MaPhong };

                //truyền parameter vào để đọc dữ liệu
                if (WriteDataPars(sql, new[] { parMaTT, parMaPhong })) //kết quả trả về là true hoặc false
                {
                    kq = true; //lập thành công
                }
                else
                {
                    kq = false; //lập không thành công
                }
            }
            finally
            {
                CloseConnection(); //đóng kết nối
            }

            return kq; //trả về giá trị của kq
        }

        public bool LapPhieuDatPhong(string MaKhach, string Ten, string CMND, string SDT, string MaPhong, 
            string MaPDP, DateTime NgayDat, string MaNV, string MaHD, DateTime NgayTra)
        {
            //hàm lập phiếu đặt phòng

            bool kq; //nếu là false thì không lập được, nếu là true thì lập được

            try
            {
                string sql = "Insert into Khach(MaKhach, Ten, CMND, SDT, MaPhong) values(@MK, @Ten, @CMND, @SDT, @MP) " +
                    "Insert into PhieuDatPhong(MaPhieuDatPhong, NgayDat, MaNhanVien, MaKhach) values(@MaPDP, @NgayDat, @MaNV, @MK) " +
                    "Insert into HoaDon(MaHoaDon, NgayLap, MaNhanVien, MaKhach) values(@MaHD, @NgayDat, @MaNV, @MK) " +
                    "Insert into ChiTietPhieuDatPhong(MaPhong, MaPhieuDatPhong, MaHoaDon, NgayTraPhong) values(@MP, @MaPDP, @MaHD, @NgayTra)";

                SqlParameter parMaKhach = new SqlParameter("@MK", SqlDbType.Char) { Value = MaKhach };
                SqlParameter parTen = new SqlParameter("@Ten", SqlDbType.NVarChar) { Value = Ten };
                SqlParameter parCMND = new SqlParameter("@CMND", SqlDbType.Text) { Value = CMND };
                SqlParameter parSDT = new SqlParameter("@SDT", SqlDbType.Text) { Value = SDT };
                SqlParameter parMaPhong = new SqlParameter("@MP", SqlDbType.Char) { Value = MaPhong };
                SqlParameter parMaPDP = new SqlParameter("@MaPDP", SqlDbType.Char) { Value = MaPDP };
                SqlParameter parNgayDat = new SqlParameter("@NgayDat", SqlDbType.Date) { Value = NgayDat };
                SqlParameter parMaNV = new SqlParameter("@MaNV", SqlDbType.Char) { Value = MaNV };
                SqlParameter parMaHD = new SqlParameter("@MaHD", SqlDbType.Char) { Value = MaHD };
                SqlParameter parNgayTra = new SqlParameter("@NgayTra", SqlDbType.Date) { Value = NgayTra };

                //truyền parameter vào để đọc dữ liệu
                if (WriteDataPars(sql, new[] { parMaKhach, parTen, parCMND, parSDT, parMaPhong, parMaPDP, parNgayDat, parMaNV, parMaHD, parNgayTra })) //kết quả trả về là true hoặc false
                {
                    kq = true; //lập thành công
                }
                else
                {
                    kq = false; //lập không thành công
                }
            }
            finally
            {
                CloseConnection(); //đóng kết nối
            }

            return kq; //trả về giá trị của kq
        }

        public string LayMaHoaDonLonNhat()
        {
            //hàm lấy mã hóa đơn lớn nhất

            string mhd = ""; //khởi tạo biến lưu mã hd

            try
            {
                //câu truy vấn select
                string sql = "Select CONCAT('HD', MAX(CONVERT(int, SUBSTRING(MaHoaDon, 3, LEN(MaHoaDon))))) from HoaDon";

                SqlDataReader reader = ReadData(sql); //thực thi đọc dữ liệu

                if (reader.Read()) //nếu đọc được
                {
                    //chắc chắn đọc được chỉ 1 dòng duy nhất
                    mhd = reader.GetString(0); //lấy ra dữ liệu từ dòng đọc được
                }
                else
                {
                    //để trống
                }
            }
            finally
            {
                CloseConnection(); //đóng kết nối
            }

            return mhd; //trả về mã hd lấy được từ việc đọc
        }

        public string LayMaKhachLonNhat()
        {
            //hàm lấy mã khách lớn nhất

            string mk = ""; //khởi tạo biến lưu mã khách

            try
            {
                //câu truy vấn select
                string sql = "Select CONCAT('MK', MAX(CONVERT(int, SUBSTRING(MaKhach, 3, LEN(MaKhach))))) from Khach";

                SqlDataReader reader = ReadData(sql); //thực thi đọc dữ liệu

                if (reader.Read()) //nếu đọc được
                {
                    //chắc chắn đọc được chỉ 1 dòng duy nhất
                    mk = reader.GetString(0); //lấy ra dữ liệu từ dòng đọc được
                }
                else
                {
                    //để trống
                }
            }
            finally
            {
                CloseConnection(); //đóng kết nối
            }

            return mk; //trả về mã khách lấy được từ việc đọc
        }

        public string LayMaPhieuDatPhongLonNhat()
        {
            //hàm lấy pdp lớn nhất

            string mpdp = ""; //khởi tạo biến lưu mã pdp

            try
            {
                //câu truy vấn select
                string sql = "Select CONCAT('PDP', MAX(CONVERT(int, SUBSTRING(MaPhieuDatPhong, 4, LEN(MaPhieuDatPhong))))) from PhieuDatPhong";

                SqlDataReader reader = ReadData(sql); //thực thi đọc dữ liệu

                if (reader.Read()) //nếu đọc được
                {
                    //chắc chắn đọc được chỉ 1 dòng duy nhất
                    mpdp = reader.GetString(0); //lấy ra dữ liệu từ dòng đọc được
                }
                else
                {
                    //để trống
                }
            }
            finally
            {
                CloseConnection(); //đóng kết nối
            }

            return mpdp; //trả về mã pdp lấy được từ việc đọc
        }

        public string LayThongBao()
        {
            //hàm lấy thông báo

            string tb = ""; //khởi tạo biến lưu thông báo

            try
            {
                //câu truy vấn select
                string sql = "Select top 1 NoiDung from ThongBao order by STT desc";

                SqlDataReader reader = ReadData(sql); //thực thi đọc dữ liệu

                if (reader.Read()) //nếu đọc được
                {
                    //chắc chắn đọc được chỉ 1 dòng duy nhất
                    tb = reader.GetString(0); //lấy ra dữ liệu từ dòng đọc được
                }
                else
                {
                    //để trống
                }
            }
            finally
            {
                CloseConnection(); //đóng kết nối
            }

            return tb; //trả về thông báo lấy được từ việc đọc
        }

        public bool DangThongBao(string NoiDung)
        {
            //hàm đăng thông báo

            bool kq; //nếu là false thì không lập được, nếu là true thì lập được

            try
            {
                string sql = "Insert into ThongBao(NoiDung) values(@ND)";

                SqlParameter parNoiDung = new SqlParameter("@ND", SqlDbType.NText) { Value =  NoiDung};

                //truyền parameter vào để đọc dữ liệu
                if (WriteDataPars(sql, new[] { parNoiDung })) //kết quả trả về là true hoặc false
                {
                    kq = true; //lập thành công
                }
                else
                {
                    kq = false; //lập không thành công
                }
            }
            finally
            {
                CloseConnection(); //đóng kết nối
            }

            return kq; //trả về giá trị của kq
        }

        public int LayGiaPhong()
        {
            //hàm lấy giá phòng

            int gp = 0; //khởi tạo biến lưu thông báo

            try
            {
                //câu truy vấn select
                string sql = "Select TienDichVu from DichVu where MaDichVu = @MaDV";

                SqlParameter parMaDichVu = new SqlParameter("@MaDV", SqlDbType.Char) { Value = "DV5" };

                SqlDataReader reader = ReadDataPars(sql, new[] { parMaDichVu }); //thực thi đọc dữ liệu

                if (reader.Read()) //nếu đọc được
                {
                    //chắc chắn đọc được chỉ 1 dòng duy nhất
                    gp = (int)reader.GetSqlMoney(0); //lấy ra dữ liệu từ dòng đọc được
                }
                else
                {
                    //để trống
                }
            }
            finally
            {
                CloseConnection(); //đóng kết nối
            }

            return gp; //trả về giá phòng lấy được từ việc đọc
        }

        public bool UpdateTrangThaiTatCaPhong()
        {
            //hàm cập nhật trạng thái tất cả các phòng và trạng thái

            bool kq; //nếu là false thì không lập được, nếu là true thì lập được

            try
            {
                string sql = "Update Phong set MaTT = @MTT " +
                    "where MaPhong in (select MaPhong from Phong where MaPhong not in (select MaPhong from Khach))";

                SqlParameter parMaTT = new SqlParameter("@MTT", SqlDbType.Char) { Value = "TT1" };

                //truyền parameter vào để đọc dữ liệu
                if (WriteDataPars(sql, new[] { parMaTT })) //kết quả trả về là true hoặc false
                {
                    kq = true; //lập thành công
                }
                else
                {
                    kq = false; //lập không thành công
                }
            }
            finally
            {
                CloseConnection(); //đóng kết nối
            }

            return kq; //trả về giá trị của kq
        }
    }
}
