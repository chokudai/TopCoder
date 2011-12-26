using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class VLNString {
    public string makeAcronym(string longName)
    {
        Dictionary<string, int> dic = new Dictionary<string, int>();
        dic["and"] = 1;
        dic["the"] = 1;
        dic["of"] = 1;
        string[] ss = longName.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);
        string res = "";
        foreach (string s in ss)
        {
            if (!dic.ContainsKey(s))
            {
                res += (char)(s[0] + 'A' - 'a');
            }
        }
        return res;
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
	private void test_case_0() { string Arg0 = "dance dance revolution"; string Arg1 = "DDR"; verify_case(0, Arg1, makeAcronym(Arg0)); }
	private void test_case_1() { string Arg0 = "  return  of  the king   "; string Arg1 = "RK"; verify_case(1, Arg1, makeAcronym(Arg0)); }
	private void test_case_2() { string Arg0 = "the united states of america"; string Arg1 = "USA"; verify_case(2, Arg1, makeAcronym(Arg0)); }
	private void test_case_3() { string Arg0 = " of  the   and    "; string Arg1 = ""; verify_case(3, Arg1, makeAcronym(Arg0)); }
	private void test_case_4() { string Arg0 = " "; string Arg1 = ""; verify_case(4, Arg1, makeAcronym(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
VLNString ___test = new VLNString();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
