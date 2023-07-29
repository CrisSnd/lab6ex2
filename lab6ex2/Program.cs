using lab6ex2;
using System;

namespace MyApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            /*Scrieti un program care va modela un autoturism. Un autoturism va avea o marca (string), un numar de inmatriculare (string), precum si o capacitate cilindrica(int).
              Autoturismul va avea:
               Campurile corespunzatoare caracteristicilor autoturismului;
                Un constructor care va initializa campurile acestuia;
               O metoda “Tiparire” care va afisa pe consola descrierea acestuia sub forma : “marca, numarDeInmatriculare, capacitateCilindrica”.
            */


           Car car= new Car ("Dacia","AA_01XYZ",1200);

           Console.WriteLine(car.GetDescription());

        }

    }
}