////////// PB-CSharp-Nested-Conditional-Statements-Lab //////////
/// 01. Day of Week
using System;

namespace ConditionalStatementsAdvancedLab
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string day = "";
            switch (number)
            {
                case 1:
                    day = "Monday";
                    break;
                case 2:
                    day = "Tuesday";
                    break;
                case 3:
                    day = "Wednesday";
                    break;
                case 4:
                    day = "Thursday";
                    break;
                case 5:
                    day = "Friday";
                    break;
                case 6:
                    day = "Saturday";
                    break;
                case 7:
                    day = "Sunday";
                    break;
                default:
                    day = "Error";
                    break;
            }
            Console.WriteLine(day);
        }
    }
}

/// 02. Weekend or Working Day
using System;

namespace ConditionalStatementsAdvancedLab
{
    class WeekendOrWorkingDay

    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            string weekendOrWorkingDay = "";
            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    weekendOrWorkingDay = "Working day";
                    break;
                case "Saturday":
                case "Sunday":
                    weekendOrWorkingDay = "Weekend";
                    break;
                default:
                    weekendOrWorkingDay = "Error";
                    break;
            }
            Console.WriteLine(weekendOrWorkingDay);
        }
    }
}

/// 03. Animal Type
using System;

namespace ConditionalStatementsAdvancedLab
{
    class AnimalType
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string animalType = "";
            switch (name)
            {
                case "dog":
                    animalType = "mammal";
                    break;
                case "crocodile":
                case "tortoise":
                case "snake":
                    animalType = "reptile";
                    break;
                default:
                    animalType = "unknown";
                    break;
            }
            Console.WriteLine(animalType);
        }
    }
}

/// 04. Personal Titles
using System;

namespace ConditionalStatementsAdvancedLab
{
    class PersonalTitles

    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            char gender = Console.ReadLine()[0];
            string text = "";
            if (age >= 16)
            {
                if (gender == 'm')
                {
                    text = "Mr.";
                }
                else
                {
                    text = "Ms.";
                }
            }
            else
            {
                if (gender == 'f')
                {
                    text = "Miss";
                }
                else
                {
                    text = "Master";
                }
            }
            Console.WriteLine(text);
        }
    }
}

/// 05. Small Shop
using System;

namespace ConditionalStatementsAdvancedLab
{
    class SmallShop

    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double productPrice = 0;
            switch (product)
            {
                case "coffee":
                    if (city == "Sofia")
                    {
                        productPrice = 0.50;
                    }
                    else if (city == "Plovdiv")
                    {
                        productPrice = 0.40;
                    }
                    else if (city == "Varna")
                    {
                        productPrice = 0.45;
                    };
                    break;
                case "water":
                    if (city == "Sofia")
                    {
                        productPrice = 0.80;
                    }
                    else if (city == "Plovdiv")
                    {
                        productPrice = 0.70;
                    }
                    else if (city == "Varna")
                    {
                        productPrice = 0.70;
                    };
                    break;
                case "beer":
                    if (city == "Sofia")
                    {
                        productPrice = 1.20;
                    }
                    else if (city == "Plovdiv")
                    {
                        productPrice = 1.15;
                    }
                    else if (city == "Varna")
                    {
                        productPrice = 1.10;
                    };
                    break;
                case "sweets":
                    if (city == "Sofia")
                    {
                        productPrice = 1.45;
                    }
                    else if (city == "Plovdiv")
                    {
                        productPrice = 1.30;
                    }
                    else if (city == "Varna")
                    {
                        productPrice = 1.35;
                    };
                    break;
                case "peanuts":
                    if (city == "Sofia")
                    {
                        productPrice = 1.60;
                    }
                    else if (city == "Plovdiv")
                    {
                        productPrice = 1.50;
                    }
                    else if (city == "Varna")
                    {
                        productPrice = 1.55;
                    };
                    break;
            }
            Console.WriteLine(quantity * productPrice);
        }
    }
}

/// 06. Number in Range
using System;

namespace ConditionalStatementsAdvancedLab
{
    class NumberInRange

    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string response = "";
            if (number != 0 && number >= -100 && number <= 100)
            {
                response = "Yes";
            }
            else
            {
                response = "No";
            }
            Console.WriteLine(response);
        }
    }
}

/// 07. Working Hours
using System;

