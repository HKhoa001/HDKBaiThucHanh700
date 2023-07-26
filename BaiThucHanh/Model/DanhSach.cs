using System.Collections;

namespace HDKBaiThucHanh.Model{
    public class DanhSach {
        public void NhapThongTin(ArrayList arrList){
            System.Console.WriteLine("Nhap vao so sinh vien: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < n ; i++ ){
                SinhVien Sv = new SinhVien();
                Sv.NhapThongTin();
                arrList.Add(Sv);
            }
        }
        public void SuaThongTin(ArrayList arrList){

            System.Console.WriteLine("Nhap vao ten sinh vien muon sua");
            string Ten = Console.ReadLine();
            foreach(SinhVien Sv in arrList){
                if(Sv.HoTen.Equals(Ten)){
                    Sv.HoTen= Console.ReadLine();
                }
            }
        }
        public void XoaThongTin(ArrayList arrList){

            System.Console.WriteLine("Nhap vao ten sinh vien muon xoa");
            string DenleteTen = Console.ReadLine();
            foreach(SinhVien Sv in arrList){
                if(Sv.HoTen.Equals(DenleteTen)){
                arrList.Remove(Sv);
                }
            }
        }
        public void InThongTin(ArrayList arrList){

            foreach(SinhVien Sv in arrList){
                Sv.HienThi();
            }
        }
        
    }
}