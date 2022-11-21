// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
namespace ConsoleApp30_9
{
    class VeTauHoa
    {
        public String TenChuyen;
        public int NgayDi;
        public int GiaVe;
        public Array[] ThongTinVeTauHoa = { };
        public void NhapTTveTau()
        {
            for(int i = 0; i < ThongTinVeTauHoa.Length; i++)
            {
                Console.Write("Nhap ten chuyen:{0}", TenChuyen);
                Console.ReadLine();
                Console.WriteLine("Nhap ngay di chuyen tau: {0}", NgayDi);
                Console.ReadLine();
            }
        }
        public void XuatTTveTau()
        {
            Console.WriteLine(ThongTinVeTauHoa);
        }
        public void HuyveTau()
        {
            Console.Write("Nhap ten chuyen muon huy:{0}",TenChuyen);
            Console.ReadLine();
            Console.WriteLine("Nhap ngay di muon huy:{0}", NgayDi);
            Console.ReadLine();
            Console.WriteLine("Nhap gia ve muon huy:{0}", GiaVe);
            Console.ReadLine();
            Console.WriteLine("Thong tin chuyen tau da huy la: {0} {1} {2} ", TenChuyen, NgayDi, GiaVe);
        }
        public int GiaVeTauHoa()
        {
            return GiaVe;
        }
    }
    class Nguoi
    {
        string HoTen;
        int Qt;
        string[] ThongTinNguoiDiTau = Array.Empty<string>();
        public void NhapTTNguoidiTau()
        {
            for (int i = 0; i < ThongTinNguoiDiTau.Length;i++)
            {
                Console.WriteLine("Nhap ho va ten nguoi di:{0}", HoTen);
                Console.ReadLine();
                Console.WriteLine("Nhap qt:{0}", Qt);
                Console.ReadLine();
            }
        }
        public void XuatTTNguoidiTau()
        {
            NhapTTNguoidiTau();
            Console.WriteLine(ThongTinNguoiDiTau);
        }
        /*public void Huy()
        {
            Console.WriteLine("Nhap ho va ten nguoi di:{0}", HoTen);
            Console.ReadLine();
            Console.WriteLine("Nhap qt:{0}", Qt);
            Console.ReadLine();
        }*/
        public int TongTienVeTau()
        {
            int TongTienVeTau=0;
            foreach(string HoTen in ThongTinNguoiDiTau)
            {
                TongTienVeTau += GiaVe;
            }
            return TongTienVeTau;
        }
    }
    class NhapDanhSachNguoiDiTau
    {
        string[] DanhSachNguoiDiTau = new string[30];
        static void Main(string[] args)
        {

        }
    }
}