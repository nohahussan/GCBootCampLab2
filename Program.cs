using System;

namespace Lab2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int length;
            int width;
           int height;

           string inputChoice ;

            do
            {
                Console.WriteLine("Welcome to Grand Circus'Room Detail Generator!\n");

                Console.WriteLine("Enter Length : ");

                string leng = Console.ReadLine();

                length = int.Parse(leng);


                Console.WriteLine("Enter Width : ");

                string wid = Console.ReadLine();

                width = int.Parse(wid);

                Console.WriteLine("Enter Height : ");

                string heigh = Console.ReadLine();

                height = int.Parse(heigh);

                int area = length * width;

                int perimiter = (2 * length) + (2 * width);

                int volume = area * height;

                Console.WriteLine("Area : " + area);

                Console.WriteLine("Perimeter : " + perimiter);

                Console.WriteLine("Height : " + height + "\n");


                Console.WriteLine("Continue? (y/n)");

                string input = Console.ReadLine();

                inputChoice = input.ToLower();

                if(inputChoice.Equals("n"))
                {
                    break;
                
                }


            } while (true);







        }
    }
}
