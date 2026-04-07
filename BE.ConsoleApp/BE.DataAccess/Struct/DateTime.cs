using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.DataAccess.Struct
{
    internal class DateTime 
    {
        //Bản chất của DateTime là một struct trong .NET,
        //nó đã được định nghĩa sẵn trong System namespace.\
        //string là một kiểu dữ liệu tham chiếu (reference type) để lưu trữ chuỗi ký tự
        //Phù hợp với tính năng xử lý chuỗi, remove, splip, biến chuỗi thành 1 mảng
        //Length lấy số lượng ký tự của đối tượng string hiện tại
        //StringBuilder: thao tác trực tiếp trên chuỗi ban đầu, 
        //có khả năng mở rộng vùng nhớ khi cần thiết,
        //không cho phép lớp khác kế thừa
        //StringBuilder phù hợp với gán và nối chuỗi, xóa bỏ ký tự

        //Generic: là một tính năng trong C# cho phép bạn định nghĩa các lớp, phương thức,
        //cấu trúc dữ liệu mà không cần chỉ định kiểu dữ liệu cụ thể.      
        public T sum<T>(T a, T b) where T : struct
        {
            dynamic x = a;
            dynamic y = b;
            return x + y;
        }

        public static implicit operator DateTime(System.DateTime v)
        {
            throw new NotImplementedException();
        }
    }
}
