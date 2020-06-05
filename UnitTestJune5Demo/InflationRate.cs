namespace UnitTestJune5Demo
{
    public class InflationRate : IInflationRate
    {
        public double Rate(int year)
        {
            double rate;

            switch (year)
            {
                case 2020:
                    rate = 0.1;
                    break;
                case 2019:
                    rate = 0.2;
                    break;
                default:
                    rate = 1;
                    break;
            }

            return rate;
        }
    }
}
