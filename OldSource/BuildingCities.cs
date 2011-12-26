using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class BuildingCities {

    int[] x, y;

    public int findMinimumCities(int maxDirect, int maxTravel, int[] cityX, int[] cityY)
    {
        int len = cityX.Length;
        int i, j, k;
        int now = 0;
        x = cityX;
        y = cityY;

        int ma = 10000000;
        bool[] used = new bool[len];
        int[] dis = new int[len];
        int[] prev = new int[len];

        for (i = 0; i < len; i++)
        {
            used[i] = false;
            dis[i] = ma;
            prev[i] = -1;
        }
        used[0] = true;
        dis[0] = 0;
        prev[0] = 0;

        while (true)
        {
            if (dis[now] == ma) return -1;
            used[now] = true;
            for (i = 0; i < len; i++)
            {
                if (used[i]) continue;
                if (dist(i, now) > maxTravel) continue;
                if (now == i) continue;
                int nowdis = dis[now] + (int)((dist(i, now)-1e-9) / maxDirect) + 1;
                if (dis[i] > nowdis || (dis[i] >= nowdis && dist(i, now) < dist(now, prev[now])))
                {
                    Console.WriteLine(dis[i] + " " + nowdis + " " + dist(i, now) + " " + dist(now, prev[now]));
                    dis[i] = nowdis;
                    prev[i] = now;
                }
            }
            int next = -1;
            for (i = 0; i < len; i++)
            {
                if (used[i]) continue;
                if (prev[i] == -1) continue;
                if (next == -1 || dis[next]>dis[i])
                {
                    next = i;
                }
            }
            if (next == -1) break;
            now = next;
        }

        int res = 0;
        for (i = 1; i < len; i++)
        {
            if (prev[i] == -1) return -1;
            res += (int)((dist(i, prev[i])-1e-9) / maxDirect);
            Console.WriteLine(dis[i] + " " + (int)((dist(i, prev[i]) - 1e-9) / maxDirect));
        }
        return res;
    }

    double dist(int a, int b)
    {
        return Math.Sqrt((x[a] - x[b]) * (x[a] - x[b]) + (y[a] - y[b]) * (y[a] - y[b]));
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
	private void test_case_0() { int Arg0 = 1; int Arg1 = 5; int[] Arg2 = new int[]{0,0,0,1,2,2,3}; int[] Arg3 = new int[]{0,1,2,2,2,1,1}; int Arg4 = 1; verify_case(0, Arg4, findMinimumCities(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_1() { int Arg0 = 3; int Arg1 = 15; int[] Arg2 = new int[]{2,6,10,14}; int[] Arg3 = new int[]{2,6,2,6}; int Arg4 = 3; verify_case(1, Arg4, findMinimumCities(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_2() { int Arg0 = 2; int Arg1 = 15; int[] Arg2 = new int[]{0,5,2,3,1,8,6,4,7,9,10}; int[] Arg3 = new int[]{0,5,2,3,1,8,6,4,7,9,10}; int Arg4 = 0; verify_case(2, Arg4, findMinimumCities(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_3() { int Arg0 = 2; int Arg1 = 5; int[] Arg2 = new int[]{0,5}; int[] Arg3 = new int[]{0,5}; int Arg4 = -1; verify_case(3, Arg4, findMinimumCities(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_4() { int Arg0 = 5; int Arg1 = 1500; int[] Arg2 = new int[]{0,1000}; int[] Arg3 = new int[]{0,1000}; int Arg4 = 282; verify_case(4, Arg4, findMinimumCities(Arg0, Arg1, Arg2, Arg3)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
BuildingCities ___test = new BuildingCities();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
