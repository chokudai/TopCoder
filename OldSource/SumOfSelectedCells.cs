using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class SumOfSelectedCells {
    public string hypothesis(string[] table)
    {
        int len = table[0].Split(' ').Length;
        int i, j;
        int[,] num = new int[table.Length, len];
        for (i = 0; i < table.Length; i++)
        {
            string[] st = table[i].Split(' ');
            for (j = 0; j < st.Length; j++) num[i, j] = int.Parse(st[j]);
        }
        if (table.Length >= len) return check(num, table.Length, len);
        else
        {
            int[,] nn = new int[len, table.Length];
            for (i = 0; i < table.Length; i++)
            {
                for (j = 0; j < len; j++) nn[j, i] = num[i, j];
            }

            return check(nn, len, table.Length);
        }
    }

    string check(int[,] num, int a, int b)
    {
        int[] dist = new int[b - 1];
        int i, j;
        for (i = 0; i < dist.Length; i++) dist[i] = num[0, i] - num[0, i + 1];
        for (i = 0; i < a; i++)
        {
            for (j = 0; j < dist.Length; j++)
            {
                if (dist[j] != num[i, j] - num[i, j + 1]) return "INCORRECT";
            }
        }
        if (a != b)
        {
            for (j = 0; j < b; j++)
            {
                for (i = 0; i < a - 1; i++) if (num[i, j] != num[i + 1, j]) return "INCORRECT";
            }
        }
        return "CORRECT";
    }




    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); }
	private void verify_case(int Case, string Expected, string Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { string[] Arg0 = new string[]{"5 6 6"}; string Arg1 = "INCORRECT"; verify_case(0, Arg1, hypothesis(Arg0)); }
	private void test_case_1() { string[] Arg0 = new string[]{"11 12 13 14",
 "21 22 23 24",
 "31 32 33 34",
 "41 42 43 44"}; string Arg1 = "CORRECT"; verify_case(1, Arg1, hypothesis(Arg0)); }
	private void test_case_2() { string[] Arg0 = new string[]{"3 7",
 "3 7",
 "3 7"}; string Arg1 = "CORRECT"; verify_case(2, Arg1, hypothesis(Arg0)); }
	private void test_case_3() { string[] Arg0 = new string[]{"1 2 3",
 "4 5 6",
 "9 8 7"}; string Arg1 = "INCORRECT"; verify_case(3, Arg1, hypothesis(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
SumOfSelectedCells ___test = new SumOfSelectedCells();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
