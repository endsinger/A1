using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Fish karas = new Fish();
            karas.Characters("Карась", 100, 200, "Зеленый");
            karas.Print();

            Fish okun = new Fish();
            okun.Characters("Окунь", 100, 200, "Зеленый");
            okun.Print();
            
            Fish akula = new Fish();
            akula.Characters("Акула", 100, 200, "Зеленый");
            akula.Print();
            
            Fish dolphin = new Fish();
            dolphin.Characters("Дерьфин", 100, 200, "Зеленый");
            dolphin.Print();
            
            Fish seledka = new Fish();
            seledka.Characters("Селедка", 100, 200, "Зеленый");
            seledka.Print();
            
            Fish moiva = new Fish();
            moiva.Characters("Мойва", 100, 200, "Зеленый");
            moiva.Print();
            
            Fish karp = new Fish();
            karp.Characters("Карп", 100, 200, "Зеленый");
            karp.Print();
            
            Fish SeaStar = new Fish();
            SeaStar.Characters("Морская звезда", 100, 200, "Зеленый");
            SeaStar.Print();
            
            Fish som = new Fish();
            som.Characters("Сом", 100, 200, "Зеленый");
            som.Print();
            
            Fish bream = new Fish();
            bream.Characters("Лещь", 100, 200, "Зеленый");
            bream.Print();
        }
    }
}
