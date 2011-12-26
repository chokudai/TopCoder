using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class NewItemShop {

    int[] cost;
    int[] n;
    int[] last;
    double[] per;

    Dictionary<long, double> dic;

    public double getMaximum(int swords, string[] customers)
    {
        //Console.ReadLine();
        cost = new int[24];
        per = new double[24];
        last = new int[24];
        n = new int[24];
        dic = new Dictionary<long, double>();
        int i;
        for (i = 0; i < 24; i++) cost[i] = -1;
        for (i = 0; i < customers.Length; i++)
        {
            string[] st = customers[i].Split(' ');
            int np = 100;
            int l = 0;
            foreach (string s in st)
            {
                string[] sp = s.Split(',');
                int t = int.Parse(sp[0]);
                int c = int.Parse(sp[1]);
                int p = int.Parse(sp[2]);
                cost[t] = c;
                per[t] = (double)p / np;
                n[t] = i;
                l = t;
                np -= p;
            }
            last[l] |= 1 << i;
        }
        return saiki(0, swords, 0);
    }

    double saiki(int flag, int nokori, int t)
    {
        if (t == 24) return 0;
        if (nokori == 0) return 0;
        if(t!=0) flag &= ~last[t-1];
        long num = (long)flag * 25 * 24 + nokori * 24 + t;
        if (dic.ContainsKey(num)) return dic[num];

        double notcome = saiki(flag, nokori, t + 1);
        if (cost[t] == -1 || (flag >> n[t]) % 2 == 1)
        {
            return dic[num] = notcome;
        }
        int nextflag = flag | (1 << n[t]);
        double come = Math.Max(saiki(nextflag, nokori, t + 1), saiki(nextflag, nokori - 1, t + 1) + cost[t]);

        return (dic[num] = ((1 - per[t]) * notcome + per[t] * come));
    }






// BEGIN CUT HERE
	public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); }
	private void verify_case(int Case, double Expected, double Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { int Arg0 = 1; string[] Arg1 = new string[]{ "8,1,80 16,100,11", "12,10,100" }; double Arg2 = 19.0; verify_case(0, Arg2, getMaximum(Arg0, Arg1)); }
	private void test_case_1() { int Arg0 = 2; string[] Arg1 = new string[]{ "8,1,80 16,100,11", "12,10,100" }; double Arg2 = 21.8; verify_case(1, Arg2, getMaximum(Arg0, Arg1)); }
	private void test_case_2() { int Arg0 = 1; string[] Arg1 = new string[]{ "0,90,25 2,90,25 4,90,25 6,90,25", "7,100,80" }; double Arg2 = 90.0; verify_case(2, Arg2, getMaximum(Arg0, Arg1)); }
	private void test_case_3() { int Arg0 = 3; string[] Arg1 = new string[]{ "17,31,41 20,59,26 23,53,5", "19,89,79", "16,32,38 22,46,26", "18,43,38 21,32,7" }; double Arg2 = 135.5121414; verify_case(3, Arg2, getMaximum(Arg0, Arg1)); }
    private void test_case_4()
    {
        int Arg0 = 20; string[] Arg1 = new string[] {"0,72,84",
"1,81,90",
"2,76,86",
"3,30,73",
"4,78,82",
"5,97,88",
"6,92,83",
"7,59,100",
"8,71,75",
"9,20,79",
"10,55,76",
"11,74,76",
"12,59,80",
"13,77,90",
"14,21,92",
"15,64,72",
"16,85,86",
"17,6,97",
"18,33,72",
"19,71,90",
"20,3,74",
"21,45,73",
"22,81,95",
"23,67,72" }; double Arg2 = 2.1999744634845344; verify_case(4, Arg2, getMaximum(Arg0, Arg1));
    }

    //private void test_case_4() { int Arg0 = 5; string[] Arg1 = new string[]{ "1,1,10", "2,2,9", "3,3,8", "4,4,7", "5,5,6", "6,6,5", "7,7,4", "8,8,3", "9,9,2", "10,10,1" }; double Arg2 = 2.1999744634845344; verify_case(4, Arg2, getMaximum(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
    public static void Main()
    {
        NewItemShop ___test = new NewItemShop();
        ___test.run_test(-1);
try {
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
