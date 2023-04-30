namespace Practice_StaticClassMethods
{
    public class DailyTransactions
    {
        static List<Transaction> _transactions;

        static DailyTransactions()
        {
            _transactions = new List<Transaction>();
        }

        public static void AddTransaction(Transaction transaction)
        {
            _transactions.Add(transaction);
        }

        public static double CalculateTotal()
        {
            double total = 0;
            foreach (Transaction t in _transactions)
            {
                total += t.Amount;
            }
            return total + (total * BusinessInfo.TaxAmount);
        }

        public static void DisplayAllInfo()
        {
            Console.WriteLine(BusinessInfo.BusinessName);
            Console.WriteLine("Your purchases were");
            foreach (Transaction t in _transactions)
            {
                Console.WriteLine(t.ToString());
            }
            Console.WriteLine($"Tax is {BusinessInfo.TaxAmount}");
            Console.WriteLine($"The total was: {CalculateTotal().ToString("c")}");
        }//Display Method

    }//Class
}//Namespace