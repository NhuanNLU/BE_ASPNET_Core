public class Program
{
    public static void Main(string[] args)
    {
        var employeerManaget = new BE.DataAccess.Employeer_Manager();
        var result = employeerManaget.EmployeerInsert("NV001", "John Doe", DateTime.Now);
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
    }
}