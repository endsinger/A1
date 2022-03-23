using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    [Serializable]
    class Fish
    {
        private string name;
        private int _long;
        private int weight;
        private string color;
        //public Fish()
        //{
        //    Console.WriteLine("Имя " + name + "Длина " + _long + "Вес " + weight + "Цвет " + color);
        //}

        public void Characters(string _name, int __long, int _weight, string _color)
        {
            name = _name;
            _long = __long;
            weight = _weight;
            color = _color;

        }
        public void Print()
        {
            Console.WriteLine("Имя " + name +"Длина "+ _long + "Вес " + weight +"Цвет " + color );
        }
    
    }
}
