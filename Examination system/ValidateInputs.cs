namespace Examination_system
{
    static class ValidateInputs
    {
        // Read String From User
        static public string PromptForNonEmptyString(string message)
        {
            string input;
            do
            {
                Console.WriteLine(message);
                input = Console.ReadLine();
            } while (string.IsNullOrEmpty(input));
            return input;
        }

        // Read Decimal From User
        static public decimal PromptForPositiveDecimal(string message)
        {
            decimal value;
            do
            {
                Console.WriteLine(message);
            } while (!decimal.TryParse(Console.ReadLine(), out value) || value <= 0);
            return value;
        }
        
        // Read Int From User
        static public int PromptForPositiveInt(string message)
        {
            int value;
            do
            {
                Console.WriteLine(message);
            } while (!int.TryParse(Console.ReadLine(), out value) || value <= 0);
            return value;
        }
    }
}
