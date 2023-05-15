namespace numberGen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool running = true;
            int i = 0;
            int j = 1;
            int val = 10;
            int upperVal = (int)Math.Pow(10, 10);

            while (running)
            {
                int number1 = random.Next(0, val);
                int number2 = random.Next(0, val);
                i += 1;
                if (number1 == number2)
                {
                    Console.WriteLine("run: " + j + ", number: " + number1 + ", count: " + i + ", range: ", val.ToString());
                    if (val != upperVal)
                    {
                        val *= 10;
                        j += 1;
                    }
                    else
                    {
                        running = false;
                    }

                }
            }


        }
    }
}