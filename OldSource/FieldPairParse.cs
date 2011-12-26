using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class FieldPairParse {
    public int[] getPairs(string[] data)
    {
        List<int> res = new List<int>();
        int i,j;
        int len = data[0].Length;
        int now = 0;
        for (i = 0; i < len; i++)
        {
            bool flag = true;
            for (j = 0; j < data.Length; j++)
            {
                if (data[j][i] == 'X') flag = false;
            }
            if (flag) now++;
            else
            {
                if (now != 0) res.Add(now);
                now = 0;
            }
        }
        if (res.Count % 2 == 0) return new int[0];
        else return res.ToArray();
    }




    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); if ((Case == -1) || (Case == 5)) test_case_5(); }
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
"XXXXX    XXXXX",
"XXXX    XXXXX "
}; int[] Arg1 = new int[]{3 }; verify_case(0, Arg1, getPairs(Arg0)); }
	private void test_case_1() { string[] Arg0 = new string[]{
"XXXXXXXXXX     XXXXXXXXXXX",
"XXXXXXXXXXXXXXXXX    XXXXX"
}; int[] Arg1 = new int[]{ }; verify_case(1, Arg1, getPairs(Arg0)); }
	private void test_case_2() { string[] Arg0 = new string[]{
"X X X",
"X X X"
}; int[] Arg1 = new int[]{ }; verify_case(2, Arg1, getPairs(Arg0)); }
	private void test_case_3() { string[] Arg0 = new string[]{
"XXXX      X  X           X X   X",
"XX       XXX XX   X   X   X XXX "
}; int[] Arg1 = new int[]{5, 1, 3, 3, 2 }; verify_case(3, Arg1, getPairs(Arg0)); }
	private void test_case_4() { string[] Arg0 = new string[]{"XXXX      X  X           X X   X"}; int[] Arg1 = new int[]{6, 2, 11, 1, 3 }; verify_case(4, Arg1, getPairs(Arg0)); }
	private void test_case_5() { string[] Arg0 = new string[]{"XXX XXX XXX XXX XXX"}; int[] Arg1 = new int[]{ }; verify_case(5, Arg1, getPairs(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
FieldPairParse ___test = new FieldPairParse();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
