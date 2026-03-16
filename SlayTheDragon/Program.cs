namespace SlayTheDragon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Slay the dragon!");
            Console.ResetColor();

            string maul = "1";
            string lance = "2";
            string greatSword = "3";
            
            Random rng = new Random();
            int dragonSlayerHP = rng.Next(76, 151);
            int dragonHP = rng.Next(80, 171);

            string weaponChoice = "0";

            bool isValid;
            do
            {
                isValid = true;

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
                        weaponChoice = maul;
                        break;
                    case "2":
                        Console.WriteLine("Go and slay the dragon with your lance!");
                        weaponChoice = lance;
                        break;
                    case "3":
                        Console.WriteLine("Go and slay the dragon with your greatsword!");
                        weaponChoice = greatSword;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Pick a valid weapon!");
                        Console.ResetColor();
                        isValid = false;
                        break;
                }
            } while (isValid == false);

            int dazingStrikeCounter = 0;
            do
            {
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

                if (weaponChoice == maul)
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
                                DragonAttack();

                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine($"You hit the dragon for: {bluntStrike}dmg!");
                                Console.WriteLine($"You were hit by the dragon for: {DragonAttack}dmg!");
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
                                DragonAttack();

                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine($"your medicene healed you for: {medecine}HP!");
                                Console.WriteLine($"The dragon hit you for: {DragonAttack}dmg!");
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
                else if (weaponChoice == lance)
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
                                DragonAttack();

                                Console.WriteLine($"You hit the dragon for {piercingStrike}dmg!");
                                Console.WriteLine($"You got hit by the dragon for {DragonAttack}dmg!");
                                Console.WriteLine();
                                break;
                            case "2":
                                dragonHP -= gapingWound;
                                DragonAttack();
                                break;
                        }

                    } while (isValid == false);
                }

            } while (dragonSlayerHP > 0 && dragonHP > 0);
        }
        public static int DragonAttack()
        {
            Random rng = new Random();
            int dragonAttack = rng.Next(20, 36);
            int dragonSlayerHP = rng.Next(76, 151);

            dragonSlayerHP -= dragonAttack;

            return dragonAttack;
        }
    }
}
