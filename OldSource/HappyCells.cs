using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class HappyCells {

    int h, w;
    public int[] getHappy(string[] grid)
    {
        int[] res = new int[3];
        int i, j, k;
        h = grid.Length;
        w = grid[0].Length;

        int[] vxa = new int[] { 1, 0, -1, 0 };
        int[] vya = new int[] { 0, 1, 0, -1 };
        int[] vxb = new int[] { 1, 1, -1, -1 };
        int[] vyb = new int[] { 1, -1, 1, -1 };
        
        for (i = 0; i < h; i++)
        {
            for (j = 0; j < w; j++)
            {
                if (grid[i][j] != '.') continue;
                int point = 0;
                bool flag1 = false;
                bool flag2 = false;
                for (k = 0; k < 4; k++)
                {
                    int y = vya[k] + i;
                    int x = vxa[k] + j;
                    if (ok(y, x) && grid[y][x] == '.') flag1 = true;
                }
                for (k = 0; k < 4; k++)
                {
                    int y = vyb[k] + i;
                    int x = vxb[k] + j;
                    if (ok(y, x) && grid[y][x] == '.') flag2 = true;
                }
                if (flag1) point += 2;
                if (flag2) point += 1;
                if (point < 3) res[point]++;
            }
        }
        return res;
    }

    bool ok(int y, int x)
    {
        return y >= 0 && x >= 0 && y < h && x < w;
    }




    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); }
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
"XXX",
"X.X",
"XXX"
}; int[] Arg1 = new int[]{1, 0, 0 }; verify_case(0, Arg1, getHappy(Arg0)); }
	private void test_case_1() { string[] Arg0 = new string[]{"."}; int[] Arg1 = new int[]{1, 0, 0 }; verify_case(1, Arg1, getHappy(Arg0)); }
	private void test_case_2() { string[] Arg0 = new string[]{
"XXXXXX",
"X.XXXX",
"XXX.XX",
"X..XXX",
"XXXXXX"
}; int[] Arg1 = new int[]{1, 1, 1 }; verify_case(2, Arg1, getHappy(Arg0)); }
	private void test_case_3() { string[] Arg0 = new string[]{"..."}; int[] Arg1 = new int[]{0, 0, 3 }; verify_case(3, Arg1, getHappy(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
HappyCells ___test = new HappyCells();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
