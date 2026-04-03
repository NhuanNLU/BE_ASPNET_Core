using System.Collections;

public class Program
{
    public static void Main(string[] args)
    {
        var employeerManaget = new BE.DataAccess.Employeer_Manager();
        var result = employeerManaget.EmployeerInsert("NV001", "bla", DateTime.Now);
        switch (result)
        {
            case (int)BE.DataAccess.@enum.EmployeerManagerStatus.DA_TON_TAI:
                Console.WriteLine("Nhân viên đã tồn tại.");
                break;
            case (int)BE.DataAccess.@enum.EmployeerManagerStatus.THANH_CONG:
                Console.WriteLine("Thêm nhân viên thành công.");

                break;
            case (int)BE.DataAccess.@enum.EmployeerManagerStatus.TEN_KHONG_HOP_LE:
                Console.WriteLine("Tên nhân viên không hợp lệ.");
                break;
            case (int)BE.DataAccess.@enum.EmployeerManagerStatus.MA_NHAN_VIEN_KHONG_HOP_LE:
                Console.WriteLine("Mã nhân viên không hợp lệ.");
                break;
        }
        //Dictionary:(hàm băm) lưu trữ key và value giống map
        Dictionary<string, string> _phoneBook = new Dictionary<string, string>()
        {
            {"NV001", "Nguyen Van A" },
            { "NV002", "Nguyen Van B"  },
        };
        foreach(KeyValuePair<string, string> entry in _phoneBook)
        {
            Console.WriteLine($"key: {entry.Key}, value: {entry.Value}");
        }
        //ArrayList: Lưu trữ dữ liệu, truy xuất phần tử qua index, có hỗ trợ phương thức thêm, xóa, sửa phần tử
        ArrayList arrList = new ArrayList();
        arrList.Add(1);
        arrList.Add("Nhuan");
        arrList.Add(true);
        foreach (var item in arrList)
        {
            Console.WriteLine(item);
        }
        //HashTable: Lưu trữ dữ liệu với key và value, có hỗ trợ phương thức thêm, xóa, sửa phần tử
        //SortedList: Lưu trữ dữ liệu với key và value, có hỗ trợ phương thức thêm, xóa, sửa phần tử, 
        //có thể xắp xếp theo key, Có thể truy xuất phần tử qua key giống HashTable và qua index giống ArrayList
        //Stack: Lưu trữ dữ liệu theo nguyên tắc LIFO (Last In First Out), có hỗ trợ phương thức thêm, xóa phần tử

        //SOLID Patten: 5 nguyên lý thiết kế cơ bản trong lập trình hướng đối tượng. 
        //Giúp lập trình viên viết ra những đoạn code dễ đọc, dễ bảo trì, dễ mở rộng, hạn chế tối đa lỗi
        //khi hệ thống phát triển lớn hơn.
        /*
        1. Single Responsibility Principle (SRP): Nguyên trách nhiệm đơn lẻ
        - Một class chỉ nên thực hiện 1 công việc, thay vì nhiều việc trong một class
        - VD dùng Abs hoặc interface để tách riêng các chức năng ra khỏi class chính.
        2. Open/Closed Principle (OCP): Nguyên lý mở/đóng
        - Khi xuất hiện tính năng mới không sửa vào các class cũ, bắt buộc phải tạo class mới để kế thừa class cũ
        3. Liskov Substitution Principle (LSP): Nguyên lý phân vùng Liskov
        - Các đối tượng trong lớp con phải có khả năng thay thế các đối tượng của lớp cha
          mà không làm thay đổi tính đúng đắn của chương trình
        4. Interface Segregation Principle (ISP): Nguyên lý phân tách interface
        - Nếu interface quá lớn thì nên tách ra các interface nhỏ hơn, với nhiều mục đích cụ thể
        5. Dependency Inversion Principle (DIP): Nguyên lý giảm bớt sự phụ thuộc trực tiếp
        - Dùng Abstraction 
         */

        //Refactor code: 
        /*
         Cải thiện thiết kế hệ thống
         Giúp chương trình dễ hiểu hơn
         Giúp dễ tìm lỗi
         Code nhanh hơn
         Dễ bảo trì
         */
    }
}   