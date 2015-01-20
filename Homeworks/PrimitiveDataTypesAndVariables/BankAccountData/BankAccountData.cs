using System;

//Problem 11. Bank Account Data

//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
//Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

class BankAccountData
{
    static void Main()
    {
        string firstName = "Traqn";
        string middleName = "Emilov";
        string lastName = "Zlatanov";

        Decimal balance = 1000;

        string bankName = "United Bulgarian Bank";
        string IBAN = "BG80 BNBG 9661 1020 3456 78";

        long americanExpress = 378282246310005;
        long dinersClub = 30569309025904;
        long masterCard = 5555555555554444;
    }
}

