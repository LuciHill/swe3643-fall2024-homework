
namespace hw2_Calculator
{
    public class StdDevCalculator
    {
        public double ComputeMean(int[] values)
        {
            if (values.Length == 0) throw new Exception("Cannot compute Mean. The data set is empty");

            double sum = 0;
            foreach (var value in values) sum += value;

            return sum / values.Length;
        }

        public double ComputeSqofDiff(int[] values, double mean)
        {
            if (values.Length == 0) throw new Exception("Cannot compute Square of Difference. The data set is empty");

            double squareAcc = 0;
            foreach (var value in values)
            {
                var difference = value - mean;
                var sqDiff = difference * difference;
                squareAcc += sqDiff;
            }

            return squareAcc;
        }

        public double ComputeVariance(double sqDiff, int numVals, bool isPop)
        {
            if (!isPop) numVals -= 1;

            if (numVals < 1)
                throw new Exception(
                    "Unable to calculate variance. Sample size can not be less than 1 when calculating Standard Deviation for a population.");

            return sqDiff / numVals;
        }

        public double ComputeStDev(int[] values, bool isPop)
        {
            if (values.Length == 0) throw new Exception("Cannot compute Standard Deviation. The data set is empty");

            var mean = ComputeMean(values);
            var sqDiff = ComputeSqofDiff(values, mean);
            var variance = ComputeVariance(sqDiff, values.Length, isPop);

            return Math.Sqrt(variance);
        }

        public double ComputeSampleStdDev(int[] values)
        {
            return ComputeStDev(values, false);
        }

        public double ComputePopStdDev(int[] values)
        {
            return ComputeStDev(values, true);
        }
        
        public static void Main(String[] args)
        {
            var calc = new StdDevCalculator();
            int[] sampleValuesList = [9, 6, 8, 5, 7];
            var sampleResult = calc.ComputeSampleStdDev(sampleValuesList);
            Console.WriteLine("Sample Standard Deviation: " + sampleResult);

            int[] popVals = [9, 2, 5, 4, 12, 7, 8, 11, 9, 3, 7, 4, 12, 5, 4, 10, 9, 6, 9, 4];
            var popResult = calc.ComputePopStdDev(popVals);
            Console.WriteLine("Population Standard Deviation: " + popResult);
        }
    }
}

