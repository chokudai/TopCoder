using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class TheBlackJackDivOne {
    public double expected(string[] cards)
    {
        int nokorisum = 52 - cards.Length;
        int[] nokori = new int[13];
        int i;
        int sum = 0;
        for (i = 0; i < 11; i++)
        {
            nokori[i] = 4;
        }
        nokori[9] = 16;
        int flag = 0;
        for (i = 0; i < cards.Length; i++)
        {
            if (cards[i][0] == 'J' || cards[i][0] == 'Q' || cards[i][0] == 'K' || cards[i][0] == 'T')
            {
                nokori[9]--;
                sum += 10;
            }
            else if (cards[i][0] == 'A')
            {
                nokori[0]--;
                sum += 1;
                flag++;
            }
            else
            {
                int num = cards[i][0] - '1';
                nokori[num]--;
                sum += num + 1;
            }
        }
        return res(flag, sum, nokori, nokorisum);
    }

    double res(int hasAce, int sum, int[] nokori,int nokorisum)
    {
        if(sum + hasAce * 10>=21) return 0.0;
        double r = 1;
        int i;
        for (i = 0; i < 10; i++)
        {
            if (nokori[i] == 0) continue;
            double p = nokori[i] / (double)nokorisum;
            nokori[i]--;
            int plus = 0;
            if (i == 0) plus++;
            r += p * res((hasAce + plus), sum + i + 1, nokori, nokorisum - 1);
            nokori[i]++;
        }
        return r;
    }




    // BEGIN CUT HERE
    public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); }
	private void verify_case(int Case, double Expected, double Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { string[] Arg0 = new string[]{"JS"}; double Arg1 = 2.105854341736695; verify_case(0, Arg1, expected(Arg0)); }
	private void test_case_1() { string[] Arg0 = new string[]{"KD", "8S"}; double Arg1 = 1.08; verify_case(1, Arg1, expected(Arg0)); }
	private void test_case_2() { string[] Arg0 = new string[]{"KD", "2S", "2C", "2D", "2H"}; double Arg1 = 1.0; verify_case(2, Arg1, expected(Arg0)); }
	private void test_case_3() { string[] Arg0 = new string[]{"AS", "KS", "9S", "JC", "2D"}; double Arg1 = 0.0; verify_case(3, Arg1, expected(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
TheBlackJackDivOne ___test = new TheBlackJackDivOne();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
