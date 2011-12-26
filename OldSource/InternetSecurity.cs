using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class InternetSecurity {
    public string[] determineWebsite(string[] address, string[] keyword, string[] dangerous, int threshold)
    {
        int i, j;
        Dictionary<string, int> dic = new Dictionary<string, int>();
        Dictionary<string, int> resdic = new Dictionary<string, int>();
        bool[] b = new bool[address.Length];

        for (i = 0; i < dangerous.Length; i++) dic[dangerous[i]] = 1;

        bool flag = true;
        while (flag)
        {
            flag = false;
            for (i = 0; i < keyword.Length; i++)
            {
                if(b[i]) continue;
                int count = 0;
                string[] stt = keyword[i].Split(' ');
                foreach (string sst in stt) if (dic.ContainsKey(sst)) count++;
                if (count >= threshold)
                {
                    flag = true;
                    resdic[address[i]] = 1;
                    string[] st = keyword[i].Split(' ');
                    foreach(string ss in st) dic[ss] = 1;
                    b[i] = true;
                }
            }
        }
        List<string> res = new List<string>();
        for (i = 0; i < keyword.Length; i++) if(resdic.ContainsKey(address[i])) res.Add(address[i]);
        return res.ToArray();
    }




// BEGIN CUT HERE
	public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); }
	private void verify_case(int Case, string[] Expected, string[] Received) {
		Console.Write("Test Case #" + Case + "...");
		if (equal_arrays(Expected, Received)) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: " + print_array(Expected)); 
			Console.WriteLine("\tReceived: " + print_array(Received)); } }
	string print_array(string[] V) {
		System.Text.StringBuilder builder = new System.Text.StringBuilder();
		builder.Append("{ ");
		foreach (string o in V) {
			builder.Append('\"');
			builder.Append(o.ToString());
			builder.Append("\",");
		}
		builder.Append(" }");
		return builder.ToString();
	}
	bool equal_arrays(string[] a, string[]b) {
		if (a.Length != b.Length) return false;
		for (int i = 0; i < a.Length; ++i) if (a[i] != b[i]) return false;
		return true;
	}
	private void test_case_0() { string[] Arg0 = new string[]{"www.topcoder.com",
"www.sindicate_of_evil.com",
"www.happy_citizens.com"}; string[] Arg1 = new string[]{"hack encryption decryption internet algorithm",
"signal interference evil snake poison algorithm",
"flower baloon topcoder blue sky sea"}; string[] Arg2 = new string[]{"hack","encryption","decryption","interference","signal","internet"}; int Arg3 = 3; string[] Arg4 = new string[]{"www.topcoder.com", "www.sindicate_of_evil.com" }; verify_case(0, Arg4, determineWebsite(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_1() { string[] Arg0 = new string[]{"brokenlink","flowerpower.net","purchasedomain.com"}; string[] Arg1 = new string[]{"broken","rose tulips","cheap free domain biggest greatest"}; string[] Arg2 = new string[]{"biggest","enemy","hideout"}; int Arg3 = 2; string[] Arg4 = new string[]{ }; verify_case(1, Arg4, determineWebsite(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_2() { string[] Arg0 = new string[]{"a..a.ab.","...aa.b"}; string[] Arg1 = new string[]{"a bc def","def ghij klmno"}; string[] Arg2 = new string[]{"a","b","c","d","e"}; int Arg3 = 1; string[] Arg4 = new string[]{"a..a.ab.", "...aa.b" }; verify_case(2, Arg4, determineWebsite(Arg0, Arg1, Arg2, Arg3)); }
	private void test_case_3() { string[] Arg0 = new string[]{"www.tsa.gov"}; string[] Arg1 = new string[]{"information assurance signal intelligence research"}; string[] Arg2 = new string[]{"signal","assurance","penguin"}; int Arg3 = 2; string[] Arg4 = new string[]{"www.tsa.gov" }; verify_case(3, Arg4, determineWebsite(Arg0, Arg1, Arg2, Arg3)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
InternetSecurity ___test = new InternetSecurity();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
