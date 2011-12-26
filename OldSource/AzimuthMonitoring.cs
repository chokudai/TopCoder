using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class AzimuthMonitoring {
    public int getAzimuth(string[] instructions)
    {
        int i;
        int res = 0;
        for (i = 0; i < instructions.Length; i++)
        {
            if (instructions[i] == "HALT") break;
            else if (instructions[i] == "TURN AROUND") res += 180;
            else if (instructions[i] == "RIGHT") res += 90;
            else if (instructions[i] == "LEFT") res += 270;
            else
            {
                string[] s = instructions[i].Split(' ');
                if (s[0] == "RIGHT") res += int.Parse(s[1]);
                else res += 360 - int.Parse(s[1]);
            }
        }
        return res % 360;
    }




    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); if ((Case == -1) || (Case == 5)) test_case_5(); }
	private void verify_case(int Case, int Expected, int Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { string[] Arg0 = new string[]{"RIGHT"}; int Arg1 = 90; verify_case(0, Arg1, getAzimuth(Arg0)); }
	private void test_case_1() { string[] Arg0 = new string[]{"LEFT", "LEFT", "TURN AROUND"}; int Arg1 = 0; verify_case(1, Arg1, getAzimuth(Arg0)); }
	private void test_case_2() { string[] Arg0 = new string[]{"LEFT 5", "RIGHT 10", "LEFT 15", "RIGHT 20", "LEFT 25", "RIGHT 30", "LEFT 35", "RIGHT 40"}; int Arg1 = 20; verify_case(2, Arg1, getAzimuth(Arg0)); }
	private void test_case_3() { string[] Arg0 = new string[]{"RIGHT 59", "RIGHT", "RIGHT", "HALT", "LEFT", "LEFT", "LEFT"}; int Arg1 = 239; verify_case(3, Arg1, getAzimuth(Arg0)); }
	private void test_case_4() { string[] Arg0 = new string[]{"TURN AROUND", "HALT", "LEFT 5", "HALT", "LEFT 5", "HALT"}; int Arg1 = 180; verify_case(4, Arg1, getAzimuth(Arg0)); }
	private void test_case_5() { string[] Arg0 = new string[]{"LEFT", "LEFT", "LEFT", "LEFT", "LEFT", "HALT"}; int Arg1 = 270; verify_case(5, Arg1, getAzimuth(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
AzimuthMonitoring ___test = new AzimuthMonitoring();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
