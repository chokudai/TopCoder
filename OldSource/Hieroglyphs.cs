using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class Hieroglyphs {
    public int minimumVisible(string[] hier1, string[] hier2)
    {
        int i, j;
        List<int> ax1 = new List<int>();
        List<int> ay1 = new List<int>();
        List<int> ax2 = new List<int>();
        List<int> ay2 = new List<int>();
        List<int> bx1 = new List<int>();
        List<int> by1 = new List<int>();
        List<int> bx2 = new List<int>();
        List<int> by2 = new List<int>();
        foreach (string s in hier1)
        {
            string[] st = s.Split(',');
            foreach (string ss in st)
            {
                string[] sst = ss.Split(' ');
                ax1.Add(int.Parse(sst[0]));
                ay1.Add(int.Parse(sst[1]));
                ax2.Add(int.Parse(sst[2]));
                ay2.Add(int.Parse(sst[3]));
            }
        }
        foreach (string s in hier2)
        {
            string[] st = s.Split(',');
            foreach (string ss in st)
            {
                string[] sst = ss.Split(' ');
                bx1.Add(int.Parse(sst[0]));
                by1.Add(int.Parse(sst[1]));
                bx2.Add(int.Parse(sst[2]));
                by2.Add(int.Parse(sst[3]));
            }
        }
        bool[] b1 = new bool[241, 241,2];
        bool[] b2 = new bool[241, 241,2];
        int[] axf = ax1.ToArray();
        int[] ayf = ay1.ToArray();
        int[] axt = ax2.ToArray();
        int[] ayt = ay2.ToArray();
        int[] bxf = bx1.ToArray();
        int[] byf = by1.ToArray();
        int[] bxt = bx2.ToArray();
        int[] byt = by2.ToArray();
        for (i = 0; i < axf.Length; i++)
        {
            int minx = Math.Min(axf[i], axt[i]);
            int maxx = Math.Max(axf[i], axt[i]);
            int miny = Math.Min(ayf[i], ayt[i]);
            int maxy = Math.Max(ayf[i], ayt[i]);
            if (minx == maxx)
            {
                for(i=miny;i<maxy;i++) b1[i,maxi
            }
        }
    }




    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); }
	private void verify_case(int Case, int Expected, int Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { string[] Arg0 = new string[]{"0 0 10 0,10 0 10 3"}; string[] Arg1 = new string[]{"0 1 10 1","5 1 5 4"}; int Arg2 = 16; verify_case(0, Arg2, minimumVisible(Arg0, Arg1)); }
	private void test_case_1() { string[] Arg0 = new string[]{"1 1 1 5"}; string[] Arg1 = new string[]{"3 2 5 2"}; int Arg2 = 6; verify_case(1, Arg2, minimumVisible(Arg0, Arg1)); }
	private void test_case_2() { string[] Arg0 = new string[]{"0 2 6 2"}; string[] Arg1 = new string[]{"5 1 6 1,8 1 9 1"}; int Arg2 = 6; verify_case(2, Arg2, minimumVisible(Arg0, Arg1)); }
	private void test_case_3() { string[] Arg0 = new string[]{"10 20 10 30,15 20 15 30","10 20 15 20,0 30 30 30"}; string[] Arg1 = new string[]{"0 5 0 15,5 5 5 25","0 5 5 5,0 15 5 15"}
; int Arg2 = 65; verify_case(3, Arg2, minimumVisible(Arg0, Arg1)); }
	private void test_case_4() { string[] Arg0 = new string[]{"10 10 10 20,10 30 10 40","10 10 20 10"}; string[] Arg1 = new string[]{"10 0 10 20,10 27 10 35","10 0 20 0"}; int Arg2 = 45; verify_case(4, Arg2, minimumVisible(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
Hieroglyphs ___test = new Hieroglyphs();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
