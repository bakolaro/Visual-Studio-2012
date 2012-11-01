using System;

/* A bank account has a holder name(first name, middle name and
 * last name), available amount of money(balance), bank name, IBAN,
 * BIC code and 3 credit card numbers associated with the account.
 * Declare the variables needed to keep the information for a single
 * bank account using the appropriate data types and descriptive
 * names.
 */

class BankAccountDetails
{
   static void Main()
   {
      string firstName = "Martin", secondName = "Samuel",
         lastName = "Robinson";
      decimal blance = 12308.95m;
      string bank = "EUROBANK EFG BULGARIA";
      string iban = "BG39 BPBI 6100 1068 0032 01";
      string bic = "BPBIBGSF";
      string[] cardNumbers = new string[] {"4556119000017",
         "4916060000581", "4716400000444"};

      Console.WriteLine("{0} {1} {2} \r\n" +
                         "Balance: {3} BGN at {4} \r\n" +
                         "IBAN: {5}, BIC: {6} \r\n" +
                         "Credit-card numbers: {7}, {8}, {9}",
                         firstName, secondName, lastName,
                         blance, bank, iban, bic, cardNumbers[0],
                         cardNumbers[1], cardNumbers[2]);
   }
}