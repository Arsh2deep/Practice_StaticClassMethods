namespace Practice_StaticClassMethods
{
    public class Transaction
    {
        DateTime _now = DateTime.Now;
        string _name;
        double _amount;

        public Transaction(string name, double amount)
        {
            _name = name;
            _amount = amount;
        }

        public string Name => _name;
        public double Amount => _amount;

        public override string ToString()
        {
            return $"{_name} - {_now.ToShortDateString()} - {_amount.ToString("c")}";
        }

    }//Class

}//NameSpace