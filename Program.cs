using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossFightLootTableThingy
{
    class Program
    {
        static void Main(string[] args)
        {
            Fight();
        }

        static void Fight()
        {
            int BonusLoot = 0;

            for (int fight = 0; fight <= 2; fight++)
            {
                Random Loot = new Random();
                int LootRoll = Loot.Next(0, 101);
                
                string Bronze = "Bronze";
                string Silver = "Silver";
                string Gold = "Gold";
                for (int HP = 5; HP != -1; HP--)
                {

                    Console.WriteLine("Boss HP: " + HP + " ");

                    if (HP >= 0)
                    {
                        Console.ReadKey();
                    }
                            if (BonusLoot <= 1)
                            {
                                if (LootRoll < 33 || LootRoll > 66)
                                {
                                    Console.WriteLine(Silver);
                                }
                                if (BonusLoot <= 2)
                                {
                                    if (LootRoll < 66)
                                    {
                                        Console.WriteLine(Gold);
                                    }
                                }
                            }

                        }

                        BonusLoot++;
                    }
                }
            }
            
        }
