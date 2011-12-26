using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class WordsGame {
    public int minimumSwaps(string[] grid, string word)
    {
        int i, j;
        int len = grid.Length;
        int best = 100000;
        for (i = 0; i < len; i++)
        {
            int count = 0;
            int[] res = new int[len];
            int k;
            for (k = 0; k < len; k++) res[k] = k;
            for (j = 0; j < len; j++)
            {
                if (word[j] != grid[i][res[j]])
                {
                    count++;
                    for (k = j + 1; k < len; k++)
                    {
                        if (word[j] == grid[i][res[k]]) break;
                    }
                    if (k == len) break;
                    int temp = res[j];
                    res[j] = res[k];
                    res[k] = temp;
                }
            }
            if (j == len)
            {
                best = Math.Min(best, count);
            }
        }
        for (i = 0; i < len; i++)
        {
            int count = 0;
            int[] res = new int[len];
            int k;
            for (k = 0; k < len; k++) res[k] = k;
            for (j = 0; j < len; j++)
            {
                if (word[j] != grid[res[j]][i])
                {
                    count++;
                    for (k = j + 1; k < len; k++)
                    {
                        if (word[j] == grid[res[k]][i]) break;
                    }
                    if (k == len) break;
                    int temp = res[j];
                    res[j] = res[k];
                    res[k] = temp;
                }
            }
            if (j == len)
            {
                best = Math.Min(best, count);
            }
        }
        if (best == 100000) return -1;
        else return best;

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
	private void test_case_0() { string[] Arg0 = new string[]{"Mu",
 "uM"}; string Arg1 = "Mu"; int Arg2 = 0; verify_case(0, Arg2, minimumSwaps(Arg0, Arg1)); }
	private void test_case_1() { string[] Arg0 = new string[]{"sdf",
 "bca",
 "hgf"}; string Arg1 = "abc"; int Arg2 = 2; verify_case(1, Arg2, minimumSwaps(Arg0, Arg1)); }
	private void test_case_2() { string[] Arg0 = new string[]{"cdf",
 "bca",
 "agf"}; string Arg1 = "abc"; int Arg2 = 1; verify_case(2, Arg2, minimumSwaps(Arg0, Arg1)); }
	private void test_case_3() { string[] Arg0 = new string[]{"xSZB",
 "gbHk",
 "kbgH",
 "WFSg"}; string Arg1 = "bkHg"; int Arg2 = 2; verify_case(3, Arg2, minimumSwaps(Arg0, Arg1)); }
	private void test_case_4() { string[] Arg0 = new string[]{"eKUNGHktLB",
 "EtBFDndTlG",
 "RRFHmjwrDs",
 "eKYsHlYhlu",
 "ljxyJSwTds",
 "dUQToyWHvl",
 "azDPWRwioE",
 "EARdktoDBh",
 "dmIqcGSvCE",
 "wXypNQEMxz"}; string Arg1 = "oDmWcJHGNk"; int Arg2 = 6; verify_case(4, Arg2, minimumSwaps(Arg0, Arg1)); }
	private void test_case_5() { string[] Arg0 = new string[]{"ab",
 "bA"}; string Arg1 = "aB"; int Arg2 = -1; verify_case(5, Arg2, minimumSwaps(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
WordsGame ___test = new WordsGame();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
