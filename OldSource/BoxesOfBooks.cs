using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using System.Text.RegularExpressions;

public class BoxesOfBooks
{
	public int boxes(int[] weights, int maxWeight)
	{
        if (weights.Length == 0) return 0;
        int i;
        int a=0;
        int result = 1;
        for (i = 0; i < weights.Length; i++)
        {
            if (a + weights[i] > maxWeight)
            {
                a = 0;
                result++;
            }
            a += weights[i];
        }
        return result;
	}
}
//Powered by [KawigiEdit] 2.0!
