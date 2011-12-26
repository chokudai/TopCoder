using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class Tetrahedron {
    public string exists(string[] d)
    {
        int i, j, k;
        int len = d.Length;
        int[,] dist = new int[len, len];
        for (i = 0; i < len; i++)
        {
            string[] st = d[i].Split(' ');
            for (j = 0; j < len; j++)
            {
                dist[i, j] = int.Parse(st[j]);
            }
        }
        double[] x = new double[len];
        double[] y = new double[len];
        double[] z = new double[len];
        x[0] = y[0] = 0;
        x[1] = 0;
        y[1] = dist[0, 1];
        x[2] = dist[0, 2];
        y[2] = 0;
        x[3] = 10;
        y[3] = 10;
        z[0] = z[1] = z[2] = 0;
        z[3] = 10;
        Random r = new Random();
        if (dist[0, 1] + dist[1, 2] == dist[0, 2])
        {
            x[2] = 0;
            y[2] = dist[0, 2];
        }
        if (dist[0, 2] + dist[2, 1] == dist[0, 1])
        {
            x[2] = 0;
            y[2] = dist[0, 1] - dist[2, 1];
        }
        if (dist[1, 0] + dist[0, 2] == dist[1, 2])
        {
            x[2] = 0;
            y[2] = dist[0, 2] - dist[1, 2];
        }
        for (i = 0; i < 200000; i++)
        {
            for (j = 0; j < 2; j++)
            {
                double di = Math.Sqrt((x[j] - x[2]) * (x[j] - x[2]) + (y[j] - y[2]) * (y[j] - y[2]));
                double need = dist[j, 2];
                if (di != 0) need = (dist[j, 2] / di) - 1;
                x[2] -= (x[j] - x[2]) * need * r.NextDouble();
                y[2] -= (y[j] - y[2]) * need * r.NextDouble();
            }
        }
        for (i = 0; i < 200000; i++)
        {
            for (j = 0; j < 3; j++)
            {
                double di = Math.Sqrt((x[j] - x[3]) * (x[j] - x[3]) + (y[j] - y[3]) * (y[j] - y[3]) + (z[j] - z[3]) * (z[j] - z[3]));
                double need = dist[j, 3];
                if (di != 0) need = (dist[j, 3] / di) - 1;
                x[3] -= (x[j] - x[3]) * need * r.NextDouble();
                y[3] -= (y[j] - y[3]) * need * r.NextDouble();
                z[3] -= (z[j] - z[3]) * need * r.NextDouble();
            }
        }
        for (i = 0; i < len; i++)
        {
            for (j = 0; j < len; j++)
            {
                double di = Math.Sqrt((x[j] - x[i]) * (x[j] - x[i]) + (y[j] - y[i]) * (y[j] - y[i]) + (z[j] - z[i]) * (z[j] - z[i]));
                if (Math.Abs(dist[i, j] - di) > 7e-4)
                {
                    Console.WriteLine(Math.Abs(dist[i, j] - di));
                    return "NO";
                }
            }
            //Console.WriteLine();
        }
        return "YES";
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
	private void test_case_0() { string[] Arg0 = new string[]{"0 1 1 1",
 "1 0 1 1",
 "1 1 0 1",
 "1 1 1 0"}; string Arg1 = "YES"; verify_case(0, Arg1, exists(Arg0)); }
	private void test_case_1() { string[] Arg0 = new string[]{"0 1 2 3",
 "1 0 1 2",
 "2 1 0 1",
 "3 2 1 0"}; string Arg1 = "YES"; verify_case(1, Arg1, exists(Arg0)); }
	private void test_case_2() { string[] Arg0 = new string[]{"0 1 2 4",
 "1 0 1 2",
 "2 1 0 1",
 "4 2 1 0"}; string Arg1 = "NO"; verify_case(2, Arg1, exists(Arg0)); }
	private void test_case_3() { string[] Arg0 = new string[]{"0 6 6 3",
 "6 0 4 5",
 "6 4 0 4",
 "3 5 4 0"}; string Arg1 = "YES"; verify_case(3, Arg1, exists(Arg0)); }
	private void test_case_4() { string[] Arg0 = new string[]{"0 6 6 2",
 "6 0 4 5",
 "6 4 0 4",
 "2 5 4 0"}; string Arg1 = "NO"; verify_case(4, Arg1, exists(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
Tetrahedron ___test = new Tetrahedron();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
