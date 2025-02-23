public class Program
{
    public static void Main()
    {
        char[,] grid = new char[10, 10];
        char target = 'X';
        char player = 'P';
        Random random = new Random();
        int randomNumber1 = random.Next(0, 10);
        int randomNumber2 = random.Next(0, 10);


        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                grid[i, j] = ' ';
            }
        }
        grid[randomNumber1, randomNumber2] = target;
        int playerRow = 0;
        int playerCol = 0;
        grid[playerRow, playerCol] = player;
        while (true)
        {
            Console.Clear();
            Console.Write("  ");
            for (int j = 0; j < 10; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i + " ");
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(grid[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Input w, a, s or d");
            char input = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (input == 'w' ||
               input == 'a' ||
               input == 's' ||
               input == 'd')
            {
                switch (input)
                {
                    case 's':
                        if (playerRow < 9)
                        {
                            grid[playerRow, playerCol] = ' ';
                            playerRow++;
                        }
                        else Console.WriteLine("NO");
                        break;
                    case 'd':
                        if (playerCol < 9)
                        {
                            grid[playerRow, playerCol] = ' ';
                            playerCol++;
                        }
                        else Console.WriteLine("NO");
                        break;
                    case 'a':
                        if (playerCol > 0)
                        {
                            grid[playerRow, playerCol] = ' ';
                            playerCol--;
                        }
                        else Console.WriteLine("NO");
                        break;
                    case 'w':
                        if (playerRow > 0)
                        {
                            grid[playerRow, playerCol] = ' ';
                            playerRow--;
                        }
                        else Console.WriteLine("NO");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Wrong input");
            }
            grid[playerRow, playerCol] = player;

            if (grid[randomNumber1, randomNumber2] == grid[playerRow, playerCol])
            {
                Console.Clear();
                Console.WriteLine("You Win!!!!");
                break;
            }
        }
        Console.ReadKey();

    }
}