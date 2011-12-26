using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class HexatridecimalSum {
    public string maximizeSum(string[] numbers, int k) {
        int len = numbers.Length;
        int[,] num = new int[len, 60];
        int i, j;
        int count;
        for (i = 0; i < len; i++)
        {
            count = 0;
            for (j = numbers[i].Length - 1; j >= 0; j--)
            {
                num[i, count] = getin(numbers[i][j]);
                count++;
            }
        }
        Console.Write("A");
        int[,] sum = new int[36, 60];
        for (i = 0; i < len; i++)
        {
            for (j = 59; j >= 0; j--)
            {
                if (num[i, j] != 0) break;
            }
            for (; j >= 0; j--)
            {
                sum[num[i, j], j] += 35 - num[i, j];
            }
        }
        Console.Write("A");
        int[] result = new int[60];
        for (i = 0; i < len; i++)
        {
            for (j = 0; j < 60; j++)
            {
                result[j] += num[i, j];
            }
        }
        Console.Write("A");
        for (i = 0; i < 36; i++)
        {
            for (j = 0; j < 59; j++)
            {
                sum[i, j + 1] += sum[i, j] / 36;
                sum[i, j] %= 36;
            }
        }
        Console.Write("A");
        bool[] used = new bool[36];
        for (int aa=0; aa < k; aa++)
        {
            int best = -1;
            for (int l = 0; l < 36; l++)
            {
                if (used[l]) continue;
                if (best == -1) { best = l; continue; }
                for (j = 59; j >=0; j--)
                {
                    if (sum[l, j] > sum[best, j])
                    {
                        best = l;
                        break;
                    }
                    if (sum[l, j] != sum[best, j]) break;
                }
            }
            if (best == -1) break;
            for (j = 0; j < 60; j++)
            {
                result[j] += sum[best, j];
            }
            used[best] = true;
        }
        Console.Write("A");

        for (j = 0; j < 59; j++)
        {
            result[j + 1] += result[j] / 36;
            result[j] %= 36;
        }
        string res = "";
        for (j = 59; j >= 0; j--)
        {
            if (result[j] != 0) break;
        }
        for (; j >= 0; j--) res += getcha(result[j]);
        return res;
    }

    char getcha(int a)
    {
        if (a < 10) return (char)('0' + a);
        else a -= 10; return (char)('A' + a);
    }

    int getin(char c)
    {
        if (c < '9') return c - '0';
        else return c - 'A' + 10;
    }




// BEGIN CUT HERE
	public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); }
	private void verify_case(int Case, string Expected, string Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { string[] Arg0 = new string[]{"HELLO"}; int Arg1 = 2; string Arg2 = "ZZLLO"; verify_case(0, Arg2, maximizeSum(Arg0, Arg1)); }
	private void test_case_1() { string[] Arg0 = new string[]{"500", "POINTS", "FOR", "THIS", "PROBLEM"}; int Arg1 = 5; string Arg2 = "1100TC85"; verify_case(1, Arg2, maximizeSum(Arg0, Arg1)); }
	private void test_case_2() { string[] Arg0 = new string[]{"TO", "BE", "OR", "NOT", "TO", "BE"}; int Arg1 = 0; string Arg2 = "QNO"; verify_case(2, Arg2, maximizeSum(Arg0, Arg1)); }
	private void test_case_3() { string[] Arg0 = new string[]{"KEQUALS36"}; int Arg1 = 36; string Arg2 = "ZZZZZZZZZ"; verify_case(3, Arg2, maximizeSum(Arg0, Arg1)); }
	private void test_case_4() { string[] Arg0 = new string[]{"GOOD", "LUCK", "AND", "HAVE", "FUN"}; int Arg1 = 7; string Arg2 = "31YUB"; verify_case(4, Arg2, maximizeSum(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
HexatridecimalSum ___test = new HexatridecimalSum();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
