namespace SlayTheDragon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Slay the dragon!");
            Console.ResetColor();

            Random rng = new Random();
            int dragonSlayerHP = rng.Next(76, 151);
            int dragonHP = rng.Next(80, 171);
            int dragonAttack = rng.Next(20, 36);

            string maul = "1";
            string lance = "2";
            string greatSword = "3";

            string chosenWeapon = "0";

            string weapon = WeaponChoice(maul, lance, greatSword);

            bool isValid;

            int dazingStrikeCounter = 0;
            do
            {
                isValid = true;
                
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Dragon slayer's health points: {dragonSlayerHP}");
                for (int i = 0; i < dragonSlayerHP; i++)
                {
                    Console.Write("█");
                }
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Dragon's health points: {dragonHP}");
                for (int i = 0; i < dragonHP; i++)
                {
                    Console.Write("█");
                }
                Console.ResetColor();

                Console.WriteLine();
                Console.WriteLine();

                if (weapon.Equals(maul))
                {
                    do
                    {   
                        int bluntStrike = rng.Next(15, 31);
                        int dazingStrike = rng.Next(10, 26);
                        int medecine = rng.Next(18, 41);

                        isValid = true;
                        
                        Console.WriteLine("1. Blunt attack!");
                        Console.WriteLine("2. Dazing strike!");
                        Console.WriteLine("3. Medecine");
                        Console.WriteLine();
                        Console.Write("What's your move: ");
                        string inputChoice = Console.ReadLine();

                        Console.WriteLine();

                        switch (inputChoice)
                        {
                            case "1":
                                dragonHP -= bluntStrike;
                                dragonSlayerHP -= dragonAttack;

                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine($"You hit the dragon for: {bluntStrike}dmg!");
                                Console.WriteLine($"You were hit by the dragon for: {dragonAttack}dmg!");
                                Console.WriteLine();

                                dazingStrikeCounter++;

                                break;
                            case "2":
                                if (dazingStrikeCounter %2 == 0)
                                {
                                    dragonHP -= dazingStrike;

                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine($"You hit the dragon for: {dazingStrike}dmg!");
                                    Console.WriteLine("The dragon is dazed and can't attack!");
                                    Console.WriteLine();

                                    dazingStrikeCounter++;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Dazing strike isn't ready yet...");
                                    Console.ResetColor();
                                    Console.WriteLine();
                                }
                                break;
                            case "3":
                                dragonSlayerHP += medecine;
                                dragonSlayerHP -= dragonAttack;

                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine($"your medicene healed you for: {medecine}HP!");
                                Console.WriteLine($"The dragon hit you for: {dragonAttack}dmg!");
                                Console.WriteLine();

                                dazingStrikeCounter++;

                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Invalid action!");
                                Console.ResetColor();
                                Console.WriteLine();
                                break;
                        }
                    } while (isValid == false);
                }
                else if (weapon.Equals(lance))
                {
                    do
                    {
                        int piercingStrike = rng.Next(20, 36);
                        int gapingWound = rng.Next(13, 21);
                        int bandage = rng.Next(25, 46);

                        isValid = true;

                        Console.WriteLine("1. Piercing strike!");
                        Console.WriteLine("2. Gaping wounds!");
                        Console.WriteLine("3. Bandage!");
                        Console.WriteLine();
                        Console.Write("What's your move: ");
                        string inputChoise = Console.ReadLine();

                        Console.WriteLine();

                        switch(inputChoise)
                        {
                            case "1":
                                dragonHP -= piercingStrike;
                                dragonSlayerHP -= dragonAttack;

                                Console.WriteLine($"You hit the dragon for {piercingStrike}dmg!");
                                Console.WriteLine($"You got hit by the dragon for {dragonAttack}dmg!");
                                Console.WriteLine();
                                break;
                            case "2":
                                dragonHP -= gapingWound;
                                dragonSlayerHP -= dragonAttack;

                                Console.WriteLine($"You hit the dragon for {gapingWound}dmg!");
                                Console.WriteLine($"You got hit by the dragon for {dragonAttack}dmg!");
                                Console.WriteLine();
                                break;
                            case "3":
                                dragonSlayerHP += bandage;
                                dragonSlayerHP -= dragonAttack;

                                Console.WriteLine($"You healed yourself for {bandage}HP!");
                                Console.WriteLine($"You got hit by the dragon for {dragonAttack}dmg!");
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Invalid action!");
                                Console.ResetColor();
                                Console.WriteLine();
                                break;
                        }

                    } while (isValid == false);
                }
                else if(weapon.Equals(greatSword))
                {
                    do
                    {
                        int slashingStrike = rng.Next();
                        
                    } while (isValid == false);
                }

            } while (dragonSlayerHP > 0 && dragonHP > 0);
        }
        private static string WeaponChoice(string maul, string lance, string greatSword)
        {
            string chosenWeapon = "0";
            bool isValid = true;
            do
            {
                Console.WriteLine();

                Console.WriteLine("1. Maul");
                Console.WriteLine("2. Lance");
                Console.WriteLine("3. Greatsword");
                Console.Write("Pick your weapon: ");
                string input = Console.ReadLine();

                Console.WriteLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("Go and slay the dragon with your maul!");
                        chosenWeapon = maul;
                        isValid = true;
                        break;
                    case "2":
                        Console.WriteLine("Go and slay the dragon with your lance!");
                        chosenWeapon = lance;
                        isValid = true;
                        break;
                    case "3":
                        Console.WriteLine("Go and slay the dragon with your greatsword!");
                        chosenWeapon = greatSword;
                        isValid = true;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Pick a valid weapon!");
                        Console.ResetColor();
                        isValid = false;
                        break;
                }
            } while (isValid == false);
            return chosenWeapon;
        }
    }
}
