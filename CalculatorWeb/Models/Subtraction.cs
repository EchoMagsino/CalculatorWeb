namespace CalculatorWeb.Models
{
    public class Subtraction
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }

        public int Difference => FirstNumber - SecondNumber;


    }
}
