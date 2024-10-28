using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region PrintCommend

            Console.Write("Hello");
            Console.WriteLine("Hello World");


            Console.WriteLine(">>> Restaurant Menu <<<");
            Console.WriteLine();
            Console.WriteLine("1-Soups");
            Console.WriteLine("2-Main Dishes");
            Console.WriteLine("3-Entrees");
            Console.WriteLine("4-Salads");
            Console.WriteLine("5-Desserts");
            Console.WriteLine("6-Drinks");


            #endregion

            #region StringVariables

            string customerName;
            string customerSurname;
            string customerPhone;
            string customerEmail, customerDistrict, customerCity;

            customerName = "Alperen";
            customerSurname = "İnel";
            customerPhone = "+90 555 444 33 22";
            customerEmail = "mymailaddress@gmail.com";
            customerDistrict = "Greenwich";
            customerCity = "London";

            Console.WriteLine(">>> Reservation Card <<<");
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Customer: " + customerName + " " + customerSurname);
            Console.WriteLine("Communication: " + customerPhone);
            Console.WriteLine("Email Address: " + customerEmail);
            Console.WriteLine("Addres: " + customerDistrict + "/" + customerCity);
            Console.WriteLine("-------------------------------------------------");

            #endregion

            #region IntVariables

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("**** Restaurant Menu Prices ****");
            Console.WriteLine();
            Console.WriteLine("-----Hamburger: " + hamburgerPrice + " TL");
            Console.WriteLine("-----Pizza: " + pizzaPrice + " TL");
            Console.WriteLine("-----Cola: " + cokePrice + " TL");
            Console.WriteLine("-----Limonade: " + lemonadePrice + " TL");
            Console.WriteLine("-----Fries: " + friesPrice + " TL");
            Console.WriteLine("-----Water: " + waterPrice + " TL");

            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamgurgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamgurgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Hamburger Price: " + totalHamgurgerPrice + " TL");
            Console.WriteLine("Pizza Price: " + totalPizzaPrice + " TL");
            Console.WriteLine("Fries Price: " + totalFriesPrice + " TL");
            Console.WriteLine("Cola Price: " + totalCokePrice + " TL");
            Console.WriteLine("Limonade Price: " + totalLemonadePrice + " TL");
            Console.WriteLine("Water Price: " + totalWaterPrice + " TL");

            Console.WriteLine();

            int totalPrice = totalCokePrice + totalWaterPrice + totalLemonadePrice + totalHamgurgerPrice + totalPizzaPrice + totalFriesPrice;

            Console.WriteLine("Total Price: " + totalPrice + " TL");

            #endregion
            Console.Read();
        }
    }
}
