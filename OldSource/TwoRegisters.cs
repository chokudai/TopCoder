using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class TwoRegisters {
    string ng;
    int min;
    public string minProg(int r)
    {
        string res = "";
        int i;
        min = 1000;
        for (i = 0; i < 100; i++) res += "Y";
        ng = res;
        for (i = 1; i < r; i++)
        {
            min = Math.Min(min, check(i, r - i));
        }
        Console.WriteLine(min);
        for (i = 1; i < r; i++)
        {
            if (min != check(i, r - i)) continue;
            res = compare(res, saiki(i, r - i) + "X");
        }
        return res;
    }

    int check(int a, int b)
    {
        if (a <= 0 || b <= 0) return 10000;
        if (a == 1 && b == 1) return 0;
        else if (a == 1) return b - 1;
        else if (b == 1) return a - 1;
        if (a > b) return check(a % b, b) + a / b;
        else return check(a, b % a) + b / a;
    }

    string saiki(int x, int y)
    {
        if (x == 1 && y == 1) return "";
        if (x > y)
        {
            if (y != 1)
            {
                int num = x / y;
                int mod = x % y;
                if (mod == 0) return ng;
                string s = "";
                for (int i = 0; i < num; i++) s += "X";
                return saiki(mod, y) + s;
            }
            else
            {
                string s = "";
                for (int i = 1; i < x; i++) s += "X";
                return s;
            }
        }
        else
        {
            int c = y;
            y = x;
            x = c;
            if (y != 1)
            {
                int num = x / y;
                int mod = x % y;
                if (mod == 0) return ng;
                string s = "";
                for (int i = 0; i < num; i++) s += "Y";
                return saiki(y, mod) + s;
            }
            else
            {
                string s = "";
                for (int i = 1; i < x; i++) s += "Y";
                return s;
            }
        }
    }

    string compare(string s, string r)
    {
        if (s.Length < r.Length) return s;
        else if (s.Length > r.Length) return r;
        if (s.CompareTo(r) < 0) return s;
        else return r;
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
	private void test_case_0() { int Arg0 = 10; string Arg1 = "XXYYX"; verify_case(0, Arg1, minProg(Arg0)); }
	private void test_case_1() { int Arg0 = 3; string Arg1 = "XX"; verify_case(1, Arg1, minProg(Arg0)); }
	private void test_case_2() { int Arg0 = 20; string Arg1 = "XYYYYXX"; verify_case(2, Arg1, minProg(Arg0)); }
	private void test_case_3() { int Arg0 = 34; string Arg1 = "XYXYXYX"; verify_case(3, Arg1, minProg(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
TwoRegisters ___test = new TwoRegisters();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
