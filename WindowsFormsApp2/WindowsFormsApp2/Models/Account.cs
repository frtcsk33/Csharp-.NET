using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Models
{
   public class Account
    {
        public string userName { get; set; }
        public string  race { get; set; }
        public string branch { get; set; }
        public string weapon { get; set; }

        public int damage { get; set; }
        public int damage2 { get; set; }

        Random random = new Random();
        public void Attack()
        {

            damage = 0;
            damage2 = 0;
            int number2 = random.Next(15, 71);
            damage2 += number2;

            /*
             ırk => human = +5, monster +10
            warrior => 40
            mage => 30 - 50
            assassin => 10 - 70
            archer => 5 - 60
             */
            if (race == "Human")
            {
                damage += 5;
            }
            else
            {
                damage += 10; 
            }
            switch(branch){

                case "Warrior":
                    damage += 40;
                    break;

                case "Mage":
                    damage += random.Next(30,51);
                    break;

                case "Assassin":
                    damage += random.Next(10, 71);
                    break;

                case "Archer":
                    int number = random.Next(0, 2);
                    damage += number == 0 ? 5 : 60;
                    break;
            }
        }
    }
}
