using System.Runtime.CompilerServices;
using şube1emlakçılib;

namespace classlar
{

    

    internal class Program
    {
        static void Main(string[] args)
        {

           

            KiralıkEv ke = new KiralıkEv(500,  400,3, "Kiralık Ev", 400,80);
            KiralıkEv ke1 = new KiralıkEv(500,  900,2, "Kiralık Ev", 100,90);
            KiralıkEv ke2 = new KiralıkEv(500,  600,4, "Kiralık Ev",100, 200);
           
            var evim = new Ev();
            var se = new SatilikEv(500, 3,  "Gazi", 100,60);
            var se1 = new SatilikEv(400, 5,  "Satılık Ev", 200,70);
            var se2 = new SatilikEv(300, 8,  "Satılık Ev", 300,80);
            Console.WriteLine(se.ToString());

            Console.WriteLine($"\nToplam Ev Sayisi: {Ev.sayac}");
            Console.WriteLine($"Satilik Ev Fiyatı: {se.FiyatHesapla()}");
            Console.WriteLine($"se tipi: {se.SemtiGoster()}");


        }



    }

   

    
    
}

