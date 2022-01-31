using System;
using System.Text;

namespace Cars.Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            
            Cars car1 = new Cars();

            car1.seher = "Baki";
            car1.marka = "BMW";
            car1.model = "325i";
            car1.buraxilisIli = "2000";
            car1.reng = "Qara";
            car1.yanacaqNovu = "Benzin";
            car1.muherrikGucu = "215 at gucu";
            car1.yurus = "250 000 km";
            car1.qiymet = "16 500 manat";

            Cars car2 = new Cars();

            car2.seher = "Baki";
            car2.marka = "Mersedes";
            car2.model = "C 220";
            car2.buraxilisIli = "2001";
            car2.reng = "Ag";
            car2.yanacaqNovu = "Benzin";
            car2.muherrikGucu = "215 at gucu";
            car2.yurus = "350 000 km";
            car2.qiymet = "10 300 manat";

            Cars[] cars = new Cars[2];
            cars[0] = car1;
            cars[1] = car2;

            foreach (var car in cars)
            {
                Console.WriteLine(car.GetInfo());
                Console.WriteLine("_______________________________________");
            }

            Console.WriteLine("###########################################");
            Cars c1 = cars[0];
            Console.WriteLine(c1.GetInfo());

        } 
    }
}