namespace ConditionalStatementsAdvancedLab
{
    class WorkingHours

    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();
            string openOrClose = "";
            bool workingDay = false;
            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                case "Saturday":
                    workingDay = true;
                    break;
            }
            if (workingDay && hour >= 10 && hour <= 18)
            {
                openOrClose = "open";
            }
            else
            {
                openOrClose = "closed";
            }
            Console.WriteLine(openOrClose);
        }
    }
}

/// 08. Cinema Ticket
using System;

namespace ConditionalStatementsAdvancedLab
{
    class CinemaTicket

    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            int price = 0;
            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Friday":
                    price = 12;
                    break;
                case "Wednesday":
                case "Thursday":
                    price = 14;
                    break;
                case "Saturday":
                case "Sunday":
                    price = 16;
                    break;
            }
            Console.WriteLine(price);
        }
    }
}

/// 09. Fruit or Vegetable
using System;

namespace ConditionalStatementsAdvancedLab
{
    class FruitOrVegetable

    {
        static void Main(string[] args)
        {
            string fruitOrVegetable = Console.ReadLine();
            string response = "";
            switch (fruitOrVegetable)
            {
                case "banana":
                case "apple":
                case "kiwi":
                case "cherry":
                case "lemon":
                case "grapes":
                    response = "fruit";
                    break;
                case "tomato":
                case "cucumber":
                case "pepper":
                case "carrot":
                    response = "vegetable";
                    break;
                default:
                    response = "unknown";
                    break;
            }
            Console.WriteLine(response);
        }
    }
}

/// 10. Invalid Number
using System;

namespace ConditionalStatementsAdvancedLab
{
    class InvalidNumber

    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if (!(number == 0 || (number >= 100 && number <= 200)))
            {
                Console.WriteLine("invalid");
            }
        }
    }
}

/// 11. Fruit Shop
using System;

namespace ConditionalStatementsAdvancedLab
{
    class FruitShop

    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            bool isOnWeekdays = false;
            bool isError = false;
            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    isOnWeekdays = true;
                    break;
                case "Saturday":
                case "Sunday":
                    isOnWeekdays = false;
                    break;
                default:
                    isError = true;
                    break;
            }
            double calculatedPrice = 0;
            if (!isError)
            {
                if (isOnWeekdays)
                {
                    switch (fruit)
                    {
                        case "banana":
                            calculatedPrice = quantity * 2.50;
                            break;
                        case "apple":
                            calculatedPrice = quantity * 1.20;
                            break;
                        case "orange":
                            calculatedPrice = quantity * 0.85;
                            break;
                        case "grapefruit":
                            calculatedPrice = quantity * 1.45;
                            break;
                        case "kiwi":
                            calculatedPrice = quantity * 2.70;
                            break;
                        case "pineapple":
                            calculatedPrice = quantity * 5.50;
                            break;
                        case "grapes":
                            calculatedPrice = quantity * 3.85;
                            break;
                        default:
                            isError = true;
                            break;
                    }
                }
                else
                {
                    switch (fruit)
                    {
                        case "banana":
                            calculatedPrice = quantity * 2.70;
                            break;
                        case "apple":
                            calculatedPrice = quantity * 1.25;
                            break;
                        case "orange":
                            calculatedPrice = quantity * 0.90;
                            break;
                        case "grapefruit":
                            calculatedPrice = quantity * 1.60;
                            break;
                        case "kiwi":
                            calculatedPrice = quantity * 3.00;
                            break;
                        case "pineapple":
                            calculatedPrice = quantity * 5.60;
                            break;
                        case "grapes":
                            calculatedPrice = quantity * 4.20;
                            break;
                        default:
                            isError = true;
                            break;
                    }
                }
            }
            if (isError)
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine($"{calculatedPrice:F2}");
            }
        }
    }
}

/// 12. Trade Commissions
using System;

