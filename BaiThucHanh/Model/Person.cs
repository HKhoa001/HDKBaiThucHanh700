using System.Text;
using System;
using System.Security.AccessControl;

namespace HDKBaiThucHanh.Model
{
    public class Person 
    { 
    public int StdID { get; set; }
    public string FullName { get; set; }
      
    public void NhapThongTin(){
        System.Console.WriteLine("Nhap vao StudentID: ");
        StdID = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Nhap vao FullName: ");
        FullName = Console.ReadLine();
    }

    public void InThongTin(){
        System.Console.WriteLine("StudenID: {0} \nFullName: {1}",StdID,FullName);
    }
    }  
}