using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class CoinMachinesGame {
    public int maxGames(int coins, int[] need, int[] give)
    {
        int i, j;
        int len = need.Length;
        for (i = 0; i < len; i++)
        {
            for (j = 0; j < len - 1; j++)
            {
                if (need[j] < need[j + 1])
                {
                    int temp;
                    temp = need[j];
                    need[j] = need[j + 1];
                    need[j + 1] = temp;
                    temp = give[j];
                    give[j] = give[j + 1];
                    give[j + 1] = temp;
                }
            }
        }
        int res = 0;
        while (true)
        {
            int use = -1;
            int mind = int.MaxValue;
            int n = 0;
            for (i = 0; i < len; i++)
            {
                if (need[i] > coins) continue;
                int d = need[i] - give[i];
                if (d < mind)
                {
                    use = i;
                    mind = d;
                    n = need[i];
                }
            }
            if (use == -1) break;
            int count = (coins - n + mind) / mind;
            res += count;
            coins -= mind * count;
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
	private void test_case_0() { int Arg0 = 10; int[] Arg1 = new int[]{5,3}; int[] Arg2 = new int[]{4,1}; int Arg3 = 7; verify_case(0, Arg3, maxGames(Arg0, Arg1, Arg2)); }
	private void test_case_1() { int Arg0 = 1000; int[] Arg1 = new int[]{16,14,11,7}; int[] Arg2 = new int[]{15,12,8,3}; int Arg3 = 988; verify_case(1, Arg3, maxGames(Arg0, Arg1, Arg2)); }
	private void test_case_2() { int Arg0 = 1000000000; int[] Arg1 = new int[]{1000,900,800,700,600,500,400,300,200,100}; int[] Arg2 = new int[]{701,802,503,604,405,306,107,208,1,1}; int Arg3 = 10869564; verify_case(2, Arg3, maxGames(Arg0, Arg1, Arg2)); }
	private void test_case_3() { int Arg0 = 12345678; int[] Arg1 = new int[]{342,234,65,76,85,734,67,345,70,234}; int[] Arg2 = new int[]{45,78,3,10,45,12,45,57,1,230}; int Arg3 = 3086370; verify_case(3, Arg3, maxGames(Arg0, Arg1, Arg2)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
CoinMachinesGame ___test = new CoinMachinesGame();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
