using System;

public static class fcie
{
    public static Boolean IsNumeric(String input, NumberStyles numberStyle)
    {
        Double temp;
        Boolean result = Double.TryParse(input, numberStyle, CultureInfo.CurrentCulture, out temp);
        return result;
    }

    public fcie()
	{
	}
}
