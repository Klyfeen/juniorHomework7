using System;

namespace juniorHomework7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int crystals = 0;
            int gold;
            int crystalPrice = 100;
            int purchaseCrystals;
            
            Console.Write("Введите количество золота в вашем распоряжении: ");
            gold = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Мы можем конвертировать ваше золото в кристаллы!");
            Console.WriteLine("1 кристалл = 100 золота");
            Console.Write("Сколько кристаллов вы хотите купить: ");
            purchaseCrystals = Convert.ToInt32(Console.ReadLine());

            gold -= purchaseCrystals * crystalPrice;
            crystals += purchaseCrystals;
            Console.WriteLine($"Теперь у вас: {crystals} кристаллов и {gold} золота!");
        }
    }
}
