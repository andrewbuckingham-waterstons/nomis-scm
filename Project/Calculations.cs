public class Calculations(IEnumerable<double> _data)
{
    public double TypicalDistanceTravelledToWork()
    {
        double score = 0.0;
        int count = 0;
        
        // TODO: 1. Change this to be the Median, rather than the Average, then move on to the Unit Test (Nithya)
        foreach (double value in _data)
        {
            score += value;
            count++;
        }

        score /= count;

        return AsRoundedValue(score);
    }
    
    private static double AsRoundedValue(double original)
    {
        return Math.Round(original, MidpointRounding.ToPositiveInfinity); // TODO: 2. Change this to use ToPositiveInfinity rounding (Peter)
    }
}