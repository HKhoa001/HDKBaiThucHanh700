using System.Dynamic;
public class DiemTrungBinh
{   
    private static void Main (string[]args){
        Console.WriteLine("Ho va ten: ");
        string TenSV = Console.ReadLine();

        Console.WriteLine("MSV:");
        string MSV = Console.ReadLine();

        Console.WriteLine("Nhap diem mon toan:");
        double diemToan = double.Parse(Console.ReadLine());

        Console.WriteLine("Nhap diem mon ly:");
        double diemLy = double.Parse(Console.ReadLine());

        Console.WriteLine("Nhap diem mon hoa:");
        double diemHoa = double.Parse(Console.ReadLine());

        Console.WriteLine("Nhap diem mon van:");
        double diemVan = double.Parse(Console.ReadLine());

        Console.WriteLine("Nhap diem mon anh:");
        double diemAnh = double.Parse(Console.ReadLine());

        double DTB = (diemToan + diemLy + diemHoa + diemVan + diemAnh) / 5;

        Console.WriteLine("Ho va ten: " + TenSV);
        Console.WriteLine("MSV: " + MSV);
        Console.WriteLine("Diem trung binh: " + DTB.ToString("0.00"));
    }
}