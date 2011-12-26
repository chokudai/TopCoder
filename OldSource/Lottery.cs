using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class Lottery {

    class rule:IComparable
    {
        public long num;
        public string name;
        public rule(string s)
        {
            string[] ss = s.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
            name = ss[0];
            string[] st = ss[1].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int n = int.Parse(st[0]);
            int m = int.Parse(st[1]);
            int i;
            if (st[2] == "F" && st[3] == "F")
            {
                num = 1;
                for (i = 0; i < m; i++) num *= n;
            }
            if (st[2] == "T" && st[3] == "F")
            {
                num = 1;
                for (i = 0; i < m; i++) num *= n + i;
                for (i = 0; i < m; i++) num /= i + 1;
            }
            if (st[2] == "F" && st[3] == "T")
            {
                num = 1;
                for (i = 0; i < m; i++) num *= n - i;
            }
            if (st[2] == "T" && st[3] == "T")
            {
                num = 1;
                for (i = 0; i < m; i++) num *= n - i;
                for (i = 0; i < m; i++) num /= i + 1;
            }
        }

        public int CompareTo(object obj)
        {
            rule r = (rule)obj;
            if (this.num > r.num) return 1;
            else if(this.num < r.num) return -1;
            else return this.name.CompareTo(r.name);
        }
    }

    public string[] sortByOdds(string[] rules)
    {
        int len = rules.Length;
        rule[] rs = new rule[len];
        int i;
        for (i = 0; i < len; i++)
        {
            rs[i] = new rule(rules[i]);
        }
        Array.Sort(rs);
        string[] res = new string[len];
        for (i = 0; i < len; i++)
        {
            res[i] = rs[i].name;
        }
        return res;
    }

    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); }
	private void verify_case(int Case, string[] Expected, string[] Received) {
		Console.Write("Test Case #" + Case + "...");
		if (equal_arrays(Expected, Received)) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: " + print_array(Expected)); 
			Console.WriteLine("\tReceived: " + print_array(Received)); } }
	string print_array(string[] V) {
		System.Text.StringBuilder builder = new System.Text.StringBuilder();
		builder.Append("{ ");
		foreach (string o in V) {
			builder.Append('\"');
			builder.Append(o.ToString());
			builder.Append("\",");
		}
		builder.Append(" }");
		return builder.ToString();
	}
	bool equal_arrays(string[] a, string[]b) {
		if (a.Length != b.Length) return false;
		for (int i = 0; i < a.Length; ++i) if (a[i] != b[i]) return false;
		return true;
	}
	private void test_case_0() { string[] Arg0 = new string[]{"PICK ANY TWO: 10 2 F F"
,"PICK TWO IN ORDER: 10 2 T F"
,"PICK TWO DIFFERENT: 10 2 F T"
,"PICK TWO LIMITED: 10 2 T T"}; string[] Arg1 = new string[]{ "PICK TWO LIMITED",  "PICK TWO IN ORDER",  "PICK TWO DIFFERENT",  "PICK ANY TWO" }; verify_case(0, Arg1, sortByOdds(Arg0)); }
	private void test_case_1() { string[] Arg0 = new string[]{"INDIGO: 93 8 T F",
 "ORANGE: 29 8 F T",
 "VIOLET: 76 6 F F",
 "BLUE: 100 8 T T",
 "RED: 99 8 T T",
 "GREEN: 78 6 F T",
 "YELLOW: 75 6 F F"}
; string[] Arg1 = new string[]{ "RED",  "ORANGE",  "YELLOW",  "GREEN",  "BLUE",  "INDIGO",  "VIOLET" }; verify_case(1, Arg1, sortByOdds(Arg0)); }
	private void test_case_2() { string[] Arg0 = new string[]{}; string[] Arg1 = new string[]{ }; verify_case(2, Arg1, sortByOdds(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
Lottery ___test = new Lottery();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
