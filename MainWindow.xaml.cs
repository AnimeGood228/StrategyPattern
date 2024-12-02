using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StrategyPattern
{
    public partial class MainWindow : Window
    {
        private Player _player;
        public MainWindow()
        {
            InitializeComponent();
            _player = new Player(new Sword()); // Изначально игрок с мечом
        }
        private void AttackButton_Click(object sender, RoutedEventArgs e)
        {
            IWeapon selectedWeapon = null;

            switch (WeaponComboBox.SelectedIndex)
            {
                case 0:
                    selectedWeapon = new Sword();
                    break;
                case 1:
                    selectedWeapon = new Bow();
                    break;
                case 2:
                    selectedWeapon = new Axe();
                    break;
            }
            if (selectedWeapon != null)
            {
                _player.SetWeapon(selectedWeapon);
                _player.Attack();
                OutputTextBlock.Text = "Атакованный с " + WeaponComboBox.SelectedItem.ToString();
            }
        }
    }
}
