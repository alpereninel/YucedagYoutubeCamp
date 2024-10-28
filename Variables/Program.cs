using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DoubleVariables

            double number;
            number = 3.7;
            Console.WriteLine(number);

            Console.WriteLine(">>> Price List <<<");
            Console.WriteLine();

            double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            applePrice = 10.50;
            orangePrice = 20.75;
            strawberryPrice = 100;
            potatoPrice = 6.12;
            tomatoPrice = 26.33;

            Console.WriteLine("---- Apple Price (kg) :" + applePrice + " TL");
            Console.WriteLine("---- Orange Price (kg):" + orangePrice + " TL");
            Console.WriteLine("---- Strawberry Price (kg):" + strawberryPrice + " TL");
            Console.WriteLine("---- Patato Price (kg):" + potatoPrice + " TL");
            Console.WriteLine("---- Tomato Price (kg):" + tomatoPrice + " TL");

            Console.WriteLine();
            Console.WriteLine();

            double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            appleGram = 1.245;
            orangeGram = 2.650;
            strawberryGram = 0.750;
            potatoGram = 4.859;
            tomatoGram = 3.745;

            double appleTotalPrice = appleGram * applePrice;
            double orangeTotalPrice = orangeGram * orangePrice;
            double strawberryTotalPrice = strawberryGram * strawberryPrice;
            double potatoTotalPrice = potatoGram * potatoPrice;
            double tomatoTotalPrice = tomatoGram * tomatoPrice;

            Console.WriteLine("Purchased Product: Apple - " + "Price per kilogram: " + applePrice + " - Gramaj: " + appleGram + " - Toplam Tutar: " + appleTotalPrice);

            Console.WriteLine("Purchased Product: Orange - " + "Price per kilogram: " + orangePrice + " - Gramaj: " + orangeGram + " - Toplam Tutar: " + orangeTotalPrice);

            Console.WriteLine("Purchased Product: Strawberry - " + "Price per kilogram: " + strawberryPrice + " - Gramaj: " + strawberryGram + " - Toplam Tutar: " + strawberryTotalPrice);

            Console.WriteLine("Purchased Product: Patato - " + "Price per kilogram: " + potatoPrice + " - Gramaj: " + potatoGram + " - Toplam Tutar: " + potatoTotalPrice);

            Console.WriteLine("Purchased Product: Tomato - " + "Price per kilogram: " + tomatoPrice + " - Gramaj: " + tomatoGram + " - Toplam Tutar: " + tomatoTotalPrice);

            double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + tomatoTotalPrice + potatoTotalPrice;

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Total Price of shopping" + shoppingTotalPrice + " TL");

            #endregion

            #region CharVariables

            char symbol;
            symbol = 'a';

            Console.WriteLine(symbol);

            #endregion

            #region KeyboardDataEntryStringVariables

            Console.WriteLine("**** Passenger Information ****");
            Console.WriteLine();

            string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            Console.Write("Name: ");
            passengerName = Console.ReadLine();

            Console.Write("Surname: ");
            passengerSurname = Console.ReadLine();

            Console.Write("District: ");
            passengerDistrict = Console.ReadLine();

            Console.Write("City: ");
            passengerCity = Console.ReadLine();

            Console.Write("Age: ");
            passengerAge = Console.ReadLine();

            Console.Write("Yolcu TC Kimlik No: ");
            passengerIdentityNumber = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("-----------------------");
            Console.WriteLine("Yolcu TC Kimlik No: " + passengerIdentityNumber + " - Yolcu Ad Soyad: " + passengerName + " " + passengerSurname + " " + passengerDistrict + " / " + passengerCity + " " + passengerAge);

            #endregion

            #region IntegerEntryandConversionsfromtheKeyboard

            int shoesPrice, computerPrice, chairPrice, tvPrice;
            shoesPrice = 1000;
            computerPrice = 20000;
            chairPrice = 5000;
            tvPrice = 12000;

            int shoesCount, computerCount, chairCount, tvCount;

            Console.Write("Please enter the number of shoes you purchased: ");
            shoesCount = int.Parse(Console.ReadLine());

            Console.Write("Please enter the number of computers you purchased: ");
            computerCount = int.Parse(Console.ReadLine());

            Console.Write("Please enter the number of chairs you purchased: ");
            chairCount = int.Parse(Console.ReadLine());

            Console.Write("Please enter the number of television you purchased: ");
            tvCount = int.Parse(Console.ReadLine());

            int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;

            Console.WriteLine();
            Console.WriteLine("Total Price: " + totalPrice);

            #endregion

            #region DecimalNumberOperationsfromtheKeyboard

            double exam1, exam2, exam3, result;

            Console.Write("Enter your exam grade 1: ");
            exam1 = double.Parse(Console.ReadLine());

            Console.Write("Enter your exam grade 1: ");
            exam2 = double.Parse(Console.ReadLine());

            Console.Write("Enter your exam grade 1: ");
            exam3 = double.Parse(Console.ReadLine());

            result = (exam1 + exam2 + exam3) / 3;

            Console.WriteLine();
            Console.WriteLine("Your Exam Average " + result);

            #endregion

            #region CharacterEntryfromKeyboard

            char gender;
            Console.Write("Select Gender: ");
            gender = char.Parse(Console.ReadLine());
            Console.WriteLine("Selected Gender: " + gender);

            #endregion

            Console.Read();
        }
    }
}
