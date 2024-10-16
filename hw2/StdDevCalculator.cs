
namespace hw2
{


        class StdDevCalculator
        {
                public double ComputeMean(int[] values)
                {
                        if (values.Length==0)
                        {
                                return -1;
                        }

                        double sum = 0;
                        foreach (int value in values)
                        {
                                sum += value;
                        }

                        return (sum / values.Length);
                }

                public double ComputeSqofDiff(int[] values, double mean)
                {
                        if (values.Length==0)
                        {
                                return -1;
                        }

                        double squareAcc = 0;
                        foreach (int value in values)
                        {
                                double difference = value - mean;
                                double sqDiff = difference * difference;
                                squareAcc += sqDiff;
                        }

                        return squareAcc;
                }

                public double ComputeVariance(double sqDiff, int numVals, bool isPop)
                {
                        if (!isPop)
                        {
                                numVals -= 1;
                        }

                        if (numVals < 1)
                        {
                                return -1;
                        }

                        return sqDiff / numVals;
                }

                public double ComputeStDev(int[] values, bool isPop)
                {
                        if (values.Length==0)
                        {
                                return -1;
                        }

                        double mean = ComputeMean(values);
                        if (mean<0)
                        {
                                Console.WriteLine("Invalid sample. Could not compute mean");
                                return -1;
                        }

                        double sqDiff = ComputeSqofDiff(values, mean);
                        if (sqDiff<0)
                        {
                                Console.WriteLine("Invalid sample. Could not compute Square of Difference");
                                return -1;
                        }

                        double variance = ComputeVariance(sqDiff, values.Length, isPop);
                        if (variance<0)
                        {
                                Console.WriteLine("Invalid sample. Could not compute Variance");
                                return -1;
                        }

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

                public static void Main(string[] args)
                {
                        StdDevCalculator calc = new StdDevCalculator();
                        int[] sampleValuesList = [9, 6, 8, 5, 7];
                        double sampleResult = calc.ComputeSampleStdDev(sampleValuesList);
                        Console.WriteLine("Sample Standard Deviation: " + sampleResult);

                        int[] popVals = [9, 2, 5, 4, 12, 7, 8, 11, 9, 3, 7, 4, 12, 5, 4, 10, 9, 6, 9, 4];
                        double popResult = calc.ComputePopStdDev(popVals);
                        Console.WriteLine("Population Standard Deviation: " + popResult);

                }
        }
}