using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class StrongEconomy {
    public long earn(long n, long k, long price, long target)
    {
        if (target == 0) return 0;
        else if (target <= 1.0 * n * k) return 1;
        int i;
        long res = (long)((target + 1.0 * n * k - 1e-27) / (1.0 * n * k));
        
        long money = 0;

        long turn = 0;
        for (i = 1; i <= 2000003; i++)
        {
            long plus = 0;
            if (money < price)
            {
                plus = (long)((price - money + 1.0 * n * k - 1e-27) / (1.0 * n * k));
                money += n * k * plus;
            }
            money -= price;
            turn += plus;
            if (n <= k) n++;
            else k++;
            long nowres;
            if (target <= money) nowres = turn;
            else nowres = (long)((target - money + 1.0 * n * k - 1e-27) / (1.0 * n * k)) + turn;
            //Console.WriteLine(n + " " + k + " " + turn + " " + money + " " + nowres);
            res = Math.Min(res, nowres);
        }
        return res;
    }



    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); }
	private void verify_case(int Case, long Expected, long Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { long Arg0 = 2l; long Arg1 = 1l; long Arg2 = 2l; long Arg3 = 10l; long Arg4 = 4l; verify_case(0, Arg4, earn(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_1() { long Arg0 = 2l; long Arg1 = 1l; long Arg2 = 2l; long Arg3 = 9l; long Arg4 = 3l; verify_case(1, Arg4, earn(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_2() { long Arg0 = 1l; long Arg1 = 1l; long Arg2 = 500000l; long Arg3 = 1000002l; long Arg4 = 1000001l; verify_case(2, Arg4, earn(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_3() { long Arg0 = 5l; long Arg1 = 4l; long Arg2 = 15l; long Arg3 = 100l; long Arg4 = 5l; verify_case(3, Arg4, earn(Arg0, Arg1, Arg2, Arg3)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
StrongEconomy ___test = new StrongEconomy();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
