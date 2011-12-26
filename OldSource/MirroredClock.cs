using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class MirroredClock {
    public string whatTimeIsIt(string time)
    {
        int t = 0;
        t += (time[0] - '0') * 600;
        t += (time[1] - '0') * 60;
        t += (time[3] - '0') * 10;
        t += (time[4] - '0') * 1;
        t = 12 * 60 - t;
        t %= 12 * 60;
        return string.Concat(t / 600, (t % 600) / 60, ":", (t % 60) / 10, (t % 10) / 1);
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
	private void test_case_0() { string Arg0 = "10:00"; string Arg1 = "02:00"; verify_case(0, Arg1, whatTimeIsIt(Arg0)); }
	private void test_case_1() { string Arg0 = "01:15"; string Arg1 = "10:45"; verify_case(1, Arg1, whatTimeIsIt(Arg0)); }
	private void test_case_2() { string Arg0 = "03:40"; string Arg1 = "08:20"; verify_case(2, Arg1, whatTimeIsIt(Arg0)); }
	private void test_case_3() { string Arg0 = "00:00"; string Arg1 = "00:00"; verify_case(3, Arg1, whatTimeIsIt(Arg0)); }
	private void test_case_4() { string Arg0 = "11:53"; string Arg1 = "00:07"; verify_case(4, Arg1, whatTimeIsIt(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
MirroredClock ___test = new MirroredClock();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
