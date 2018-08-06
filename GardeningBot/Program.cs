using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardeningBot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gardening Bot Starting");
            Console.WriteLine("Enter Current Month (name) of the Year to Start or Exit to Quit:");
            string firstInput = Console.ReadLine();
            firstInput = firstInput.ToLower();
            monthSelection(firstInput);
        }
        static void restart()
        {
            Console.WriteLine("Gardening Bot Starting");
            Console.WriteLine("Enter Current Month (name) of the Year to Start or Exit to Quit:");
            string firstInput = Console.ReadLine();
            firstInput = firstInput.ToLower();
            monthSelection(firstInput);
        }
        static void monthSelection(string firstInput)
        {
            if (firstInput == "January" || firstInput == "january")
            {
                Console.WriteLine("You Have Selected January.");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("The usual temperature for January is: 5.9 Degrees Celsius");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Dual to the low degrees plants require less water and more time to grow.");
                System.Threading.Thread.Sleep(2000);
                string month = firstInput;
                dateSelection(month);
            }
            else if (firstInput == "February" || firstInput == "february")
            {
                Console.WriteLine("You Have Selected February");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("The usual temperature for February is: 6.0 Degrees Celsius");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Dual to the low degrees plants require less water and more time to grow.");
                System.Threading.Thread.Sleep(2000);
                string month = firstInput;
                dateSelection(month);
            }
            else if (firstInput == "March" || firstInput == "march")
            {
                Console.WriteLine("You Have Selected March");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("The usual temperature for March is: 8.0 Degrees Celsius");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Dual to the low degrees plants require less water but duo to the month they grow faster.");
                System.Threading.Thread.Sleep(2000);
                string month = firstInput;
                dateSelection(month);
            }
            else if (firstInput == "April" || firstInput == "april")
            {
                Console.WriteLine("You Have Selected April");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("The usual temperature for April is: 9.9 Degrees Celsius");
                System.Threading.Thread.Sleep(2000);
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Dual to the low degrees plants require less water but duo to the month they grow faster.");
                string month = firstInput;
                dateSelection(month);
            }
            else if (firstInput == "May" || firstInput == "may")
            {
                Console.WriteLine("You Have Selected May");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("The usual temperature for May is: 13.3 Degrees Celsius");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Dual to the weather and degrees plants require more watering but plants grow faster.");
                System.Threading.Thread.Sleep(2000);
                string month = firstInput;
                dateSelection(month);
            }
            else if (firstInput == "June" || firstInput == "june")
            {
                Console.WriteLine("You Have Selected June");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("The usual temperature for June is: 16.2 Degrees Celsius");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Dual to the weather and degrees plants require more watering.");
                System.Threading.Thread.Sleep(2000);
                string month = firstInput;
                dateSelection(month);
            }
            else if (firstInput == "July" || firstInput == "july")
            {
                Console.WriteLine("You Have Selected july");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("The usual temperature for July is: 18.6 Degrees Celsius");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Dual to the weather and degrees plants require more watering.");
                System.Threading.Thread.Sleep(2000);
                string month = firstInput;
                dateSelection(month);
            }
            else if (firstInput == "August" || firstInput == "august")
            {
                Console.WriteLine("You Have Selected August");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("The usual temperature for August is: 18.6 Degrees Celsius");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Dual to the weather and degrees plants require more watering.");
                System.Threading.Thread.Sleep(2000);
                string month = firstInput;
                dateSelection(month);
            }
            else if (firstInput == "September" || firstInput == "september")
            {
                Console.WriteLine("You Have Selected September");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("The usual temperature for March is: 15.9 Degrees Celsius");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Dual to the weather and degrees plants require more watering.");
                System.Threading.Thread.Sleep(2000);
                string month = firstInput;
                dateSelection(month);
            }
            else if (firstInput == "October" || firstInput == "october")
            {
                Console.WriteLine("You Have Selected October");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("The usual temperature for October is: 12.4 Degrees Celsius");
                System.Threading.Thread.Sleep(2000);
                string month = firstInput;
                dateSelection(month);
            }
            else if (firstInput == "November" || firstInput == "november")
            {
                Console.WriteLine("You Have Selected november");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("The usual temperature for November is: 8.7 Degrees Celsius");
                System.Threading.Thread.Sleep(2000);
                string month = firstInput;
                dateSelection(month);
            }
            else if (firstInput == "December" || firstInput == "december")
            {
                Console.WriteLine("You Have Selected December");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("The usual temperature for December is: 6.9 Degrees Celsius");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Dual to the low degrees plants require less water and more time to grow.");
                System.Threading.Thread.Sleep(2000);
                string month = firstInput;
                dateSelection(month);
            }
            else if (firstInput == "Exit" || firstInput == "exit")
            {
                Console.WriteLine("Thank you for using Gardening Bot. Press Any Key To Close....");
                Console.ReadKey();
            }
            else if (firstInput == "ok")
            {
                Console.WriteLine("Testing START:");
                string month = "November";
                dateSelection(month);
            }
            else
            {
                Console.WriteLine("I'm sorry I didnt understood you please enter Month of the Year or Exit to Quit:");
                string errorFirstInput = Console.ReadLine();
                monthSelection(errorFirstInput);
            }
        }

        static void dateSelection(string month)
        {
            string lcMonth = month.ToLower();
            Console.WriteLine("Please enter which day of " + month + " is:");
            string userInput = Console.ReadLine();
            int secondInput = Int32.Parse(userInput);
            if (secondInput <= 29 && lcMonth == "febuary")
            {
                int date = secondInput;
                soilPrepare(month, date);
            }
            else if (secondInput <= 30 && (lcMonth == "april" || lcMonth == "june" || lcMonth == "september" || lcMonth == "november"))
            {
                int date = secondInput;
                soilPrepare(month, date);
            }
            else if (secondInput <= 31 && (lcMonth == "january" || lcMonth == "march" || lcMonth == "may" || lcMonth == "july" || lcMonth == "august" || lcMonth == "october" || lcMonth == "december"))
            {
                int date = secondInput;
                soilPrepare(month, date);
            }
            else
            {
                Console.WriteLine("The entered " + secondInput + " isn't valid.");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("This might be because the selected month does not include that many days");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("If you would like to try again type Yes if you would like to quit No:");
                string errorInput = Console.ReadLine();
                if (errorInput == "yes" || errorInput == "Yes")
                {
                    dateSelection(month);
                }
                else if (errorInput == "No" || errorInput == "no")
                {
                    Console.WriteLine("Press Any Key To Close....");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("The entered value: " + errorInput + " isnt valid");
                    Console.WriteLine("Press Any Key To Close....");
                    Console.ReadLine();
                }

            }
        }
        static void soilPrepare(string month, int date)
        {
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("How much square meter of garder do you have? (Less than 100)");
            System.Threading.Thread.Sleep(2000);
            string userInput = Console.ReadLine();
            int gardenSize = Int32.Parse(userInput);
            if (gardenSize > 0 && gardenSize < 101)
            {
                Console.WriteLine("Preparing Soil.....");
                System.Threading.Thread.Sleep(3000);
                Console.WriteLine("Soil at: 20%");
                System.Threading.Thread.Sleep(3000);
                Console.WriteLine("Soil at: 50%");
                System.Threading.Thread.Sleep(3000);
                Console.WriteLine("Soil at: 100%");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine(gardenSize + "m2 of Soil is Ready To Plant");
                seeds(month, date, gardenSize);
            }
            else
            {
                Console.WriteLine("The value " + gardenSize + " cannot be accepted.");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Would You Like To Try Again or Exit? (Yes/Exit)");
                string errorInput = Console.ReadLine();
                if (errorInput == "Yes" || errorInput == "yes")
                {
                    soilPrepare(month, date);
                }
                else if (errorInput == "Exit" || errorInput == "exit")
                {
                    Console.WriteLine("Press Any Key To Close....");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("The entered value: " + errorInput + " isnt valid");
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine("Press Any Key To Close....");
                    Console.ReadLine();
                }
            }
        }
        static void seeds(string month, int date, int gardenSize)
        {
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Initialising Seeding...");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Selecting Seeder Tool...");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Current Date: " + month + " "  + date);
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("The following plants ara availabe:");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Begonia");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Sweet Peas");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Busy Lizzie");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Geranium");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Antirrhinum");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Petunia");
            System.Threading.Thread.Sleep(1000);
            seedSelection(month, date, gardenSize);

        }
        static void seedSelection(string month, int date, int gardenSize)
        {
            int plantNum = gardenSize * 4;
            Console.WriteLine("For Optimal Results 4 plants are planted on every Square Meter.");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Number of Plants that will be planted : " + plantNum);
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Enter Plant Name: ");
            string plantInput = Console.ReadLine();
            string plant = plantInput.ToLower();
            if (plant == "begonia" || plant == "sweet peas" || plant == "busy lizzie" || plant == "geranium" || plant == "antirrhium" || plant == "petunia")
            {
                Console.WriteLine("Planting " + plantNum + " " + plant);
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Planting at: 20%");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Planting at: 50%");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Planting at: 99%");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Planting Complete");
                if (plant == "begonia" || plant == "petunia")
                {
                    Console.WriteLine(plant + " requires 4 Weeks To Grow");
                    int plantGrow = 4;
                    dateComplete(month, date, gardenSize, plant, plantGrow);
                }
                else if (plant == "sweet peas" || plant == "antirrhium")
                {
                    Console.WriteLine(plant + " requires 5 Weeks To Grow");
                    int plantGrow = 5;
                    dateComplete(month, date, gardenSize, plant, plantGrow);
                }
                else if (plant == "busy lizzie" || plant == "geranium")
                {
                    Console.WriteLine(plant + " requires 6 Weeks To Grow");
                    int plantGrow = 6;
                    dateComplete(month, date, gardenSize, plant, plantGrow);
                }
            }
            else
            {
                Console.WriteLine("Unable to accept " + plant);
                Console.WriteLine("Would you like to try again or exit? (Yes/Exit)");
                string errorInput = Console.ReadLine();
                if (errorInput == "Yes" || errorInput == "yes")
                {
                    seedSelection(month, date, gardenSize);

                }
                else if (errorInput == "Exit" || errorInput == "exit")
                {
                    Console.WriteLine("Press Any Key To Close....");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("The entered value: " + errorInput + " isnt valid");
                    Console.WriteLine("Press Any Key To Close....");
                    Console.ReadLine();
                }

            }

        }
        static void dateComplete(string month, int date, int gardenSize, string plant, int plantGrow)
        {
            System.Threading.Thread.Sleep(2000);
            if (month == "January" || month == "january")
            {
                int weeksToComplete = 7 * plantGrow;
                int daysLeft = 31 - date;
                int number = daysLeft - weeksToComplete;
                if (number < 0 && number > -30)
                {
                    int endDate = number * -1;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " February");
                    string endMonth = "february";
                    weeds(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number < 0 && number < -29)
                {
                    int endDate = number * -1;
                    endDate = endDate - 29;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " March");
                    string endMonth = "march";
                    weeds(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number == 0)
                {
                    int endDate = 1;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " February");
                    string endMonth = "february";
                    weeds(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number > 0)
                {
                    int endDate = number;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " February");
                    string endMonth = "february";
                    weeds(month, date, gardenSize, plant, plantGrow, endDate, endMonth);

                }
            }
            else if (month == "February" || month == "february")
            {
                int weeksToComplete = 7 * plantGrow;
                int daysLeft = 29 - date;
                int number = daysLeft - weeksToComplete;
                if (number < 0 && number > -32)
                {
                    int endDate = number * -1;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " March");
                    string endMonth = "march";
                    weeds(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number < 0 && number < -31)
                {
                    int endDate = number * -1;
                    endDate = endDate - 31;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " April");
                    string endMonth = "april";
                    weeds(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number == 0)
                {
                    int endDate = 1;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " March");
                    string endMonth = "march";
                    weeds(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number > 0)
                {
                    int endDate = number;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " March");
                    string endMonth = "march";
                    weeds(month, date, gardenSize, plant, plantGrow, endDate, endMonth);

                }


            }
            else if (month == "March" || month == "march")
            {
                int weeksToComplete = 7 * plantGrow;
                int daysLeft = 31 - date;
                int number = daysLeft - weeksToComplete;
                if (number < 0 && number > -31)
                {
                    int endDate = number * -1;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " April");
                    string endMonth = "april";
                    weeds(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number < 0 && number < -30)
                {
                    int endDate = number * -1;
                    endDate = endDate - 30;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " May");
                    string endMonth = "may";
                    weeds(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number == 0)
                {
                    int endDate = 1;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " April");
                    string endMonth = "april";
                    weeds(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number > 0)
                {
                    int endDate = number;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " April");
                    string endMonth = "april";
                    weeds(month, date, gardenSize, plant, plantGrow, endDate, endMonth);

                }

            }
            else if (month == "April" || month == "april")
            {
                int weeksToComplete = 7 * plantGrow;
                int daysLeft = 30 - date;
                int number = daysLeft - weeksToComplete;
                if (number < 0 && number > -32)
                {
                    int endDate = number * -1;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " May");
                    string endMonth = "may";
                    weeds(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number < 0 && number < -31)
                {
                    int endDate = number * -1;
                    endDate = endDate - 31;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " June");
                    string endMonth = "june";
                    weeds(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number == 0)
                {
                    int endDate = 1;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " May");
                    string endMonth = "may";
                    weeds(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number > 0)
                {
                    int endDate = number;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " May");
                    string endMonth = "may";
                    weeds(month, date, gardenSize, plant, plantGrow, endDate, endMonth);

                }

            }
            else if (month == "May" || month == "may")
            {
                int weeksToComplete = 7 * plantGrow;
                int daysLeft = 31 - date;
                int number = daysLeft - weeksToComplete;
                if (number < 0 && number > -31)
                {
                    int endDate = number * -1;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " June");
                    string endMonth = "june";
                    weeds(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number < 0 && number < -30)
                {
                    int endDate = number * -1;
                    endDate = endDate - 30;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " July");
                    string endMonth = "july";
                    weeds(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number == 0)
                {
                    int endDate = 1;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " June");
                    string endMonth = "june";
                    weeds(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number > 0)
                {
                    int endDate = number;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " June");
                    string endMonth = "june";
                    weeds(month, date, gardenSize, plant, plantGrow, endDate, endMonth);

                }
            }
            else if (month == "June" || month == "june")
            {
                int weeksToComplete = 7 * plantGrow;
                int daysLeft = 30 - date;
                int number = daysLeft - weeksToComplete;
                if (number < 0 && number > -32)
                {
                    int endDate = number * -1;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " July");
                    string endMonth = "july";
                    weeds(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number < 0 && number < -31)
                {
                    int endDate = number * -1;
                    endDate = endDate - 31;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " August");
                    string endMonth = "august";
                    weeds(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number == 0)
                {
                    int endDate = 1;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " July");
                    string endMonth = "july";
                    weeds(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number > 0)
                {
                    int endDate = number;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " July");
                    string endMonth = "july";
                    weeds(month, date, gardenSize, plant, plantGrow, endDate, endMonth);

                }

            }
            else if (month == "July" || month == "july")
            {
                int weeksToComplete = 7 * plantGrow;
                int daysLeft = 31 - date;
                int number = daysLeft - weeksToComplete;
                if (number < 0 && number > -32)
                {
                    int endDate = number * -1;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " August");
                    string endMonth = "August";
                    weeds(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number < 0 && number < -31)
                {
                    int endDate = number * -1;
                    endDate = endDate - 31;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " September");
                    string endMonth = "september";
                    weeds(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number == 0)
                {
                    int endDate = 1;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " August");
                    string endMonth = "august";
                    weeds(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number > 0)
                {
                    int endDate = number;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " August");
                    string endMonth = "august";
                    weeds(month, date, gardenSize, plant, plantGrow, endDate, endMonth);

                }

            }
            else if (month == "August" || month == "august")
            {
                int weeksToComplete = 7 * plantGrow;
                int daysLeft = 31 - date;
                int number = daysLeft - weeksToComplete;
                if (number < 0 && number > -31)
                {
                    int endDate = number * -1;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " September");
                    string endMonth = "september";
                    weeds(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number < 0 && number < -30)
                {
                    int endDate = number * -1;
                    endDate = endDate - 30;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " October");
                    string endMonth = "october";
                    weeds(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number == 0)
                {
                    int endDate = 1;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " September");
                    string endMonth = "september";
                    weeds(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number > 0)
                {
                    int endDate = number;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " September");
                    string endMonth = "september";
                    weeds(month, date, gardenSize, plant, plantGrow, endDate, endMonth);

                }

            }
            else if (month == "September" || month == "september")
            {
                int weeksToComplete = 7 * plantGrow;
                int daysLeft = 30 - date;
                int number = daysLeft - weeksToComplete;
                if (number < 0 && number > -32)
                {
                    int endDate = number * -1;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " October");
                    string endMonth = "october";
                    weeds(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number < 0 && number < -31)
                {
                    int endDate = number * -1;
                    endDate = endDate - 31;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " November");
                    string endMonth = "november";
                    weeds(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number == 0)
                {
                    int endDate = 1;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " October");
                    string endMonth = "october";
                    weeds(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number > 0)
                {
                    int endDate = number;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " October");
                    string endMonth = "october";
                    weeds(month, date, gardenSize, plant, plantGrow, endDate, endMonth);

                }


            }
            else if (month == "October" || month == "october")
            {
                int weeksToComplete = 7 * plantGrow;
                int daysLeft = 31 - date;
                int number = daysLeft - weeksToComplete;
                if (number < 0 && number > -31)
                {
                    int endDate = number * -1;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " November");
                    string endMonth = "november";
                    weeds(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number < 0 && number < -30)
                {
                    int endDate = number * -1;
                    endDate = endDate - 30;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " December");
                    string endMonth = "december";
                    weeds(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number == 0)
                {
                    int endDate = 1;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " November");
                    string endMonth = "november";
                    weeds(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number > 0)
                {
                    int endDate = number;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " November");
                    string endMonth = "november";
                    weeds(month, date, gardenSize, plant, plantGrow, endDate, endMonth);

                }

            }
            else if (month == "November" || month == "november")
            {
                int weeksToComplete = 7 * plantGrow;
                int daysLeft = 30 - date;
                int number = daysLeft - weeksToComplete;
                if (number < 0 && number > -31)
                {
                    int endDate = number * -1;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " December");
                    string endMonth = "december";
                    weeds(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number < 0 && number < -31)
                {
                    int endDate = number * -1;
                    endDate = endDate - 31;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " January");
                    string endMonth = "january";
                    weeds(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number == 0)
                {
                    int endDate = 1;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " December");
                    string endMonth = "december";
                    weeds(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number > 0)
                {
                    int endDate = number;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " December");
                    string endMonth = "december";
                    weeds(month, date, gardenSize, plant, plantGrow, endDate, endMonth);

                }

            }
            else if (month == "December" || month == "december")
            {
                int weeksToComplete = 7 * plantGrow;
                int daysLeft = 31 - date;
                int number = daysLeft - weeksToComplete;
                if (number < 0 && number > -31)
                {
                    int endDate = number * -1;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " January");
                    string endMonth = "january";
                    weeds(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number < 0 && number < -31)
                {
                    int endDate = number * -1;
                    endDate = endDate - 31;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " February");
                    string endMonth = "february";
                    weeds(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number == 0)
                {
                    int endDate = 1;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " January");
                    string endMonth = "january";
                    weeds(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number > 0)
                {
                    int endDate = number;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " January");
                    string endMonth = "january";
                    weeds(month, date, gardenSize, plant, plantGrow, endDate, endMonth);

                }

            }
        }
        static void weeds(string month, int date, int gardenSize, string plant, int plantGrow, int endDate, string endMonth)
        {
            System.Threading.Thread.Sleep(2000);
            Random random = new Random();
            int weedsSurvival = random.Next(0, 100);
            Console.WriteLine("Selecting Camera tool and beginning monitoring");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Everything going according to setup....");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine(plant + " growing successfully");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Watering all plants....");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("First Week Complete...");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Weeds appear...");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Trying to remove weeds....");
            if (weedsSurvival > 85)
            {
                Console.WriteLine("Weeds chance of survival: " + weedsSurvival + "%");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Weeds could not be exterminated..");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Plants got sick....");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine(".....Plants Dead....");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Restarting Setup....");
                System.Threading.Thread.Sleep(3000);
                restart();

            }
            else
            {
                Console.WriteLine("Weeds chance of survival: " + weedsSurvival + "%");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Weeds successfully exterminated");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Third Week Complete");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Plants at finall stage");
                watering(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
            }

        }
        static void watering(string month, int date, int gardenSize, string plant, int plantGrow, int endDate, string endMonth)
        {
            Console.WriteLine("Selecting moisture tester tool...");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Measuring moisture...");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Watering plants according to moisture...");
            System.Threading.Thread.Sleep(2000);
            if (month == "january" || month == "february" || month == "december")
            {
                Console.WriteLine("Plants do not require extra watering in: " + month);
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Plants growing slowly.... Recalculating finishing date....");
                plantGrow = plantGrow + 2;
                recalculatingEndDate(month, date, gardenSize, plant, plantGrow);

            }
            else if (month == "march" || month == "april" || month == "may")
            {
                Console.WriteLine("Plants require extra watering in: " + month);
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Plants growing faster.... Recalculating finishing date....");
                recalculatingEndDate(month, date, gardenSize, plant, plantGrow);
                plantGrow = plantGrow - 1;

            }
            else
            {
                Console.WriteLine("Plants require extra watering in: " + month);
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Plants growing as expected...");
                bugs(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
            }

        }
        static void recalculatingEndDate(string month, int date, int gardenSize, string plant, int plantGrow)
        {
            System.Threading.Thread.Sleep(2000);
            if (month == "January" || month == "january")
            {
                int weeksToComplete = 7 * plantGrow;
                int daysLeft = 31 - date;
                int number = daysLeft - weeksToComplete;
                if (number < 0 && number > -30)
                {
                    int endDate = number * -1;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " February");
                    string endMonth = "february";
                    bugs(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number < 0 && number < -29)
                {
                    int endDate = number * -1;
                    endDate = endDate - 29;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " March");
                    string endMonth = "march";
                    bugs(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number == 0)
                {
                    int endDate = 1;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " February");
                    string endMonth = "february";
                    bugs(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number > 0)
                {
                    int endDate = number;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " February");
                    string endMonth = "february";
                    bugs(month, date, gardenSize, plant, plantGrow, endDate, endMonth);

                }
            }
            else if (month == "February" || month == "february")
            {
                int weeksToComplete = 7 * plantGrow;
                int daysLeft = 29 - date;
                int number = daysLeft - weeksToComplete;
                if (number < 0 && number > -32)
                {
                    int endDate = number * -1;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " March");
                    string endMonth = "march";
                    bugs(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number < 0 && number < -31)
                {
                    int endDate = number * -1;
                    endDate = endDate - 31;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " April");
                    string endMonth = "april";
                    bugs(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number == 0)
                {
                    int endDate = 1;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " March");
                    string endMonth = "march";
                    bugs(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number > 0)
                {
                    int endDate = number;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " March");
                    string endMonth = "march";
                    bugs(month, date, gardenSize, plant, plantGrow, endDate, endMonth);

                }


            }
            else if (month == "March" || month == "march")
            {
                int weeksToComplete = 7 * plantGrow;
                int daysLeft = 31 - date;
                int number = daysLeft - weeksToComplete;
                if (number < 0 && number > -31)
                {
                    int endDate = number * -1;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " April");
                    string endMonth = "april";
                    bugs(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number < 0 && number < -30)
                {
                    int endDate = number * -1;
                    endDate = endDate - 30;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " May");
                    string endMonth = "may";
                    bugs(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number == 0)
                {
                    int endDate = 1;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " April");
                    string endMonth = "april";
                    bugs(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number > 0)
                {
                    int endDate = number;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " April");
                    string endMonth = "april";
                    bugs(month, date, gardenSize, plant, plantGrow, endDate, endMonth);

                }

            }
            else if (month == "April" || month == "april")
            {
                int weeksToComplete = 7 * plantGrow;
                int daysLeft = 30 - date;
                int number = daysLeft - weeksToComplete;
                if (number < 0 && number > -32)
                {
                    int endDate = number * -1;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " May");
                    string endMonth = "may";
                    bugs(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number < 0 && number < -31)
                {
                    int endDate = number * -1;
                    endDate = endDate - 31;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " June");
                    string endMonth = "june";
                    bugs(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number == 0)
                {
                    int endDate = 1;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " May");
                    string endMonth = "may";
                    bugs(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number > 0)
                {
                    int endDate = number;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " May");
                    string endMonth = "may";
                    bugs(month, date, gardenSize, plant, plantGrow, endDate, endMonth);

                }

            }
            else if (month == "May" || month == "may")
            {
                int weeksToComplete = 7 * plantGrow;
                int daysLeft = 31 - date;
                int number = daysLeft - weeksToComplete;
                if (number < 0 && number > -31)
                {
                    int endDate = number * -1;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " June");
                    string endMonth = "june";
                    bugs(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number < 0 && number < -30)
                {
                    int endDate = number * -1;
                    endDate = endDate - 30;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " July");
                    string endMonth = "july";
                    bugs(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number == 0)
                {
                    int endDate = 1;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " June");
                    string endMonth = "june";
                    bugs(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number > 0)
                {
                    int endDate = number;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " June");
                    string endMonth = "june";
                    bugs(month, date, gardenSize, plant, plantGrow, endDate, endMonth);

                }
            }
            else if (month == "June" || month == "june")
            {
                int weeksToComplete = 7 * plantGrow;
                int daysLeft = 30 - date;
                int number = daysLeft - weeksToComplete;
                if (number < 0 && number > -32)
                {
                    int endDate = number * -1;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " July");
                    string endMonth = "july";
                    bugs(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number < 0 && number < -31)
                {
                    int endDate = number * -1;
                    endDate = endDate - 31;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " August");
                    string endMonth = "august";
                    bugs(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number == 0)
                {
                    int endDate = 1;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " July");
                    string endMonth = "july";
                    bugs(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number > 0)
                {
                    int endDate = number;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " July");
                    string endMonth = "july";
                    bugs(month, date, gardenSize, plant, plantGrow, endDate, endMonth);

                }

            }
            else if (month == "July" || month == "july")
            {
                int weeksToComplete = 7 * plantGrow;
                int daysLeft = 31 - date;
                int number = daysLeft - weeksToComplete;
                if (number < 0 && number > -32)
                {
                    int endDate = number * -1;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " August");
                    string endMonth = "August";
                    bugs(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number < 0 && number < -31)
                {
                    int endDate = number * -1;
                    endDate = endDate - 31;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " September");
                    string endMonth = "september";
                    bugs(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number == 0)
                {
                    int endDate = 1;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " August");
                    string endMonth = "august";
                    bugs(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number > 0)
                {
                    int endDate = number;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " August");
                    string endMonth = "august";
                    bugs(month, date, gardenSize, plant, plantGrow, endDate, endMonth);

                }

            }
            else if (month == "August" || month == "august")
            {
                int weeksToComplete = 7 * plantGrow;
                int daysLeft = 31 - date;
                int number = daysLeft - weeksToComplete;
                if (number < 0 && number > -31)
                {
                    int endDate = number * -1;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " September");
                    string endMonth = "september";
                    bugs(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number < 0 && number < -30)
                {
                    int endDate = number * -1;
                    endDate = endDate - 30;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " October");
                    string endMonth = "october";
                    bugs(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number == 0)
                {
                    int endDate = 1;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " September");
                    string endMonth = "september";
                    bugs(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number > 0)
                {
                    int endDate = number;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " September");
                    string endMonth = "september";
                    bugs(month, date, gardenSize, plant, plantGrow, endDate, endMonth);

                }

            }
            else if (month == "September" || month == "september")
            {
                int weeksToComplete = 7 * plantGrow;
                int daysLeft = 30 - date;
                int number = daysLeft - weeksToComplete;
                if (number < 0 && number > -32)
                {
                    int endDate = number * -1;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " October");
                    string endMonth = "october";
                    bugs(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number < 0 && number < -31)
                {
                    int endDate = number * -1;
                    endDate = endDate - 31;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " November");
                    string endMonth = "november";
                    bugs(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number == 0)
                {
                    int endDate = 1;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " October");
                    string endMonth = "october";
                    bugs(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number > 0)
                {
                    int endDate = number;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " October");
                    string endMonth = "october";
                    bugs(month, date, gardenSize, plant, plantGrow, endDate, endMonth);

                }


            }
            else if (month == "October" || month == "october")
            {
                int weeksToComplete = 7 * plantGrow;
                int daysLeft = 31 - date;
                int number = daysLeft - weeksToComplete;
                if (number < 0 && number > -31)
                {
                    int endDate = number * -1;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " November");
                    string endMonth = "november";
                    bugs(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number < 0 && number < -30)
                {
                    int endDate = number * -1;
                    endDate = endDate - 30;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " December");
                    string endMonth = "december";
                    bugs(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number == 0)
                {
                    int endDate = 1;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " November");
                    string endMonth = "november";
                    bugs(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number > 0)
                {
                    int endDate = number;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " November");
                    string endMonth = "november";
                    bugs(month, date, gardenSize, plant, plantGrow, endDate, endMonth);

                }

            }
            else if (month == "November" || month == "november")
            {
                int weeksToComplete = 7 * plantGrow;
                int daysLeft = 30 - date;
                int number = daysLeft - weeksToComplete;
                if (number < 0 && number > -31)
                {
                    int endDate = number * -1;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " December");
                    string endMonth = "december";
                    bugs(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number < 0 && number < -31)
                {
                    int endDate = number * -1;
                    endDate = endDate - 31;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " January");
                    string endMonth = "january";
                    bugs(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number == 0)
                {
                    int endDate = 1;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " December");
                    string endMonth = "december";
                    bugs(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number > 0)
                {
                    int endDate = number;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " December");
                    string endMonth = "december";
                    bugs(month, date, gardenSize, plant, plantGrow, endDate, endMonth);

                }

            }
            else if (month == "December" || month == "december")
            {
                int weeksToComplete = 7 * plantGrow;
                int daysLeft = 31 - date;
                int number = daysLeft - weeksToComplete;
                if (number < 0 && number > -31)
                {
                    int endDate = number * -1;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " January");
                    string endMonth = "january";
                    bugs(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number < 0 && number < -31)
                {
                    int endDate = number * -1;
                    endDate = endDate - 31;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " February");
                    string endMonth = "february";
                    bugs(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number == 0)
                {
                    int endDate = 1;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " January");
                    string endMonth = "january";
                    bugs(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
                }
                else if (number > 0)
                {
                    int endDate = number;
                    Console.WriteLine("All the " + plant + " will be ready on: " + endDate + " January");
                    string endMonth = "january";
                    bugs(month, date, gardenSize, plant, plantGrow, endDate, endMonth);

                }

            }
        

    }
        static void bugs(string month, int date, int gardenSize, string plant, int plantGrow, int endDate, string endMonth)
        {
            System.Threading.Thread.Sleep(2000);
            Random random = new Random();
            int BugsSurvival = random.Next(0, 100);

            Console.WriteLine("Bugs appear.....");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Trying to protect plants....");
            if (BugsSurvival > 85)
            {
                Console.WriteLine("bugs chance of destroying plants: " + BugsSurvival + "%");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Bugs could not be stopped..");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine(".....Plants Dead....");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Restarting Setup....");
                System.Threading.Thread.Sleep(3000);
                restart();

            }
            else
            {
                Console.WriteLine("Bugs chance of survival: " + BugsSurvival + "%");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Bugs removed.");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Plants Fully Grown");
                succesfullyGrown(month, date, gardenSize, plant, plantGrow, endDate, endMonth);
            }

        }
        static void succesfullyGrown(string month, int date, int gardenSize, string plant, int plantGrow, int endDate, string endMonth)
        {
            int numberofP = gardenSize * 4;
            Console.WriteLine("......" + "Generating Full Report............");
            System.Threading.Thread.Sleep(4000);
            Console.WriteLine("......" + numberofP + " " +  plant +" were planted on: " +month + " " + date + "......");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("......" + "Required weeks to grow " + plantGrow + "......");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("......" + "Garden Size is: " + gardenSize + "m2 ......");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("......" + "Plants fully grown on : " + endMonth + " " + endDate + "......" );
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("......" + "Restart Setup? (Yes/No)" + "......");
            string answer = Console.ReadLine();
            if (answer == "Yes" || answer =="yes")
            {
                restart();
            }
            else if (answer =="No" || answer =="no")
            {
                Console.WriteLine("Exiting....");
                Console.WriteLine("Press Any Key To Close...");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Unknown Answer... Exiting");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Press Any Key To Close...");
                Console.ReadLine();
            }
        }
    }
}
