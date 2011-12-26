using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class PowerPlants {
    public int minCost(string[] connectionCost, string plantList, int numPlants)
    {
        int len = plantList.Length;
        int[] dp = new int[1 << len];
        int[] bit = new int[1 << len];
        int[,] connect = new int[len, len];
        int i, j,k;
        int MAX = 9999999;
        for (i = 0; i < (1 << len); i++)
        {
            for (j = 0; j < len; j++)
            {
                if ((i >> j) % 2 == 1) bit[i]++;
                dp[i] = MAX;
            }
        }
        int first = 0;
        for (i = 0; i < len; i++)
        {
            if (plantList[i] == 'Y') first += 1 << i;
        }
        dp[first] = 0;
        for (i = 0; i < len; i++)
        {
            for (j = 0; j < len; j++)
            {
                connect[i, j] = cost(connectionCost[i][j]);
            }
        }
        int res = int.MaxValue;
        for (i = 0; i < (1 << len); i++)
        {
            if (dp[i] == MAX) continue;
            if (bit[i] >= numPlants) res = Math.Min(res, dp[i]);
            for (j = 0; j < len; j++)//add
            {
                if ((i >> j) % 2 == 1) continue;
                int mincost = MAX;
                for (k = 0; k < len; k++)
                {
                    if ((i >> k) % 2 != 1) continue;
                    mincost = Math.Min(mincost, connect[k, j]);
                }
                dp[i | (1 << j)] = Math.Min(dp[i | (1 << j)], dp[i] + mincost);
            }
        }
        return res;
    }

    int cost(char c)
    {
        if (c >= '0' && c <= '9') return c - '0';
        else return c - 'A' + 10;
    }



    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); if ((Case == -1) || (Case == 5)) test_case_5(); }
	private void verify_case(int Case, int Expected, int Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { string[] Arg0 = new string[]{"024",
 "203",
 "430"}; string Arg1 = "YNN"; int Arg2 = 3; int Arg3 = 5; verify_case(0, Arg3, minCost(Arg0, Arg1, Arg2)); }
	private void test_case_1() { string[] Arg0 = new string[]{"0AB",
 "A0C",
 "CD0"}; string Arg1 = "YNN"; int Arg2 = 3; int Arg3 = 21; verify_case(1, Arg3, minCost(Arg0, Arg1, Arg2)); }
	private void test_case_2() { string[] Arg0 = new string[]{"1ABCD",
 "35HF8",
 "FDM31",
 "AME93",
 "01390"}; string Arg1 = "NYNNN"; int Arg2 = 5; int Arg3 = 14; verify_case(2, Arg3, minCost(Arg0, Arg1, Arg2)); }
	private void test_case_3() { string[] Arg0 = new string[]{"012",
 "123",
 "234"}; string Arg1 = "NNY"; int Arg2 = 2; int Arg3 = 2; verify_case(3, Arg3, minCost(Arg0, Arg1, Arg2)); }
	private void test_case_4() { string[] Arg0 = new string[]{"1309328",
 "DS2389U",
 "92EJFAN",
 "928FJNS",
 "FJS0DJF",
 "9FWJW0E",
 "23JFNFS"}; string Arg1 = "YYNYYNY"; int Arg2 = 4; int Arg3 = 0; verify_case(4, Arg3, minCost(Arg0, Arg1, Arg2)); }
	private void test_case_5() { string[] Arg0 = new string[]{"01","20"}; string Arg1 = "YN"; int Arg2 = 2; int Arg3 = 1; verify_case(5, Arg3, minCost(Arg0, Arg1, Arg2)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
PowerPlants ___test = new PowerPlants();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
