namespace PipelineSample.Services
{
    public class Pipeline
    {
       
        public int Add(int a, int b)
        {
            return a + b;
        }
        
        public bool ValidateDeposit(decimal amount)
        {
            if (amount > 0)
            {
                return true;
            }
            return false;
        }
        
        public bool ValidateWithdraw(decimal amount, decimal balance)
        {
            if (amount > 0 && amount <= balance)
            {
                return true;
            }
            return false;
        }
    }
}