namespace ConditionalStatementsAdvancedLab
{
    class TradeCommissions

    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            bool hasError = false;
            double percentOfSales = 0;
            if (city == "Sofia")
            {
                if (sales < 0)
                {
                    hasError = true;
                }
                else if (sales >= 0 && sales <= 500)
                {
                    percentOfSales = 5;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    percentOfSales = 7;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    percentOfSales = 8;
                }
                else
                {
                    percentOfSales = 12;
                }
            }
            else if (city == "Varna")
            {
                if (sales < 0)
                {
                    hasError = true;
                }
                else if (sales >= 0 && sales <= 500)
                {
                    percentOfSales = 4.5;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    percentOfSales = 7.5;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    percentOfSales = 10;
                }
                else
                {
                    percentOfSales = 13;
                }
            }
            else if (city == "Plovdiv")
            {
                if (sales < 0)
                {
                    hasError = true;
                }
                else if (sales >= 0 && sales <= 500)
                {
                    percentOfSales = 5.5;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    percentOfSales = 8;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    percentOfSales = 12;
                }
                else
                {
                    percentOfSales = 14.5;
                }
            }
            else
            {
                hasError = true;
            }
            if (hasError)
            {
                Console.WriteLine("error");
            }
            else
            {
                double commission = sales * (percentOfSales / 100);
                Console.WriteLine($"{commission:F2}");
            }
        }
    }
}

/// 13. Ski Trip
using System;

namespace ConditionalStatementsAdvancedLab
{
    class SkiTrip

    {
        static void Main(string[] args)
        {
            int daysToStay = int.Parse(Console.ReadLine());
            string typeOfRoom = Console.ReadLine();
            string rating = Console.ReadLine();
            double priceForHotelStay = 0;
            int nights = daysToStay - 1;
            if (typeOfRoom == "room for one person")
            {
                int priceForNight = 18;
                priceForHotelStay = nights * priceForNight;
            }
            else if (typeOfRoom == "apartment")
            {
                int priceForNight = 25;
                priceForHotelStay = nights * priceForNight;
                if (nights < 10)
                {
                    priceForHotelStay -= priceForHotelStay * 0.30;
                }
                else if (nights >= 10 && nights <= 15)
                {
                    priceForHotelStay -= priceForHotelStay * 0.35;
                }
                else
                {
                    priceForHotelStay -= priceForHotelStay * 0.50;
                }
            }
            else if (typeOfRoom == "president apartment")
            {
                int priceForNight = 35;
                priceForHotelStay = nights * priceForNight;
                if (nights < 10)
                {
                    priceForHotelStay -= priceForHotelStay * 0.10;
                }
                else if (nights >= 10 && nights <= 15)
                {
                    priceForHotelStay -= priceForHotelStay * 0.15;
                }
                else
                {
                    priceForHotelStay -= priceForHotelStay * 0.20;
                }
            }
            if (rating == "positive")
            {
                priceForHotelStay += priceForHotelStay * 0.25;
            }
            else
            {
                priceForHotelStay -= priceForHotelStay * 0.10;
            }
            Console.WriteLine($"{priceForHotelStay:F2}");
        }
    }
}


////////// PB-CSharp-Nested-Conditional-Statements-Еxercise //////////
/// 01. Cinema
using System;

namespace ConditionalStatementsAdvancedЕxercise
{
    class Cinema

    {
        static void Main(string[] args)
        {
            string typeOfProjection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            double total = 0;
            if (typeOfProjection == "Premiere")
            {
                total = rows * columns * 12.00;
            }
            else if (typeOfProjection == "Normal")
            {
                total = rows * columns * 7.50;
            }
            else if (typeOfProjection == "Discount")
            {
                total = rows * columns * 5.00;
            }
            Console.WriteLine($"{total:F2} leva");
        }
    }
}

/// 02. Summer Outfit
using System;

namespace ConditionalStatementsAdvancedЕxercise
{
    class SummerOutfit

    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string timeFromDay = Console.ReadLine();
            string outfit = "";
            string shoes = "";
            if (timeFromDay == "Morning")
            {
                if (degrees >= 10 && degrees <= 18)
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (degrees > 18 && degrees <= 24)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
            }
            else if (timeFromDay == "Afternoon")
            {
                if (degrees >= 10 && degrees <= 18)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (degrees > 18 && degrees <= 24)
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
            }
            else
            {
                outfit = "Shirt";
                shoes = "Moccasins";
            }
            Console.WriteLine($"It\'s {degrees} degrees, get your {outfit} and {shoes}.");
        }
    }
}

/// 03. New House
using System;

