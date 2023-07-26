namespace HDKBaiThucHanh.Model{
    public class SinhVien {
        public string HoTen { get; set; }
        public string Msv { get; set; }
        public void NhapThongTin(){
            System.Console.WriteLine("Nhap vao ten sinh vien: ");
            HoTen = Console.ReadLine();
            System.Console.WriteLine("Nhap vao ma sinh vien: ");
            Msv = Console.ReadLine();
        }

        public void HienThi(){
            System.Console.WriteLine("Ho va ten: {0} \nMsv: {1}",HoTen,Msv);
        }
    }
}