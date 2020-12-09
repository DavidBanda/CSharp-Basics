using System;

namespace Basics
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*Create variables and append them to a string*/
            string characterName = "David";
            int characterAge = 24;
            characterAge++;
            char grade = 'a';
            int[] numbers = { 1, 2, 3 };
            string[] friends = new string[4];
            friends[0] = "David";

            int[,] matrix =
            {
                { 1, 2, 3 },
                { 2, 3, 4 },
                { 5, 6, 7 },
            };
          
            Console.WriteLine($"Hol{grade} {characterName}, de {characterAge} años");
            Console.WriteLine(friends);
            Console.WriteLine(SayHi("David"));

            Console.WriteLine(IsMaleAndTall(true, true));

            if (characterName == "David")
            {
                Console.WriteLine("Es true");
            }

            Console.WriteLine(DayName(2));

            Console.WriteLine($"Valor 1 de matriz: {matrix[0, 0]}, Valor 2 de la matriz: {matrix[1, 0]}");

            //SumTwoNumbers();

            Book book1 = new Book("I, robot", "Isaac Asimov", 380);
            book1.Genre = "Drama";
            Console.WriteLine(book1.author);
            Console.WriteLine(book1.Genre);
            Console.WriteLine(Book.SayHiAgain());

            Cat cat1 = new Cat("Molly", 1);
            Console.WriteLine(cat1.Name);
            Console.WriteLine(cat1.Speak());
        }

        public static string SayHi(string user)
        {
            return $"Hello, {user}";
        }

        public static string IsMaleAndTall(bool male, bool tall)
        {
            string response = "";

            if (male && tall)
            {
                response = "Es hombre y es alto";
            } else if (male && !tall)
            {
                response = "Es hombre pero no es alto";
            } else
            {
                response = "Ni es hombre ni es alto";
            }

            return response;
        }

        public static string DayName(int day)
        {
            string dayName = "";

            switch (day)
            {
                case 0:
                    dayName = "Lunes";
                    break;
                case 1:
                    dayName = "Martes";
                    break;
                case 2:
                    dayName = "Miercoles";
                    break;
                case 3:
                    dayName = "Jueves";
                    break;
                case 4:
                    dayName = "Viernes";
                    break;
                case 5:
                    dayName = "Sabado";
                    break;
                case 6:
                    dayName = "Domingo";
                    break;
                default:
                    dayName = "Ingresa un dia valido";
                    break;
            }

            return dayName;
        }

        public static void SumTwoNumbers()
        {
            try
            {
                Console.Write("Ingresa un numero: ");
                int firstNum = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingresa un numero: ");
                int secondNum = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"El resultado es: {firstNum/secondNum}");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
