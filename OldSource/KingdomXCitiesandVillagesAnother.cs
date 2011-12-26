using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class KingdomXCitiesandVillagesAnother {
    public double determineLength(int[] cityX, int[] cityY, int[] villageX, int[] villageY)
    {
        int c = cityX.Length;
        int v = villageX.Length;
        int i, j, k;
        bool[] connect = new bool[v];
        double res = 0;
        for (k = 0; k < v; k++)
        {
            int index = -1;
            double bestdist = Double.MaxValue;
            for (i = 0; i < c; i++)
            {
                for (j = 0; j < v; j++)
                {
                    if (connect[j]) continue;
                    double dist = getdist(cityX[i], cityY[i], villageX[j], villageY[j]);
                    if (bestdist > dist)
                    {
                        index = j;
                        bestdist = dist;
                    }
                }
            }
            for (i = 0; i < v; i++)
            {
                if (!connect[i]) continue;
                for (j = 0; j < v; j++)
                {
                    if (connect[j]) continue;
                    double dist = getdist(villageX[i], villageY[i], villageX[j], villageY[j]);
                    if (bestdist > dist)
                    {
                        index = j;
                        bestdist = dist;
                    }
                }
            }
            connect[index] = true;
            res += bestdist;
        }
        return res;
    }

    double getdist(double ax, double ay, double bx, double by)
    {
        return Math.Sqrt((ax - bx) * (ax - bx) + (ay - by) * (ay - by));
    }




    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); }
	private void verify_case(int Case, double Expected, double Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { int[] Arg0 = new int[]{1}; int[] Arg1 = new int[]{1}; int[] Arg2 = new int[]{2,3}; int[] Arg3 = new int[]{1,1}; double Arg4 = 2.0; verify_case(0, Arg4, determineLength(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_1() { int[] Arg0 = new int[]{1,2}; int[] Arg1 = new int[]{1,1}; int[] Arg2 = new int[]{1,2}; int[] Arg3 = new int[]{2,2}; double Arg4 = 2.0; verify_case(1, Arg4, determineLength(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_2() { int[] Arg0 = new int[]{0}; int[] Arg1 = new int[]{0}; int[] Arg2 = new int[]{2}; int[] Arg3 = new int[]{2}; double Arg4 = 2.8284271247461903; verify_case(2, Arg4, determineLength(Arg0, Arg1, Arg2, Arg3)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
KingdomXCitiesandVillagesAnother ___test = new KingdomXCitiesandVillagesAnother();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
