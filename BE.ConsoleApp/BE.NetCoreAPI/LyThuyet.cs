namespace BE.NetCoreAPI
{
    public class LyThuyet
    {
        /*
        http protocol để gửi nhận dữ liệu giữa client và server
        dữ liệu ở đây có thể là json, xml, text, html, v.v... nhưng phổ biến nhất là json
        http và https khác nhau gì?
         - http là giao thức truyền tải dữ liệu không được mã hóa, 
            trong khi https là giao thức truyền tải dữ liệu được mã hóa bằng SSL/TLS. 
            Điều này có nghĩa là khi sử dụng https, 
            dữ liệu giữa client và server sẽ được bảo vệ khỏi việc bị nghe lén hoặc thay đổi bởi bên thứ ba.
        client giữ public key, server giữ private key,
        Khi dữ liệu được gửi từ client đến server, nó sẽ dùng private key và public key để mã hóa dữ liệu,
        Nên khi hacker có lấy được dữ liệu nó không có private key để giải mã dữ liệu đó
        ngoài mã hóa password còn có thể mã hóa stk 
         */

        /*
        Middleware là một model code có nhận Request và trả Response
        Bản chất nó chỉ là các class Dùng để check Request
        Nhận Http Response, sửa nó và chuyển đến Middleware khác
        Các Middleware được gọi theo thứ tự trong pipeline
         */
    }
}
  