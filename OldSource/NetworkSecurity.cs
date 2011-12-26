using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class NetworkSecurity {
    public int secureNetwork(string[] clientCable, string[] serverCable)
    {
        int clen = clientCable.Length;
        int slen = serverCable[0].Length;
        bool[,] b = new bool[slen, clen];
        int i, j, k;
        for (i = 0; i < slen; i++)
        {
            Queue<int> q = new Queue<int>();
            for (j = 0; j < clen; j++) if (serverCable[j][i] == 'Y') { q.Enqueue(j); b[i, j] = true; }
            while (q.Count != 0)
            {
                int next = q.Dequeue();
                for (j = 0; j < clen; j++) if (clientCable[j][next] == 'Y' && !b[i, j]) { q.Enqueue(j); b[i, j] = true; }
            }
        }
        int res = 0;
        for (j = 0; j < clen; j++)
        {
            for (i = 0; i < slen; i++)
            {
                if (serverCable[j][i] != 'Y') continue;
                for (k = 0; k < clen; k++) if (clientCable[j][k] == 'Y' && b[i, k]) break;
                if (k == clen) res++;

            }
        }
        return res;
    }



// BEGIN CUT HERE
	public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); }
	private void verify_case(int Case, int Expected, int Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { string[] Arg0 = new string[]{"NYN"
,"NNN"
,"NYN"}; string[] Arg1 = new string[]{"YN"
,"YN"
,"NY"}; int Arg2 = 2; verify_case(0, Arg2, secureNetwork(Arg0, Arg1)); }
	private void test_case_1() { string[] Arg0 = new string[]{"NN"
,"NN"}; string[] Arg1 = new string[]{"NNN"
,"NNN"}; int Arg2 = 0; verify_case(1, Arg2, secureNetwork(Arg0, Arg1)); }
	private void test_case_2() { string[] Arg0 = new string[]{"NYNN"
,"NNNN"
,"NNNY"
,"NNNN"}; string[] Arg1 = new string[]{"YYN"
,"NNN"
,"NNY"
,"NNN"}; int Arg2 = 3; verify_case(2, Arg2, secureNetwork(Arg0, Arg1)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
NetworkSecurity ___test = new NetworkSecurity();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
