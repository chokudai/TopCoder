using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class UnluckyIntervals {
    public int[] getLuckiest(int[] luckySet, int n)
    {
        Array.Sort(luckySet);
        Dictionary<int, int> dic = new Dictionary<int, int>();
        int[] result = new int[n + 1];
        int[] low = new int[n + 1];
        int[] mid = new int[n + 1];
        int[] hi = new int[n + 1];
        int i, j;
        int himax = luckySet[luckySet.Length - 1] + 1;
        for (i = 0; i < Math.Min(luckySet.Length, n); i++) result[i + 1] = luckySet[i];
        for (i = 2; i < Math.Min(luckySet.Length + 1, n + 1); i++) low[i] = luckySet[i - 2];
        for (i = 1; i < Math.Min(luckySet.Length + 1, n + 1); i++) mid[i] = luckySet[i - 1];
        for (i = 0; i < Math.Min(luckySet.Length, n); i++) hi[i] = luckySet[i];
        result[0] = 0;
        for (i = 0; i < Math.Min(luckySet.Length + 1, n + 1); i++) dic[result[i]] = 0;
        dic[0] = 0;
        dic[-1] = 0;
        for (; i < n + 1; i++)
        {
            int bestnum = -1;
            long bestlucky = long.MaxValue;
            long bestlow = 0;
            long besthi = 0;
            for (j = 0; j < i; j++)
            {
                int check = result[j] - 1;
                if (!dic.ContainsKey(check) && check > 0)
                {
                    long nowlow = low[j];
                    long nowhi = hi[j];
                    if (mid[j] != -1) nowhi = mid[j];
                    long nowlucky = (nowhi - check) * (check - nowlow) - 1;
                    if (nowlucky < bestlucky || (nowlucky == bestlucky && bestnum > check))
                    {
                        bestnum = check;
                        bestlucky = nowlucky;
                        bestlow = nowlow;
                        besthi = nowhi;
                    }
                }
                check = result[j] + 1;
                if (!dic.ContainsKey(check) && check < luckySet[luckySet.Length - 1])
                {
                    long nowlow = low[j];
                    long nowhi = hi[j];
                    if (mid[j] != -1) nowlow = mid[j];
                    long nowlucky = (nowhi - check) * (check - nowlow) - 1;
                    if (nowlucky < bestlucky || (nowlucky == bestlucky && bestnum > check))
                    {
                        bestnum = check;
                        bestlucky = nowlucky;
                        bestlow = nowlow;
                        besthi = nowhi;
                    }
                }
            }
            if (bestnum == -1) { bestnum = himax; himax++; }
            dic[bestnum] = 1;
            result[i] = bestnum;
            low[i] = (int)bestlow;
            hi[i] = (int)besthi;
            mid[i] = -1;
            //Console.WriteLine("num:{0} lucky:{1} low:{2} hi:{3}", bestnum, bestlucky, bestlow, besthi);
        }
        int[] res = new int[n];
        for (i = 0; i < n; i++) res[i] = result[i + 1];
        return res;
    }




// BEGIN CUT HERE
	public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); }
	private void verify_case(int Case, int[] Expected, int[] Received) {
		Console.Write("Test Case #" + Case + "...");
		if (equal_arrays(Expected, Received)) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: " + print_array(Expected)); 
			Console.WriteLine("\tReceived: " + print_array(Received)); } }
	string print_array(int[] V) {
		System.Text.StringBuilder builder = new System.Text.StringBuilder();
		builder.Append("{ ");
		foreach (int o in V) {
			builder.Append('\"');
			builder.Append(o.ToString());
			builder.Append("\",");
		}
		builder.Append(" }");
		return builder.ToString();
	}
	bool equal_arrays(int[] a, int[]b) {
		if (a.Length != b.Length) return false;
		for (int i = 0; i < a.Length; ++i) if (a[i] != b[i]) return false;
		return true;
	}
	private void test_case_0() { int[] Arg0 = new int[]{3}; int Arg1 = 6; int[] Arg2 = new int[]{3, 1, 2, 4, 5, 6 }; verify_case(0, Arg2, getLuckiest(Arg0, Arg1)); }
	private void test_case_1() { int[] Arg0 = new int[]{5, 11, 18}; int Arg1 = 9; int[] Arg2 = new int[]{5, 11, 18, 1, 4, 6, 10, 2, 3 }; verify_case(1, Arg2, getLuckiest(Arg0, Arg1)); }
	private void test_case_2() { int[] Arg0 = new int[]{7, 13, 18}; int Arg1 = 9; int[] Arg2 = new int[]{7, 13, 18, 14, 17, 8, 12, 1, 6 }; verify_case(2, Arg2, getLuckiest(Arg0, Arg1)); }
	private void test_case_3() { int[] Arg0 = new int[]{1000, 1004, 4000, 4003, 5000}; int Arg1 = 19; int[] Arg2 = new int[]{1000, 1004, 4000, 4003, 5000, 4001, 4002, 1001, 1003, 1002, 4004, 4999, 1, 999, 4005, 4998, 2, 998, 4006 }; verify_case(3, Arg2, getLuckiest(Arg0, Arg1)); }
	private void test_case_5() { int[] Arg0 = new int[]{1000000000}; int Arg1 = 8; int[] Arg2 = new int[]{1000000000, 1, 999999999, 2, 999999998, 3, 999999997, 4 }; verify_case(4, Arg2, getLuckiest(Arg0, Arg1)); }
    private void test_case_4() { int[] Arg0 = new int[] { 9999999,10000001 }; int Arg1 = 2; int[] Arg2 = new int[] { 1000000000, 1, 999999999, 2, 999999998, 3, 999999997, 4 }; verify_case(4, Arg2, getLuckiest(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
UnluckyIntervals ___test = new UnluckyIntervals();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
