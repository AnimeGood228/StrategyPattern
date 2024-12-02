using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Player
    {
        private IWeapon _weapon;
        public Player(IWeapon weapon)
        {
            _weapon = weapon;
        }
        public void SetWeapon(IWeapon weapon)
        {
            _weapon = weapon;
        }
        public void Attack()
        {
            _weapon.UseWeapon();
        }
    }
}
