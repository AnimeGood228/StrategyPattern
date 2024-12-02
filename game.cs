using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Game
    {
        private Player _player;

        public Game()
        {
            // Начальное оружие
            _player = new Player(new Sword());
        }

        public void Start()
        {
            while (true)
            {
                Console.WriteLine("Выберите свое оружие: 1. Меч 2. Лук 3. Топор 4. Атака 5. Выход");
                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        _player.SetWeapon(new Sword());
                        Console.WriteLine("Оружие превратилось в меч.");
                        break;
                    case "2":
                        _player.SetWeapon(new Bow());
                        Console.WriteLine("Оружие изготовлено к стрельбе из лука.");
                        break;
                    case "3":
                        _player.SetWeapon(new Axe());
                        Console.WriteLine("Оружие настроено на топор.");
                        break;
                    case "4":
                        _player.Attack();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Неверный выбор. Пробовать снова.");
                        break;
                }
            }
        }
    }
}
