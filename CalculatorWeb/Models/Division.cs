namespace CalculatorWeb.Models
{
    public class Division
    {
        public int FirstNumber { get; set; }

        public int SecondNumber { get; set; }

        public double Quotient => (double)FirstNumber / SecondNumber;
    }
}
