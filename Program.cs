using System.ComponentModel.Design;

namespace C_sharp_course_Conditionals
{

    internal class Program


    {
        static void Main(string[] args)
        {

            //if..else..if else statement
            //1st part

            int hour = 10;

            if (hour >0 && hour < 12)
            {
                Console.WriteLine("It's morning.");
            }
            else if (hour >=12 && hour <18)
            {
                Console.WriteLine("It's afternoon.");
            }
            else
            {
                Console.WriteLine("It's evening.");
            }



            //if..else..if else statement
            //2nd part

            bool isGoldCustomer = true;

            //float price;
            //if (isGoldCustomer)
            //{
            //price = 19.95f;
            //else
            //{
            //price = 29.95f;

            float price = (isGoldCustomer) ? 19.95f : 29.95f;
            Console.WriteLine(price);



            //switch statement   1st part

            var season = Seasons.Summer;

            switch (season)
            {
                case Seasons.Autumn:
                    Console.WriteLine("It's autumn and a beautiful season.");
                    break;

                case Seasons.Summer:
                    Console.WriteLine("It's time to go to beach.");
                    break;

                case Seasons.Spring:
                default:
                    Console.WriteLine("It should be two others.");
                    break;
            }








        }
    }
}
