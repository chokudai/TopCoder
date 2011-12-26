using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class GasStations {

    public double tripCost(int[] dist, int[] price, int mpg, int tankSize, int tripLength)
    {
        int i, j;
        int len = dist.Length;
        for (i = 0; i < len; i++)
        {
            for (j = 0; j < len - 1; j++)
            {
                if (dist[j] > dist[j + 1])
                {
                    int temp = dist[j + 1];
                    dist[j + 1] = dist[j];
                    dist[j] = temp;
                    temp = price[j + 1];
                    price[j + 1] = price[j];
                    price[j] = temp;
                }
            }
        }
        double[] buy = new double[len]; //çwì¸ó 
        double[] need = new double[len];//ïKóvó 
        double[] now = new double[len]; //écÇËó 
        bool[] flag = new bool[len];
        double res = 0;
        for (i = 0; i < len; i++)
        {
            double nokori = tankSize;
            for (j = 0; j < len; j++)
            {
                nokori -= dist[j] / (double)mpg;
                if (j != 0) nokori += dist[j - 1] / (double)mpg;
                if (nokori < 0) nokori = 0;
                nokori += buy[j];
                now[j] = nokori;
            }
            for (j = len - 1; j >= 0; j--)
            {
                if (flag[j]) need[j] = 0;
                else
                {
                    if (j == len - 1) need[j] = (tripLength - dist[j]) / (double)mpg;
                    else need[j] = need[j + 1] + (dist[j + 1] - dist[j]) / (double)mpg;
                }
            }
            int minnum = -1;
            int minprice = 9999999;
            for (j = 0; j < len; j++)
            {
                if (!flag[j] && minprice > price[j])
                {
                    minnum = j;
                    minprice = price[j];
                }
            }
            flag[minnum] = true;
            buy[minnum] = Math.Max(0, Math.Min(tankSize, need[minnum]) - now[minnum]);
            res += buy[minnum] * minprice;
        }
        return res;
    }




    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); if ((Case == -1) || (Case == 5)) test_case_5(); }
	private void verify_case(int Case, double Expected, double Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { int[] Arg0 = new int[]{100,100}; int[] Arg1 = new int[]{1000,1500}; int Arg2 = 20; int Arg3 = 10; int Arg4 = 300; double Arg5 = 5000.0; verify_case(0, Arg5, tripCost(Arg0, Arg1, Arg2, Arg3, Arg4)); }
	private void test_case_1() { int[] Arg0 = new int[]{300,450,525}; int[] Arg1 = new int[]{1659,1529,1439}; int Arg2 = 20; int Arg3 = 20; int Arg4 = 600; double Arg5 = 15277.5; verify_case(1, Arg5, tripCost(Arg0, Arg1, Arg2, Arg3, Arg4)); }
	private void test_case_2() { int[] Arg0 = new int[]{300,450,525}; int[] Arg1 = new int[]{1659,1439,1529}; int Arg2 = 20; int Arg3 = 20; int Arg4 = 600; double Arg5 = 14940.0; verify_case(2, Arg5, tripCost(Arg0, Arg1, Arg2, Arg3, Arg4)); }
	private void test_case_3() { int[] Arg0 = new int[]{300,125,450,525}; int[] Arg1 = new int[]{1659,1729,1439,1529}; int Arg2 = 20; int Arg3 = 20; int Arg4 = 600; double Arg5 = 14940.0; verify_case(3, Arg5, tripCost(Arg0, Arg1, Arg2, Arg3, Arg4)); }
	private void test_case_4() { int[] Arg0 = new int[]{200}; int[] Arg1 = new int[]{1000}; int Arg2 = 20; int Arg3 = 20; int Arg4 = 400; double Arg5 = 0.0; verify_case(4, Arg5, tripCost(Arg0, Arg1, Arg2, Arg3, Arg4)); }
	private void test_case_5() { int[] Arg0 = new int[]{100,400}; int[] Arg1 = new int[]{1549,1649}; int Arg2 = 25; int Arg3 = 16; int Arg4 = 600; double Arg5 = 12792.0; verify_case(5, Arg5, tripCost(Arg0, Arg1, Arg2, Arg3, Arg4)); }

// END CUT HERE
// BEGIN CUT HERE
    public static void Main()
    {
        GasStations ___test = new GasStations();
        ___test.run_test(-1);
try {
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
