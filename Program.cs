using System;

namespace Estimate_Pi
{
    class Program
    {
        static float estimation_pi(int number_of_points)
        {
            int total_points_circle = 0;
            int total_points_square = 0;

            for(int i = 0; i < number_of_points; i++)
            {
                Random generator = new Random();
                double x = generator.NextDouble();
                double y = generator.NextDouble();

                double length_squared = x * x + y * y;

                if(length_squared < 1)
                {
                    total_points_circle += 1;
                }

                total_points_square += 1;
            }

            return (float) 4 * total_points_circle / total_points_square;
        }

        static void Main(string[] args)
        {
            int a_milion = 100000;
            float output = estimation_pi(a_milion);
            Console.Write($"An estimation of pi could be : {output} .");
            Console.ReadLine();
        }
    }
}
