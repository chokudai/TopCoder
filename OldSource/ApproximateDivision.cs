using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using System.Text.RegularExpressions;

public class ApproximateDivision
{
	public double quotient(int a, int b, int terms)
	{
        int t=1, c,i;
        while (t < b) t *= 2;
        c = t - b;
        double result = 0;
        double kakeru = (double)c / t;
        double now = 1.0 / t;
        for (i = 0; i < terms; i++)
        {
            result += now;
            now *= kakeru;
        }
        return a*result;
	}
}
//Powered by [KawigiEdit] 2.0!
