namespace TipCalculatorApp.Models
{
    public class TipCalculator
    {
        public decimal BillAmount { get; set; }
        public int TipPercentage { get; set; }
        public decimal TipAmount { get; set; }
        public decimal TotalAmount { get; set; }

        public void CalculateTip()
        {
            TipAmount = BillAmount * TipPercentage / 100;
            TotalAmount = BillAmount + TipAmount;
        }
    }
}

