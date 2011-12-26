using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class CandidateKeys {
    public int[] getKeys(string[] table)
    {
        int len = 1 << table[0].Length;
        bool[] superkey = new bool[len];
        int i, j, k;
        int max = -1, min = 1000;
        for (i = 0; i < len; i++)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            for (j = 0; j < table.Length; j++)
            {
                string s = "";
                for (k = 0; k < table[j].Length; k++)
                {
                    if ((i & (1 << k)) != 0) s += table[j][k];
                }
                if (dic.ContainsKey(s)) break;
                dic[s] = 1;
            }
            if (j != table.Length) continue;
            superkey[i] = true;
            int now = 0;
            for (j = 0; j < table[0].Length; j++)
            {
                if ((i & (1 << j)) != 0)
                {
                    now++;
                    if (superkey[i - (1 << j)]) break;
                }
            }
            if (j == table[0].Length)
            {
                min = Math.Min(min, now);
                max = Math.Max(max, now);
            }
        }
        if (max < 0) return new int[0];
        else return new int[2] { min, max };
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
	private void test_case_0() { string[] Arg0 = new string[]{
"ABC",
"ABC",
"ABC"
}; int[] Arg1 = new int[]{ }; verify_case(0, Arg1, getKeys(Arg0)); }
	private void test_case_1() { string[] Arg0 = new string[]{
"ABC",
"ABD",
"ABE"
}; int[] Arg1 = new int[]{1, 1 }; verify_case(1, Arg1, getKeys(Arg0)); }
	private void test_case_2() { string[] Arg0 = new string[]{
"ABC",
"ACD",
"BBE"
}; int[] Arg1 = new int[]{1, 2 }; verify_case(2, Arg1, getKeys(Arg0)); }
	private void test_case_3() { string[] Arg0 = new string[]{"A","B"}; int[] Arg1 = new int[]{1, 1 }; verify_case(3, Arg1, getKeys(Arg0)); }
	private void test_case_4() { string[] Arg0 = new string[]{
"AABB",
"BABA",
"CAAB",
"DAAA",
"EBBB",
"FBBA",
"GBAB",
"HBAA"
}; int[] Arg1 = new int[]{1, 3 }; verify_case(4, Arg1, getKeys(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
CandidateKeys ___test = new CandidateKeys();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