namespace ConditionalStatementsAdvancedЕxercise
{
    class NewHouse

    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double totalCost = 0;
            switch (flower)
            {
                case "Roses":
                    totalCost = quantity * 5;
                    if (quantity > 80)
                    {
                        totalCost -= totalCost * 0.10;
                    }
                    break;
                case "Dahlias":
                    totalCost = quantity * 3.80;
                    if (quantity > 90)
                    {
                        totalCost -= totalCost * 0.15;
                    }
                    break;
                case "Tulips":
                    totalCost = quantity * 2.80;
                    if (quantity > 80)
                    {
                        totalCost -= totalCost * 0.15;
                    }
                    break;
                case "Narcissus":
                    totalCost = quantity * 3;
                    if (quantity < 120)
                    {
                        totalCost += totalCost * 0.15;
                    }
                    break;
                case "Gladiolus":
                    totalCost = quantity * 2.50;
                    if (quantity < 80)
                    {
                        totalCost += totalCost * 0.20;
                    }
                    break;
            }
            if (budget >= totalCost)
            {
                Console.WriteLine($"Hey, you have a great garden with {quantity} {flower} and {(budget - totalCost):F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {(totalCost - budget):F2} leva more.");
            }
        }
    }
}

/// 04. Fishing Boat
using System;

namespace ConditionalStatementsAdvancedЕxercise
{
    class FishingBoat

    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numberOfFishermen = int.Parse(Console.ReadLine());
            double costForRent = 0;
            if (season == "Spring")
            {
                costForRent = 3000;
            }
            else if (season == "Summer" || season == "Autumn")
            {
                costForRent = 4200;
            }
            else
            {
                costForRent = 2600;
            }
            if (numberOfFishermen >= 0 && numberOfFishermen <= 6)
            {
                costForRent = costForRent * 0.90;
            }
            else if (numberOfFishermen > 6 && numberOfFishermen <= 11)
            {
                costForRent = costForRent * 0.85;
            }
            else if (numberOfFishermen >= 12)
            {
                costForRent = costForRent * 0.75;
            }
            if (numberOfFishermen % 2 == 0 && season != "Autumn")
            {
                costForRent = costForRent * 0.95;
            }
            if (budget >= costForRent)
            {
                Console.WriteLine($"Yes! You have {(budget - costForRent):F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(costForRent - budget):F2} leva.");
            }
        }
    }
}

/// 05. Journey
using System;

namespace ConditionalStatementsAdvancedЕxercise
{
    class Journey

    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string journey = "";
            string campOrHotel = "";
            double spentBudget = 0;
            if (budget <= 100 && season == "summer")
            {
                journey = "Somewhere in Bulgaria";
                spentBudget = budget * 0.30;
                campOrHotel = "Camp";
            }
            else if (budget <= 100 && season == "winter")
            {
                journey = "Somewhere in Bulgaria";
                spentBudget = budget * 0.70;
                campOrHotel = "Hotel";
            }
            else if (budget > 100 && budget <= 1000 && season == "summer")
            {
                journey = "Somewhere in Balkans";
                spentBudget = budget * 0.40;
                campOrHotel = "Camp";
            }
            else if (budget > 100 && budget <= 1000 && season == "winter")
            {
                journey = "Somewhere in Balkans";
                spentBudget = budget * 0.80;
                campOrHotel = "Hotel";
            }
            else
            {
                journey = "Somewhere in Europe";
                spentBudget = budget * 0.90;
                campOrHotel = "Hotel";
            }
            Console.WriteLine(journey);
            Console.WriteLine($"{campOrHotel} - {spentBudget:F2}");
        }
    }
}

/// 06. Operations Between Numbers
using System;

namespace ConditionalStatementsAdvancedЕxercise
{
    class OperationsBetweenNumbers

    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            char arithmeticOperator = Console.ReadLine()[0];
            double result = 0;
            string evenOrOdd = "";
            if (arithmeticOperator == '+' || arithmeticOperator == '-' || arithmeticOperator == '*')
            {
                if (arithmeticOperator == '+')
                {
                    result = n1 + n2;
                }
                else if (arithmeticOperator == '-')
                {
                    result = n1 - n2;
                }
                else
                {
                    result = n1 * n2;
                }
                if (result % 2 == 0)
                {
                    evenOrOdd = "even";
                }
                else
                {
                    evenOrOdd = "odd";
                }
                Console.WriteLine($"{n1} {arithmeticOperator} {n2} = {result} - {evenOrOdd}");
            }
            else
            {
                if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
                else
                {
                    if (arithmeticOperator == '/')
                    {
                        result = (n1 / n2);
                        Console.WriteLine($"{n1} {arithmeticOperator} {n2} = {result:F2}");
                    }
                    else
                    {
                        result = n1 % n2;
                        Console.WriteLine($"{n1} {arithmeticOperator} {n2} = {result}");
                    }
                }
            }
        }
    }
}

