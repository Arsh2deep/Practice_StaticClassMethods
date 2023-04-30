namespace Practice_StaticClassMethods;
class Program
{
    static void Main(string[] args)
    {
       DailyTransactions.AddTransaction(new Transaction("Banana", 2.00));
       DailyTransactions.AddTransaction(new Transaction("Nuts", 6.00));
       DailyTransactions.AddTransaction(new Transaction("Flour", 5.00));
       DailyTransactions.AddTransaction(new Transaction("Sugar", 5.00));
       DailyTransactions.AddTransaction(new Transaction("Yeast", 2.00));
       DailyTransactions.DisplayAllInfo();
        
    }//Main

}//Class

