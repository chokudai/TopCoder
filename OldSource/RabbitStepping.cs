using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class RabbitStepping {
    public double getExpected(string field, int r)
    {
        int i,j;
        int len = field.Length;
        int[] ar = new int[field.Length];
        int count = 0;
        int res = 0;
        for (i = 0; i < len; i++) ar[i] = 0;
        for (i = 0; i < r; i++) ar[len - 1 - i] = 1;
        do
        {
            count++;
            int[] nowar = (int[])ar.Clone();
            int[] nowmove = new int[len];
            for (i = len; i > 2; i--)
            {
                //for (j = 0; j < i; j++) Console.Write("{0}", nowar[j]);
                //Console.WriteLine();
                int[] nextar = new int[i - 1];
                int[] nextmove = new int[i - 1];
                for (j = 0; j < i; j++)
                {
                    if (nowar[j] != 0)
                    {
                        if (j == 0)
                        {
                            nextar[j + 1] ^= 1;
                        }
                        else if (j == i - 1 || j == i - 2)
                        {
                            nextar[j - 1] ^= 1;
                            nextmove[j - 1] = 1;
                        }
                        else
                        {
                            if (field[j] == 'W')
                            {
                                nextar[j - 1] ^= 1;
                                nextmove[j - 1] = 1;
                            }
                            else if (field[j] == 'B' || nowmove[j] == 1)
                            {
                                nextar[j + 1] ^= 1;
                            }
                            else
                            {
                                nextar[j - 1] ^= 1;
                                nextmove[j - 1] = 1;
                            }
                        }
                    }
                }
                nowar = (int[])nextar.Clone();
                nowmove = (int[])nextmove.Clone();
            }
            for (i = 0; i < 2; i++) res += nowar[i];
            //if (nowar[0] + nowar[1] == 2) res += 2;
            //else if (nowar[1] == 1) res += 1;
        } while (Algorithm.next_permutation<int>(ar));
        Console.WriteLine(res);
        Console.WriteLine(count);
        return (double)res / count;
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
	private void test_case_0() { string Arg0 = "WRBRW"; int Arg1 = 4; double Arg2 = 0.8; verify_case(0, Arg2, getExpected(Arg0, Arg1)); }
	private void test_case_1() { string Arg0 = "WWB"; int Arg1 = 2; double Arg2 = 1.3333333333333333; verify_case(1, Arg2, getExpected(Arg0, Arg1)); }
	private void test_case_2() { string Arg0 = "WW"; int Arg1 = 1; double Arg2 = 1.0; verify_case(2, Arg2, getExpected(Arg0, Arg1)); }
	private void test_case_3() { string Arg0 = "BBBBBBBBBB"; int Arg1 = 4; double Arg2 = 0.9523809523809523; verify_case(3, Arg2, getExpected(Arg0, Arg1)); }
	private void test_case_4() { string Arg0 = "RRBRRWRRBRRW"; int Arg1 = 8; double Arg2 = 0.9696969696969697; verify_case(4, Arg2, getExpected(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
    RabbitStepping ___test = new RabbitStepping();
    ___test.run_test(-1);
try {
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}

public static partial class Algorithm
{
    public static bool next_permutation<T>(T[] array) where T : IComparable
    {
        return next_permutation(array, 0, array.Length);
    }

    public static bool next_permutation<T>(T[] array, int start, int length) where T : IComparable
    {
        int end = start + length - 1;
        if (end <= start) return false;
        int last = end;
        while (true)
        {
            int pos = last--;
            if (array[last].CompareTo(array[pos]) < 0)
            {
                int i;
                for (i = end + 1; array[last].CompareTo(array[--i]) >= 0; ) { }
                T tmp = array[last]; array[last] = array[i]; array[i] = tmp;
                Array.Reverse(array, pos, end - pos + 1);
                return true;
            }
            if (last == start)
            {
                //Array.Reverse(array, start, end - start);
                return false;
            }
        }
    }
}