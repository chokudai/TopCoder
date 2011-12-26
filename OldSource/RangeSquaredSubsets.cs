using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class RangeSquaredSubsets {

    Dictionary<long, bool> dic;

    public long countSubsets(int nlow, int nhigh, int[] x, int[] y)
    {
        dic = new Dictionary<long, bool>();
        int i, j, k, l, m;
        int len = x.Length;
        int[] sx = (int[])x.Clone();
        int[] sy = (int[])y.Clone();
        Array.Sort(sx);
        Array.Sort(sy);
        for (i = 0; i < len; i++)
        {
            for (j = i; j < len; j++)
            {
                int xmin = Math.Max(nlow, sx[j] - sx[i]);
                int xmax = nhigh;
                if (i != 0 && j != len - 1)
                {
                    xmax = Math.Min(sx[j + 1] - sx[i - 1] - 1, xmax);
                }
                if (xmin > xmax) continue;
                for (k = 0; k < len; k++)
                {
                    for (l = k; l < len; l++)
                    {
                        int ymin = Math.Max(nlow, sy[l] - sy[k]);
                        int ymax = nhigh;
                        if (k != 0 && l != len - 1)
                        {
                            ymax = Math.Min(sy[l + 1] - sy[k - 1] - 1, ymax);
                        }
                        if (ymin > ymax) continue;
                        if (xmax < ymin) continue;
                        if (ymax < xmin) continue;
                        long bit = 0;
                        for (m = 0; m < len; m++)
                        {
                            if (x[m] >= sx[i] && x[m] <= sx[j] && y[m] >= sy[k] && y[m] <= sy[l]) bit |= ((long)1 << m);
                        }
                        if (bit == 0) continue;
                        //if (!dic.ContainsKey(bit)) Console.WriteLine(bit + " " + i + " " + j + " " + k + " " + l + " " + xmin + " " + xmax + " " + ymin + " " + ymax);
                        dic[bit] = true;
                    }
                }
            }
        }
        return dic.Count;
    }




    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); }
	private void verify_case(int Case, long Expected, long Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { int Arg0 = 5; int Arg1 = 5; int[] Arg2 = new int[]{-5,0,5}; int[] Arg3 = new int[]{0,0,0}; long Arg4 = 5l; verify_case(0, Arg4, countSubsets(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_1() { int Arg0 = 10; int Arg1 = 10; int[] Arg2 = new int[]{-5,0,5}; int[] Arg3 = new int[]{0,0,0}; long Arg4 = 5l; verify_case(1, Arg4, countSubsets(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_2() { int Arg0 = 1; int Arg1 = 100; int[] Arg2 = new int[]{-5,0,5}; int[] Arg3 = new int[]{0,0,0}; long Arg4 = 6l; verify_case(2, Arg4, countSubsets(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_3() { int Arg0 = 3; int Arg1 = 100000000; int[] Arg2 = new int[]{-1,-1,-1,0,1,1,1}; int[] Arg3 = new int[]{-1,0,1,1,-1,0,1}; long Arg4 = 21l; verify_case(3, Arg4, countSubsets(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_4() { int Arg0 = 64; int Arg1 = 108; int[] Arg2 = new int[]{-56,-234,12,324,-12,53,0,234,1,12,72}; int[] Arg3 = new int[]{6,34,2,235,234,234,342,324,234,234,234}; long Arg4 = 26l; verify_case(4, Arg4, countSubsets(Arg0, Arg1, Arg2, Arg3)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
RangeSquaredSubsets ___test = new RangeSquaredSubsets();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
