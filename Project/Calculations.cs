public class Calculations(IEnumerable<double> _data)
{
    public double TypicalDistanceTravelledToWork()
    {
        double score = 0.0;
        int count = _data.Count();
        
        // TODO: 1. Change this to be the Median, rather than the Average, then move on to the Unit Test (Nithya)

        
            score = _data
                .OrderBy(x => x)
                .Skip(count/2)
                .First();
               
        return AsRoundedValue(score);
    }
    
    private static double AsRoundedValue(double original)
    {
        return Math.Round(original, MidpointRounding.ToEven; // TODO: 2. Change this to use ToPositiveInfinity rounding (Peter)
    }
}