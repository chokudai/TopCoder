using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class ProductTriplet {
    public long countTriplets(int minx, int maxx, int miny, int maxy, int minz, int maxz)
    {
        return calc(maxx, maxy, maxz) 
            - calc(minx - 1, maxy, maxz) - calc(maxx, miny - 1, maxz) - calc(maxx, maxy, minz - 1) 
            + calc(minx - 1, miny - 1, maxz) + calc(maxx, miny - 1, minz - 1) + calc(minx - 1, maxy, minz - 1) 
            - calc(minx - 1, miny - 1, minz - 1);
    }

    public long calc(int x, int y, int z)
    {
        long res = 0;
        for (long i = 1; i <= x; i++)
        {
            long get = z / i;
            long next = x;
            if (get != 0) next = Math.Min(x, Math.Max(z / get, i));
            res += Math.Min(get, y) * (next - i + 1);
            i = next;
        }
        return res;
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
	private void test_case_0() { int Arg0 = 2; int Arg1 = 2; int Arg2 = 3; int Arg3 = 3; int Arg4 = 6; int Arg5 = 6; long Arg6 = 1l; verify_case(0, Arg6, countTriplets(Arg0, Arg1, Arg2, Arg3, Arg4, Arg5)); }
	private void test_case_1() { int Arg0 = 2; int Arg1 = 2; int Arg2 = 3; int Arg3 = 3; int Arg4 = 7; int Arg5 = 7; long Arg6 = 0l; verify_case(1, Arg6, countTriplets(Arg0, Arg1, Arg2, Arg3, Arg4, Arg5)); }
	private void test_case_2() { int Arg0 = 6; int Arg1 = 8; int Arg2 = 4; int Arg3 = 5; int Arg4 = 27; int Arg5 = 35; long Arg6 = 4l; verify_case(2, Arg6, countTriplets(Arg0, Arg1, Arg2, Arg3, Arg4, Arg5)); }
	private void test_case_3() { int Arg0 = 1; int Arg1 = 458; int Arg2 = 1; int Arg3 = 458; int Arg4 = 1; int Arg5 = 458; long Arg6 = 2877l; verify_case(3, Arg6, countTriplets(Arg0, Arg1, Arg2, Arg3, Arg4, Arg5)); }
	private void test_case_4() { int Arg0 = 8176; int Arg1 = 184561; int Arg2 = 1348; int Arg3 = 43168; int Arg4 = 45814517; int Arg5 = 957843164; long Arg6 = 2365846085l; verify_case(4, Arg6, countTriplets(Arg0, Arg1, Arg2, Arg3, Arg4, Arg5)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
ProductTriplet ___test = new ProductTriplet();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
