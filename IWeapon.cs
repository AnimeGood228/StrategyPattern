using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public interface IWeapon
    {
        void UseWeapon();
    }
    public class Sword : IWeapon
    {
        public void UseWeapon()
        {
            Console.WriteLine("Размахивающий мечом!");
        }
    }
    public class Bow : IWeapon
    {
        public void UseWeapon()
        {
            Console.WriteLine("Пускаю стрелу!");
        }
    }
    public class Axe : IWeapon
    {
        public void UseWeapon()
        {
            Console.WriteLine("Рубить топором!");
        }
    }
}
