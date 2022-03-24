using System.Data.SqlClient;

namespace DAL
{
    public class DatabaseService
    {
        public const string connectionString = "Data Source = BC; Initial Catalog = QLTro; Integrated Security = True"; //khởi tạo hằng lưu chuõi kết nối
        
        public SqlConnection connection; //biến này dùng để nhận chuỗi kết nối
        public SqlCommand command; //tạo ra biến dùng để sử dụng các câu lệnh

        public DatabaseService()
        {
            connection = new SqlConnection(connectionString); //tạo chuỗi kết nối mới
        }

        public void OpenConnection()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Closed)
            {
                //chuỗi kết nối phải khác rỗng (tồn tại)
                //nếu có kết nối và kết nối đó đang đóng thì mở
                connection.Open();
            }
            else
            {
                //không làm gì
            }
        }

        public void CloseConnection()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                //chuỗi kết nối phải khác rỗng (tồn tại)
                //nếu có kết nối và kết nối đó đang mở thì đóng
                connection.Close();
            }
            else
            {
                //không làm gì
            }
        }

        public SqlDataReader ReadData(string sql)
        {
            command = new SqlCommand(); //reset cho nó như mới, không chứa lệnh
            command.CommandType = System.Data.CommandType.Text; //dạng command là text để chứa câu truy vấn (dạng của câu truy vấn là text)
            command.CommandText = sql; //chuỗi câu truy vấn là chuỗi truyền vào hàm
            command.Connection = connection; //chuỗi kết nối được khai báo trên đầu
            OpenConnection(); //mở kết nối để đọc dữ liệu
            SqlDataReader reader = command.ExecuteReader(); //thực thi cho câu truy vấn "Select"
            return reader; //trả về kiểu dữ liệu là SqlDataReader
        }

        public SqlDataReader ReadDataPars(string sql, SqlParameter[] pars)
        {
            //giải quyết câu truy vấn có parameter, có dấu vidu=@vidu
            command = new SqlCommand(); //reset cho nó như mới, không chứa lệnh
            command.CommandType = System.Data.CommandType.Text; //dạng command là text để chứa câu truy vấn (dạng của câu truy vấn là text)
            command.CommandText = sql; //chuỗi câu truy vấn là chuỗi truyền vào hàm
            command.Connection = connection; //chuỗi kết nối được khai báo trên đầu
            OpenConnection(); //mở kết nối để đọc dữ liệu
            command.Parameters.AddRange(pars); //thêm vào các parameter được truyền vào hàm
            SqlDataReader reader = command.ExecuteReader(); //thực thi cho câu truy vấn "Select"
            return reader; //trả về kiểu dữ liệu là SqlDataReader
        }

        public bool WriteDataPars(string sql, SqlParameter[] pars)
        {
            //dùng cho update, insert, delete
            command = new SqlCommand(); //reset cho nó như mới, không chứa lệnh
            command.CommandType = System.Data.CommandType.Text; //dạng command là text để chứa câu truy vấn (dạng của câu truy vấn là text)
            command.CommandText = sql; //chuỗi câu truy vấn là chuỗi truyền vào hàm
            command.Connection = connection; //chuỗi kết nối được khai báo trên đầu
            OpenConnection(); //mở kết nối để ghi dữ liệu
            command.Parameters.AddRange(pars); //thêm vào các parameter được truyền vào hàm

            //vì ExecuteNonQuery trả về kiểu int nên khi khác 0 tức là có dòng dữ liệu được thêm, sửa, xoá hay được cập nhật
            //còn nếu trả về là 0 thì tức là KHÔNG có dòng dữ liệu được thêm, sửa, xoá hay được cập nhật
            if (command.ExecuteNonQuery() != 0)
            {
                //nếu như ghi được dữ liệu thì trả về true, thông báo ghi dữ liệu thành công
                //tức là có sự thay đổi về số dòng hoặc có dòng bị ảnh hưởng, bị thay đổi
                return true;
            }
            else
            {
                //nếu như không ghi được dữ liệu thì trả về false, thông báo ghi dữ liệu không thành công
                return false;
            }
        }
    }
}