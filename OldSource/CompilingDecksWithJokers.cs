using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class CompilingDecksWithJokers {
    public int maxCompleteDecks(int[] cards, int jokers)
    {
        long res = 0;
        while (true)
        {
            int i, j;
            Array.Sort(cards);
            for (i = 1; i < cards.Length; i++)
            {
                if (cards[0] != cards[i]) break;
            }
            int num = 99999999;
            if (i != cards.Length) num = cards[i] - cards[0];
            int usejoker = Math.Min(jokers / i, num);
            if (i != 1) usejoker = Math.Min(usejoker, cards[0] / (i - 1));
            //Console.WriteLine(usejoker);
            if (usejoker == 0) break;
            int dec = usejoker * i;
            for (j = 0; j < cards.Length; j++)
            {
                cards[j] -= dec;
                if (j < i) cards[j] += usejoker;
            }
            jokers -= usejoker * i;
            res += usejoker * i;
        }
        while (jokers > 0)
        {
            Array.Sort(cards);
            int i;
            for (i = 1; i < cards.Length; i++)
            {
                if (cards[i] == 0) return (int)res;
                cards[i]--;
            }
            jokers--;
            res++;
        }
        Array.Sort(cards);
        return (int)res + cards[0];
    }




// BEGIN CUT HERE
	public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); }
	private void verify_case(int Case, int Expected, int Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { int[] Arg0 = new int[]{10, 15}; int Arg1 = 3; int Arg2 = 13; verify_case(0, Arg2, maxCompleteDecks(Arg0, Arg1)); }
	private void test_case_1() { int[] Arg0 = new int[]{1, 2, 3}; int Arg1 = 4; int Arg2 = 3; verify_case(1, Arg2, maxCompleteDecks(Arg0, Arg1)); }
	private void test_case_2() { int[] Arg0 = new int[]{1}; int Arg1 = 5; int Arg2 = 6; verify_case(2, Arg2, maxCompleteDecks(Arg0, Arg1)); }
	private void test_case_3() { int[] Arg0 = new int[]{2, 3, 4, 5, 6}; int Arg1 = 4; int Arg2 = 4; verify_case(3, Arg2, maxCompleteDecks(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
CompilingDecksWithJokers ___test = new CompilingDecksWithJokers();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