/// 07. Hotel Room
using System;

namespace ConditionalStatementsAdvancedЕxercise
{
    class HotelRoom

    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double costForApartment = 0;
            double costForStudio = 0;
            if (month == "May" || month == "October")
            {
                if (nights > 7 && nights <= 14)
                {
                    costForApartment = nights * 65;
                    costForStudio = nights * 50 * 0.95;
                }
                else if (nights > 14)
                {
                    costForApartment = nights * 65 * 0.90;
                    costForStudio = nights * 50 * 0.70;
                }
                else
                {
                    costForApartment = nights * 65;
                    costForStudio = nights * 50;
                }
            }
            else if (month == "June" || month == "September")
            {
                if (nights > 14)
                {
                    costForApartment = nights * 68.70 * 0.90;
                    costForStudio = nights * 75.20 * 0.80;
                }
                else
                {
                    costForApartment = nights * 68.70;
                    costForStudio = nights * 75.20;
                }
            }
            else if (month == "July" || month == "August")
            {
                if (nights > 14)
                {
                    costForApartment = nights * 77 * 0.90;
                    costForStudio = nights * 76;
                }
                else
                {
                    costForApartment = nights * 77;
                    costForStudio = nights * 76;
                }
            }
            Console.WriteLine($"Apartment: {costForApartment:F2} lv.");
            Console.WriteLine($"Studio: {costForStudio:F2} lv.");
        }
    }
}

/// 08. On Time for the Exam
using System;

namespace ConditionalStatementsAdvancedЕxercise
{
    class OnTimefortheExam

    {
        static void Main(string[] args)
        {
            int hourOfExam = int.Parse(Console.ReadLine());
            int minutesOfExam = int.Parse(Console.ReadLine());
            int hourOfArrival = int.Parse(Console.ReadLine());
            int minutesOfArrival = int.Parse(Console.ReadLine());
            double totalMinutesExam = hourOfExam * 60 + minutesOfExam;
            double totalMinutes = hourOfArrival * 60 + minutesOfArrival;
            if (totalMinutesExam < totalMinutes)
            {
                Console.WriteLine("Late");
                if (totalMinutesExam > totalMinutes - 60)
                {
                    Console.WriteLine(totalMinutes - totalMinutesExam + " minutes after the start");
                }
                else
                {
                    double restOfMinutes = totalMinutes - totalMinutesExam;
                    int hour = (int)(restOfMinutes / 60);
                    int minutes = (int)(restOfMinutes % 60);
                    if (minutes >= 10)
                    {
                        Console.WriteLine(hour + ":" + minutes + " hours after the start");
                    }
                    else
                    {
                        Console.WriteLine(hour + ":0" + minutes + " hours after the start");
                    }
                }
            }
            else if (totalMinutesExam >= totalMinutes && totalMinutesExam <= totalMinutes + 30)
            {
                Console.WriteLine("On time");
                if (totalMinutesExam - totalMinutes > 0)
                {
                    Console.WriteLine(totalMinutesExam - totalMinutes + " minutes before the start");
                }
            }
            else
            {
                Console.WriteLine("Early");
                if (totalMinutesExam - totalMinutes < 60)
                {
                    Console.WriteLine(totalMinutesExam - totalMinutes + " minutes before the start");
                }
                else
                {
                    double restOfMinutes = totalMinutesExam - totalMinutes;
                    int hour = (int)(restOfMinutes / 60);
                    int minutes = (int)(restOfMinutes % 60);
                    if (minutes >= 10)
                    {
                        Console.WriteLine(hour + ":" + minutes + " hours before the start");
                    }
                    else
                    {
                        Console.WriteLine(hour + ":0" + minutes + " hours before the start");
                    }
                }
            }
        }
    }
}

/// 9. Volleyball
using System;

namespace ConditionalStatementsAdvancedЕxercise
{
    class Volleyball

    {
        static void Main(string[] args)
        {
            string leapYearOrNot = Console.ReadLine();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            double gameSaturday = (double)(48 - h) * 3 / 4;
            double gameHolidays = (double)p * 2 / 3;
            double totalGame = gameSaturday + h + gameHolidays;
            if (leapYearOrNot == "leap")
            {
                totalGame = totalGame * 1.15;
            }
            Console.WriteLine($"{Math.Floor(totalGame)}");
        }
    }
}
