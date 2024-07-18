namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintMsg msg = new PrintMsg();
            msg.displayMsg();

            ArithmeticOperation op = new ArithmeticOperation();
            op.arithmeticOp();

            ArithmeticOpUsingChoice op1 = new ArithmeticOpUsingChoice();
            op1.arithmeticOperation();

            DisplayName name = new DisplayName();
            name.displayName();

            EvenNumbers even = new EvenNumbers();
            even.displayEvenNumbers();

            OddNumbers odd = new OddNumbers();
            odd.displayOddNumbers();

            DisplayTable table = new DisplayTable();
            table.DisplayTableOfNumber();

            DisplayNumberWithGap num = new DisplayNumberWithGap();
            num.displayNum();

             DisplayIntegerOneLine a = new DisplayIntegerOneLine();
            a.displayInteger();

            DisplayIntegerSeparateLine b = new DisplayIntegerSeparateLine();
            b.displayNum();

        }
    }
}
