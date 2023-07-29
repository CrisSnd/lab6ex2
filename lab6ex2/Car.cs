using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6ex2
{
    internal class Car
    {
        private string marca;
        private string numarInmatriculare;
        private int capacitateCilindrica;

        public Car(string marca, string numarInmatriculare, int capacitateCilindrica)
        {
            this.marca = marca;
            this.numarInmatriculare = numarInmatriculare;
            this.capacitateCilindrica = capacitateCilindrica;
        }

        public string GetDescription()
        {
           return $"{marca}, {numarInmatriculare}, {capacitateCilindrica}cm3";

        }
    }
}
