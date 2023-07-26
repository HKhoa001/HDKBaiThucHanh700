namespace HDKBaiThucHanh.Model{
    public class Employee {
        public int MaNV { get; set; }
        public string TenNV { get; set; }
        public int Tuoi { get; set; }
        public double Luong { get; set; }
        public void NhapThongTin(){
            System.Console.WriteLine("Nhap vao ma nhan vien: ");
            MaNV = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Nhap vao ten nhan vien: ");
            TenNV = Console.ReadLine();
            System.Console.WriteLine("Nhap vao tuoi nhan vien: ");
            Tuoi = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Nhap vao luong nhan vien: ");
            Luong = Convert.ToInt32(Console.ReadLine());
        }

        public void HienThi(){
            System.Console.WriteLine("MaNV: {0} \nTenNV: {1} \nTuoi: {2} \nLuong: {3}",MaNV,TenNV,Tuoi,Luong);
        }
    }
}