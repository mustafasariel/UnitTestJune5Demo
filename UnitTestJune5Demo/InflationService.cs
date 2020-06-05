namespace UnitTestJune5Demo
{
    public class InflationService
    {
        private readonly IInflationRate _inflationRate;
        private readonly IMyLogger _myLogger;

        public InflationService(IInflationRate inflationRate,IMyLogger myLogger)
        {
            this._inflationRate = inflationRate;
            this._myLogger = myLogger;
        }

        public double GetAmountByYear(double amount,int year)
        {
            _myLogger.Log("");
            _myLogger.Log("");
            _myLogger.Log("");
            return amount + amount * _inflationRate.Rate(year);



        }
    }
}
