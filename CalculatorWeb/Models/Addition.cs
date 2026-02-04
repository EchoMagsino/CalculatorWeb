namespace CalculatorWeb.Models
{
    public class Addition
    {
        public int FirstNumber { get; set; }

        public int SecondNumber { get; set; }

        public int Sum => FirstNumber + SecondNumber;

        //public int Sum => FirstNumber + SecondNumber;


    }
}
