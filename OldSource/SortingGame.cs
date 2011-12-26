using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class SortingGame {

    int len;

    public int fewestMoves(int[] board, int k)
    {
        len = board.Length;
        Dictionary<int, int> dic = new Dictionary<int, int>();
        int i, j;
        k--;
        int target = 0;
        for (i = 0; i < len; i++)
        {
            target *= 10;
            target += i + 1;
        }
        Queue<int> q = new Queue<int>();
        int first = getNum(board);
        if (first == target) return 0;
        dic[first] = 0;
        q.Enqueue(first);
        while (q.Count != 0)
        {
            int now = q.Dequeue();
            for (i = 0; i < len - k; i++)
            {
                int[] ar = getArray(now);
                for (j = 0; j <= k / 2; j++)
                {
                    int c = ar[i + j];
                    ar[i + j] = ar[i + k - j];
                    ar[i + k - j] = c;
                }
                int next = getNum(ar);
                if (dic.ContainsKey(next)) continue;
                //Console.WriteLine(now + " " + next);
                dic[next] = dic[now] + 1;
                if (target == next) return dic[next];
                q.Enqueue(next);
            }
        }
        return -1;
        
    }

    int[] getArray(int a)
    {
        int[] res = new int[len];
        for (int i = 0; i < len; i++)
        {
            res[len - i - 1] = a % 10;
            a /= 10;
        }
        return res;
    }

    int getNum(int[] ar)
    {
        int res = 0;
        for (int i = 0; i < len; i++)
        {
            res *= 10;
            res += ar[i]; 
        }
        return res;
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
	private void test_case_0() { int[] Arg0 = new int[]{1,2,3}; int Arg1 = 3; int Arg2 = 0; verify_case(0, Arg2, fewestMoves(Arg0, Arg1)); }
	private void test_case_1() { int[] Arg0 = new int[]{3,2,1}; int Arg1 = 3; int Arg2 = 1; verify_case(1, Arg2, fewestMoves(Arg0, Arg1)); }
	private void test_case_2() { int[] Arg0 = new int[]{5,4,3,2,1}; int Arg1 = 2; int Arg2 = 10; verify_case(2, Arg2, fewestMoves(Arg0, Arg1)); }
	private void test_case_3() { int[] Arg0 = new int[]{3,2,4,1,5}; int Arg1 = 4; int Arg2 = -1; verify_case(3, Arg2, fewestMoves(Arg0, Arg1)); }
	private void test_case_4() { int[] Arg0 = new int[]{7,2,1,6,8,4,3,5}; int Arg1 = 4; int Arg2 = 7; verify_case(4, Arg2, fewestMoves(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
SortingGame ___test = new SortingGame();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
