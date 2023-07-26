using System.Diagnostics;
using System.Collections;
using HDKBaiThucHanh.Model;
ArrayList arrList = new ArrayList();
DanhSach ds = new DanhSach();

string chon;
do{
    System.Console.WriteLine("1: Nhap thong tin \n2: Sua thong tin \n3: Xoa thong tin \n4: In thong tin \n5: Thoat \nNhap tinh nang muon chon: ");
    chon = Console.ReadLine();

    switch(chon){
        case "1": ds.NhapThongTin(arrList);break;
        case "2": ds.SuaThongTin(arrList);break;
        case "3": ds.XoaThongTin(arrList);break;
        case "4": ds.InThongTin(arrList);break;
        default : System.Console.WriteLine("Khong co chua nang nay!");break;
    }

}while(chon!="0");

