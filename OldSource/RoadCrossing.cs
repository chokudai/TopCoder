using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class RoadCrossing {
    int[] v;
    int[] t;
    double[] p;
    double getres;
    int rw, cw;
    int ca;
    int len;
    public double passTime(string[] pedestrians, int roadWidth, int carWidth, int carArrival)
    {
        len = pedestrians.Length;
        int i, j, k;
        v = new int[len];
        t = new int[len];
        p = new double[len];
        rw = roadWidth;
        cw = carWidth;
        ca = carArrival;
        getres = double.MaxValue;
        for (i = 0; i < len; i++)
        {
            string[] s = pedestrians[i].Split(' ');
            t[i] = int.Parse(s[0]);
            v[i] = int.Parse(s[1]);
            p[i] = (double)t[i] * v[i] * -1;
        }
        calc(ca);
        for (i = 0; i < len; i++)
        {
            for (j = 0; j < len; j++)
            {
                double v0 = v[i] - v[j];
                if (v0 == 0) continue;
                double t1 = (p[j] - p[i] + carWidth) / v0;
                calc(t1);
            }
            double tt;
            tt = (carWidth - p[i]) / v[i];
            calc(tt);
            tt = ((roadWidth - carWidth) - p[i]) / v[i];
            calc(tt);
        }
        return getres;
    }

    void calc(double time)
    {
        if (time + 1e-9 < ca) return;
        int i;
        List<double> l = new List<double>();
        for (i = 0; i < len; i++)
        {
            double pos = p[i] + v[i] * time;
            l.Add(pos);
        }
        l.Add(0);
        l.Add(rw);
        double[] ar = l.ToArray();
        Array.Sort(ar);
        for (i = 0; i < ar.Length - 1; i++)
        {
            if (ar[i] + 1e-9 < 0) continue;
            if (ar[i] + 1e-9 >= rw) break;
            double dist = ar[i + 1] - ar[i];
            if (dist + 1e-9 >= cw) getres = Math.Min(getres, time);
        }
        return;
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
	private void test_case_0() { string[] Arg0 = new string[]{"0 1", "2 5"}; int Arg1 = 8; int Arg2 = 4; int Arg3 = 3; double Arg4 = 3.5; verify_case(0, Arg4, passTime(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_1() { string[] Arg0 = new string[]{"40 1"}; int Arg1 = 100; int Arg2 = 100; int Arg3 = 41; double Arg4 = 140.0; verify_case(1, Arg4, passTime(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_2() { string[] Arg0 = new string[]{"0 1", "0 2", "0 4", "0 8", "0 16", "0 32", "0 64", "0 128", "0 256"}; int Arg1 = 100; int Arg2 = 50; int Arg3 = 3; double Arg4 = 3.125; verify_case(2, Arg4, passTime(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_3() { string[] Arg0 = new string[]{"0 1", "0 2", "0 4", "0 8", "0 16", "0 32", "0 64", "0 128", "0 256"}; int Arg1 = 100; int Arg2 = 51; int Arg3 = 3; double Arg4 = 51.0; verify_case(3, Arg4, passTime(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_4() { string[] Arg0 = new string[]{"1000 1", "100 1"}; int Arg1 = 1000; int Arg2 = 1000; int Arg3 = 1000; double Arg4 = 2000.0; verify_case(4, Arg4, passTime(Arg0, Arg1, Arg2, Arg3)); }

// END CUT HERE
// BEGIN CUT HERE
    public static void Main()
    {
        RoadCrossing ___test = new RoadCrossing();
        ___test.run_test(-1);
try {
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
