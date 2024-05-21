using System;
using System.Security.Cryptography;

namespace Lesson4
{
    public delegate void TangQuaDelegate(string gift);

    public class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person vo = new Person("Bup be");
            Program program = new Program();
            program.oNha(vo, program.tangQua);
            program.dlg("nguoi yeu");
            program.lamdaDlg(" vo");


        }

        public void tangQua(string qua)
        {
            Console.WriteLine("Da tang " + qua);
        }
        //public void oNha(Person friend, tangQua)
        //{
        //    var qua = "Quà đã nhận";
        //    tangQua(qua);
        //}

        //TangQuaDelegate tangQua = tangQua() - Truyen func vao tham so/ k phai thuc thi nen bo ();
        public void oNha(Person friend, TangQuaDelegate tangQua)
        {
            var qua = "Qua da nhan tu " + friend.Name;
            tangQua(qua);
        }
        TangQuaDelegate dlg =
          delegate (string qua) { Console.WriteLine("Tang qua lan 2 la " + qua); };
        //Dùng lambda expression
        TangQuaDelegate lamdaDlg = (qua) => { Console.WriteLine("Tang qua lan 3 la" + qua); };

        //Câu lệnh đầy đủ của lambda expression.
        //Dấu "=>" gọi là go-to
        //(parameters) => { statement
    }

}
