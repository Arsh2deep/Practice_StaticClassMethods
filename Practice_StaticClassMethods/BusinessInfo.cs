namespace Practice_StaticClassMethods
{
    public class BusinessInfo
    {
        static string _businessName = "The 5 Dollar Banana Bakery";
        static double _taxAmount = 0.1;

        static BusinessInfo()
        {
           
        }//Constructor

        public static string BusinessName => _businessName;
        public static double TaxAmount => _taxAmount;

    }//Class

}//NameSpace