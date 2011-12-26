using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class PointsOnACircle {
    public int color(string[] points)
    {
        int i, j, k;
        string s = "";
        foreach (string ss in points) s += ss;
        string[] st = s.Split(' ');
        int len = st.Length;
        int[] num = new int[len];
        for (i = 0; i < len; i++) num[i] = int.Parse(st[i]) % 360;
        Array.Sort(num);
        //for (j = 0; j < len; j++) Console.WriteLine(num[j]);
        int res = 0;
        for (i = 1; i <= 359; i++)
        {
            bool[] used = new bool[360];
            for (j = 0; j < len; j++) used[num[j]] = true;
            int now = 0;
            for (j = 0; j < len; j++)
            {
                int count = 0;
                for (k = num[j]; ; k = (k + i) % 360)
                {
                    if (used[k])
                    {
                        count++; used[k] = false;
                    }
                    else break;
                }
                for (k = (num[j] - i + 360) % 360; ; k = (k - i + 360) % 360)
                {
                    if (used[k])
                    {
                        count++; used[k] = false;
                    }
                    else break;
                }
                now += count - count % 2;
            }
            res = Math.Max(res, now);
        }
        return res;
    }


    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); }
	private void verify_case(int Case, int Expected, int Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { string[] Arg0 = new string[]{"0 10 15 25 40 50 60"}; int Arg1 = 6; verify_case(0, Arg1, color(Arg0)); }
	private void test_case_1() { string[] Arg0 = new string[]{"1"}; int Arg1 = 0; verify_case(1, Arg1, color(Arg0)); }
	private void test_case_2() { string[] Arg0 = new string[]{"0 1 3 7 15 31 63 127"}; int Arg1 = 2; verify_case(2, Arg1, color(Arg0)); }
	private void test_case_3() { string[] Arg0 = new string[]{"1","2"," ","3","4"}; int Arg1 = 2; verify_case(3, Arg1, color(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
PointsOnACircle ___test = new PointsOnACircle();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
