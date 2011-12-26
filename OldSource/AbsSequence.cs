using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class AbsSequence {
    List<long> ln1;
    List<long> ln2;
    List<long> lnum;

    public string[] getElements(string first, string second, string[] indices)
    {
        ln1 = new List<long>();
        ln2 = new List<long>();
        lnum = new List<long>();
        long f = long.Parse(first);
        long s = long.Parse(second);
        gcd(f, s, 0);
        long[] n1 = ln1.ToArray();
        long[] n2 = ln2.ToArray();
        long[] num = lnum.ToArray();
        int len = num.Length;
        int i,j;
        List<string> lret = new List<string>();
        for (i = 0; i < indices.Length; i++)
        {
            long target = long.Parse(indices[i]);
            for (j = 0; j < len - 1; j++)
            {
                if (num[j + 1] > target) break;
            }
            long nokori = target - num[j];
            if (nokori % 3 == 0)
            {
                long t = n1[j] - (n2[j]) * (nokori / 3 * 2);
                lret.Add(t.ToString());
            }
            else if (nokori % 3 == 1)
            {
                lret.Add(n2[j].ToString());
            }
            else if (nokori % 3 == 2)
            {
                long t = n1[j] - (n2[j]) * (nokori / 3 * 2 + 1);
                lret.Add(t.ToString());
            }
        }
        return lret.ToArray();
    }

    void gcd(long a, long b, long num)
    {
        ln1.Add(a);
        ln2.Add(b);
        lnum.Add(num);
        if (b == 0) return;
        long div = a / b;
        if (div % 2 == 0)
        {
            long add = div / 2 * 3 + 1;
            gcd(b, b - a % b, num + add);
        }
        else
        {
            long add = div / 2 * 3 + 1;
            gcd(b, a % b, num + add);
        }
        return;
    }




// BEGIN CUT HERE
	public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); }
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
	private void test_case_0() { string Arg0 = "21"; string Arg1 = "12"; string[] Arg2 = new string[]{"0", "1", "2", "3", "4"}; string[] Arg3 = new string[]{"21", "12", "9", "3", "6" }; verify_case(0, Arg3, getElements(Arg0, Arg1, Arg2)); }
	private void test_case_1() { string Arg0 = "0"; string Arg1 = "0"; string[] Arg2 = new string[]{"1000000000000000000"}; string[] Arg3 = new string[]{"0" }; verify_case(1, Arg3, getElements(Arg0, Arg1, Arg2)); }
	private void test_case_2() { string Arg0 = "823"; string Arg1 = "470"; string[] Arg2 = new string[]{"3","1","31","0","8","29","57","75","8","77"}; string[] Arg3 = new string[]{"117", "470", "2", "823", "115", "87", "49", "25", "115", "23" }; verify_case(2, Arg3, getElements(Arg0, Arg1, Arg2)); }
	private void test_case_3() { string Arg0 = "710370"; string Arg1 = "177300"; string[] Arg2 = new string[]{"5","95","164721","418","3387","710","0","1197","19507","5848"}; string[] Arg3 = new string[]{"178470", "108270", "90", "0", "90", "90", "710370", "90", "0", "0" }; verify_case(3, Arg3, getElements(Arg0, Arg1, Arg2)); }

// END CUT HERE
// BEGIN CUT HERE
    public static void Main()
    {
        AbsSequence ___test = new AbsSequence();
        ___test.run_test(-1);
try {
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
