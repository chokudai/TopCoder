using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class CorporationSalary {

    long[] sal;
    int len = 0;
    
    public long totalSalary(string[] relations)
    {
        int i;
        long res = 0;
        len = relations.Length;
        sal = new long[len];
        for (i = 0; i < len; i++)
        {
            res += getsal(relations, i);
        }
        return res;
    }

    long getsal(string[] relations, int num)
    {
        int i;
        if (sal[num] != 0) return sal[num];
        long count = 0;
        for (i = 0; i < len; i++)
        {
            if (relations[num][i] == 'Y') count += getsal(relations, i);
        }
        if (count == 0) count = 1;
        return sal[num] = count;
    }




    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); }
	private void verify_case(int Case, long Expected, long Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { string[] Arg0 = new string[]{"N"}; long Arg1 = 1l; verify_case(0, Arg1, totalSalary(Arg0)); }
	private void test_case_1() { string[] Arg0 = new string[]{"NNYN",
 "NNYN",
 "NNNN",
 "NYYN"}; long Arg1 = 5l; verify_case(1, Arg1, totalSalary(Arg0)); }
	private void test_case_2() { string[] Arg0 = new string[]{"NNNNNN",
 "YNYNNY",
 "YNNNNY",
 "NNNNNN",
 "YNYNNN",
 "YNNYNN"}; long Arg1 = 17l; verify_case(2, Arg1, totalSalary(Arg0)); }
	private void test_case_3() { string[] Arg0 = new string[]{"NYNNYN",
 "NNNNNN",
 "NNNNNN",
 "NNYNNN",
 "NNNNNN",
 "NNNYYN"}; long Arg1 = 8l; verify_case(3, Arg1, totalSalary(Arg0)); }
	private void test_case_4() { string[] Arg0 = new string[]{"NNNN",
 "NNNN",
 "NNNN",
 "NNNN"}; long Arg1 = 4l; verify_case(4, Arg1, totalSalary(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
CorporationSalary ___test = new CorporationSalary();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
