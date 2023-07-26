namespace HDKBaiThucHanh.Model{
    public class GiaiPhuongTrinh {
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }
        public double X1 { get; set; }
        public double X2 { get; set; }
        public void NhapThongTin()
        {
            System.Console.WriteLine("Nhap vao he so a:");
            a = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Nhap vao he so b:");
            b = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Nhap vao he so c:");
            c = double.Parse(Console.ReadLine());
        }

        public void GiaiPTBacNhat(){
            X1=-b/a;
            System.Console.WriteLine("Nghiem cua phuong trinh: {0}x + {1} = 0 la: {2}",a,b,X1);
        }

        public void GiaiPTBac2(){
            double Dt = b*b - 4*a*c;
            if(Dt <0)
                System.Console.WriteLine("Phuong trinh vo nghiem");
            else if (Dt == 0)
            {
                System.Console.WriteLine("Phuong trinh co nghiem = {0}",-b/2*a);
            }
            else
            {
                X1=(-b + Math.Sqrt(Dt)/2*a);
                X2=(-b - Math.Sqrt(Dt)/2*a);
                System.Console.WriteLine("Phuong trinh co 2 nghiem la: X1 = {0}, X2 = {1}",X1,X2);
            }
        }
    }
}