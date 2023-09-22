using System;

namespace MyApp
{
    public class Program
    {
        /*
            this là biến tham chiếu
            nó được sử dụng để tham chiếu đến đối tượng
            của lớp hiện tại

            => lớp hiện tại ở đây là lớp Program
            
            mặc dù đối tượng hiện tại không được khai báo
            nhưng biến tham chiếu this vẫn tham chiếu được
            => thế mới tài (ồ ngạc nhiên luôn)

            vì vậy chúng ta có thể sử dụng các thuộc tính
            trong lớp Program

            còn về từ khóa static, nếu bạn viết thuộc tính nào
            có chữ static thì bạn không cần dùng this
            => vì biến static không phụ thuộc vào đối tượng
            => đã không phụ thuộc vào đối tượng thì khỏi cần dùng this luôn
        */


        // tạo 1 thuộc tính
        // để có cơ hội sử dụng
        // biến tham chiếu this
        // tôi cố tình không dùng từ khóa static
        // => để có thể dùng "this"
        public string thong_bao = "Welcome to C#";


        // viết như này
        // thì cũng bị báo lỗi
        // muốn hết lỗi thì bỏ từ khóa static đi
        // vì nó liên quan đến ngữ cảnh làm việc của biến tham chiếu this
        // public static void InRa_ManHinh()
        // {
        //     Console.WriteLine(this.thong_bao);
        // }


        // in ra màn hình
        public void InRa_ManHinh()
        {
            /*
                cái biến tham chiếu this
                nó có thể trông như thế này
                
                tôi đã comment code lại
                tôi chỉ viết vậy để bạn cũng có thể
                cảm nhận ra câu hỏi "this" là gì
            */
            // Program doi_tuong = new Program();
            // Program this = doi_tuong;


            // thay vì phải tạo 1 đối tượng
            // rồi gọi thuộc tính thong_bao
            // thì ta chỉ cần viết this.thong_bao
            Console.WriteLine(this.thong_bao);
        }


        public void InRa_ManHinh2()
        {
            // tạo đối tượng
            // để sử dụng thong_bao
            Program doi_tuong = new Program();

            Console.WriteLine(doi_tuong.thong_bao);
        }


        public static void Main(string[] args)
        {
            // nếu viết như này thì bị báo lỗi
            // Console.WriteLine(this.thong_bao);


            // tạo đối tượng
            Program dt = new Program();


            // gọi phương thức InRa_ManHinh()
            Console.WriteLine("Su dung \"this\":");
            dt.InRa_ManHinh();


            // gọi phương thức InRa_ManHinh2()
            Console.WriteLine("\nSu dung \"doi tuong\":");
            dt.InRa_ManHinh2();
        }
    }
}