using System;
#pragma warning disable 219

namespace WebShopV05
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            double netPriceBook = 30;
            double netPriceDVD = 50;
            double netPriceGame = 100;

            int noOfBooksInOrder = 23;
            int noOfDVDsInOrder = 16;
            int noOfGamesInOrder = 7;

            double totalPriceBook = noOfBooksInOrder * netPriceBook;
            double totalPriceDVD = noOfDVDsInOrder * netPriceDVD;
            double totalPriceGame = noOfGamesInOrder * netPriceGame;

            double totalPrice = totalPriceBook + totalPriceDVD + totalPriceGame; // This variable should contain the total price for the order

            double VAT = totalPrice * 0.10;
            double shipping = 49;
            double creditcardFee = (totalPrice + VAT + shipping) * 0.02;

            double finalPrice = totalPrice + VAT + shipping + creditcardFee;

            Console.WriteLine($"You ordered {noOfBooksInOrder} books, {noOfDVDsInOrder} DVDs and {noOfGamesInOrder} games");
            Console.WriteLine($"Total cost including tax, shipping and credit card fee: {finalPrice} kr.");

            // The LAST line of code should be ABOVE this line
        }
    }
}