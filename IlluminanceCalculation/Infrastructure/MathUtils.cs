namespace IlluminanceCalculation.Infrastructure;

public static class MathUtils
{
    public static float Interpolate(float x, float[] xValues, float[] yValues)
    {
        var lagrangePolynomial = 0f;

        for (var i = 0; i < yValues.Length; i++)
        {
            var basicsPolynomial = 1f;
            
            for (var j = 0; j < yValues.Length; j++)
            {
                if (j == i) continue;
                    
                basicsPolynomial *= (x - xValues[j]) / (xValues[i] - xValues[j]);
            }

            lagrangePolynomial += basicsPolynomial * yValues[i];
        }

        return lagrangePolynomial;
    }

    public static float Extrapolate(float x,  float[] xValues, float[] yValues)
    {
        return yValues[0] + (yValues[1] - yValues[0]) / (xValues[1] - xValues[0]) * (x - xValues[0]);
    }
}