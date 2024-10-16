public class UnitTest1
{
    [Theory] // TODO: 4. Fix the Scoring function tests so they've Median (Nithya)

    [InlineData(0.0, new double[] {
        0.0,
        0.0
    })]
    [InlineData(200, new double[] {
        100,
        200,
        200,
        300,
        900
    })]
    [InlineData(200, new double[] {
        300,
        100,
        200,
        900,
        200
    })]

    public void TestDistances(double expected, double[] data)
    {
        Calculations calc = new(data); 

        Assert.Equal(expected, calc.TypicalDistanceTravelledToWork());
    }


    // TODO 3: Fix the rounding test (Peter) -> then deploy.
    [Theory]
    [InlineData(/* Expected value: */ 2, new double[] {
             /* Input to function: */ 1.1 
    })]
    public void TestRounding(double expected, double[] data)
    {
        Calculations calc = new(data);

        Assert.Equal(expected, calc.TypicalDistanceTravelledToWork());
    }
}