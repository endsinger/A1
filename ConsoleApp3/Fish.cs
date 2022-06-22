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
        
        
        public static void GeneratorFish()
        {
            for (byte i=1; i<=10; i++)
            {
                // Console.WriteLine("Объект номер: " + i);
                string[] words1 = { "карась", "щука", "акула", "рыба-мечь", "дельфин", "семга", "мойва", "сайга", "окунь", "пиранья", "кит", "селедка" }; // массив 1

                string[] words2 = { "белый", "красный", "свежий", "тухлый", "зеленый", "большой", "маленький", "красивый" }; // массив 2
                try // проверка на ошибку
                {
                    string word1 = words1[new Random().Next(1, words1.Length)]; // рандомное слово из масива 1
                    string word2 = words2[new Random().Next(-1, words2.Length)]; // рандомное слово из 2 массива
                    Console.WriteLine(word1 + " " + word2 + " "); // соеденение 2 слов
                }
                catch
                {
                    Console.WriteLine("Error");
                }
            }
        }
        public static void Print()
        {
            Console.WriteLine("Генератов рандомной рыбы");
        }

    }
}
