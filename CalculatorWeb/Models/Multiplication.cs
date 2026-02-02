namespace CalculatorWeb.Models
{
    public class Multiplication
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        public int Result => FirstNumber * SecondNumber;
    }
}
