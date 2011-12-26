using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class BallsConverter {

    int[,] table;
    int len;

    public string theGood(string[] convert)
    {
        len = convert.Length;
        table = new int[len, len];
        int i, j, k;
        for (i = 0; i < len; i++)
        {
            for (j = 0; j < len; j++)
            {
                table[i, j] = con(convert[i][j]);
            }
        }
        for (i = 0; i < len; i++)
        {
            for (j = i; j < len; j++)
            {
                if (table[i, j] != table[j, i]) return "Bad";
            }
        }
        for (i = 0; i < len; i++)
        {
            for (j = i; j < len; j++)
            {
                for (k = j; k < len; k++)
                {
                    int f = table[i, table[j, k]];
                    if (f != table[j, table[i, k]]) return "Bad";
                    if (f != table[k, table[i, j]]) return "Bad";
                }
            }
        }
        return "Good";
    }

    int con(char c)
    {
        if (c >= 'A' && c <= 'Z') return c - 'A';
        else return c - 'a' + 26;
    }


// BEGIN CUT HERE
	public void run_test(int Case) { if ((Case == -1) || (Case == 0)) test_case_0(); if ((Case == -1) || (Case == 1)) test_case_1(); if ((Case == -1) || (Case == 2)) test_case_2(); if ((Case == -1) || (Case == 3)) test_case_3(); if ((Case == -1) || (Case == 4)) test_case_4(); if ((Case == -1) || (Case == 5)) test_case_5(); }
	private void verify_case(int Case, string Expected, string Received) {
		Console.Write("Test Case #" + Case + "...");
		if (Expected == Received) 
			Console.WriteLine("PASSED"); 
		else { 
			Console.WriteLine("FAILED"); 
			Console.WriteLine("\tExpected: \"" + Expected + '\"');
			Console.WriteLine("\tReceived: \"" + Received + '\"'); } }
	private void test_case_0() { string[] Arg0 = new string[]{"AB", "BA"}; string Arg1 = "Good"; verify_case(0, Arg1, theGood(Arg0)); }
	private void test_case_1() { string[] Arg0 = new string[]{"BA", "AA"}; string Arg1 = "Bad"; verify_case(1, Arg1, theGood(Arg0)); }
	private void test_case_2() { string[] Arg0 = new string[]{"ACB", "CBA", "BAC"}; string Arg1 = "Bad"; verify_case(2, Arg1, theGood(Arg0)); }
	private void test_case_3() { string[] Arg0 = new string[]{"AAAA", "ABBB", "ABCC", "ABCD"}; string Arg1 = "Good"; verify_case(3, Arg1, theGood(Arg0)); }
	private void test_case_4() { string[] Arg0 = new string[]{"AAAAAAAAAAAAAAAAAAAAAAAAAAAAAA",
"ABCDEFGHIJKLMNOPQRSTUVWXYZabcd",
"ACEGIKMOQSUWYacACEGIKMOQSUWYac",
"ADGJMPSVYbADGJMPSVYbADGJMPSVYb",
"AEIMQUYcCGKOSWaAEIMQUYcCGKOSWa",
"AFKPUZAFKPUZAFKPUZAFKPUZAFKPUZ",
"AGMSYAGMSYAGMSYAGMSYAGMSYAGMSY",
"AHOVcFMTaDKRYBIPWdGNUbELSZCJQX",
"AIQYCKSaEMUcGOWAIQYCKSaEMUcGOW",
"AJSbGPYDMVAJSbGPYDMVAJSbGPYDMV",
"AKUAKUAKUAKUAKUAKUAKUAKUAKUAKU",
"ALWDOZGRcJUBMXEPaHSdKVCNYFQbIT",
"AMYGSAMYGSAMYGSAMYGSAMYGSAMYGS",
"ANaJWFSBObKXGTCPcLYHUDQdMZIVER",
"AOcMaKYIWGUESCQAOcMaKYIWGUESCQ",
"APAPAPAPAPAPAPAPAPAPAPAPAPAPAP",
"AQCSEUGWIYKaMcOAQCSEUGWIYKaMcO",
"AREVIZMdQDUHYLcPCTGXKbOBSFWJaN",
"ASGYMASGYMASGYMASGYMASGYMASGYM",
"ATIbQFYNCVKdSHaPEXMBUJcRGZODWL",
"AUKAUKAUKAUKAUKAUKAUKAUKAUKAUK",
"AVMDYPGbSJAVMDYPGbSJAVMDYPGbSJ",
"AWOGcUMEaSKCYQIAWOGcUMEaSKCYQI",
"AXQJCZSLEbUNGdWPIBYRKDaTMFcVOH",
"AYSMGAYSMGAYSMGAYSMGAYSMGAYSMG",
"AZUPKFAZUPKFAZUPKFAZUPKFAZUPKF",
"AaWSOKGCcYUQMIEAaWSOKGCcYUQMIE",
"AbYVSPMJGDAbYVSPMJGDAbYVSPMJGD",
"AcaYWUSQOMKIGECAcaYWUSQOMKIGEC",
"AdcbaZYXWVUTSRQPONMLKJIHGFEDCB"}
; string Arg1 = "Good"; verify_case(4, Arg1, theGood(Arg0)); }
	private void test_case_5() { string[] Arg0 = new string[]{"AAAAAFAAAAAAAAAAAAAAAAAXAAAAcAAAAAAAAAAnAAAAAAAvAA",
"ABBBBFBBBBBLBBBBQBBBBBBXYBBBcBBBBBBBBBBnBBBBBBBvwB",
"ABCCCFCCCCCLMCOCQRCCCCCXYCCCcCCCCCCCCCCnCCCCsCCvwC",
"ABCDEFGHDDDLMDODQRSDUVWXYDDbcdDfghDDklDnopDrsDDvwx",
"ABCEEFEEEEELMEOEQRSEUVWXYEEbcEEfEhEEklEnEpEEsEEvwE",
"FFFFFFFFFFFFFFFFFFFFFFFXFFFFcFFFFFFFFFFFFFFFFFFvFF",
"ABCGEFGGGGGLMGOGQRSGUVWXYGGbcGGfGhGGklGnGpGGsGGvwG",
"ABCHEFGHHHHLMHOHQRSHUVWXYHHbcdHfHhHHklHnHpHHsHHvwH",
"ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwx",
"ABCDEFGHJJJLMJOJQRSJUVWXYJJbcdJfghJJklJnopJrsJJvwx",
"ABCDEFGHKJKLMNOPQRSTUVWXYZKbcdefghijklmnopqrsKKvwx",
"ALLLLFLLLLLLLLLLLLLLLLLXLLLLcLLLLLLLLLLnLLLLLLLvwL",
"ABMMMFMMMMMLMMOMQMMMMMMXYMMMcMMMMMMMMMMnMMMMMMMvwM",
"ABCDEFGHNJNLMNOPQRSTUVWXYZNbcdefghijklmnopqrsNNvwx",
"ABOOOFOOOOOLOOOOQOOOOOOXYOOOcOOOOOOOOOOnOOOOOOOvwO",
"ABCDEFGHPJPLMPOPQRSTUVWXYZPbcdPfghiPklmnopPrsPPvwx",
"AQQQQFQQQQQLQQQQQQQQQQQXQQQQcQQQQQQQQQQnQQQQQQQvwQ",
"ABRRRFRRRRRLMRORQRRRRRRXYRRRcRRRRRRRRRRnRRRRRRRvwR",
"ABCSSFSSSSSLMSOSQRSSSSSXYSSScSSSSSSSSSSnSSSSsSSvwS",
"ABCDEFGHTJTLMTOTQRSTUVWXYTTbcdTfghiTklTnopTrsTTvwx",
"ABCUUFUUUUULMUOUQRSUUUWXYUUUcUUUUhUUklUnUUUUsUUvwU",
"ABCVVFVVVVVLMVOVQRSVUVWXYVVbcVVfVhVVklVnVVVVsVVvwV",
"ABCWWFWWWWWLMWOWQRSWWWWXYWWWcWWWWhWWkWWnWWWWsWWvwW",
"XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXvXX",
"AYYYYFYYYYYLYYYYQYYYYYYXYYYYcYYYYYYYYYYnYYYYYYYvwY",
"ABCDEFGHZJZLMZOZQRSTUVWXYZZbcdZfghiZklZnopZrsZZvwx",
"ABCDEFGHaJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwx",
"ABCbbFbbbbbLMbObQRSbUbWXYbbbcbbfbhbbklbnbbbbsbbvwb",
"cccccccccccccccccccccccXcccccccccccccccccccccccvcc",
"ABCdEFGddddLMdOdQRSdUVWXYddbcddfdhddkldndpddsddvwd",
"ABCDEFGHeJeLMeOPQRSTUVWXYZebcdefghijklmnoperseevwx",
"ABCffFfffffLMfOfQRSfUfWXYfffcffffhffklfnffffsffvwf",
"ABCgEFGHgggLMgOgQRSgUVWXYggbcdgfghggklgngpggsggvwg",
"ABChhFhhhhhLMhOhQRShhhhXYhhhchhhhhhhkhhnhhhhshhvwh",
"ABCDEFGHiJiLMiOiQRSiUVWXYiibcdifghiiklinopirsiivwx",
"ABCDEFGHjJjLMjOPQRSTUVWXYZjbcdjfghijklmnopjrsjjvwx",
"ABCkkFkkkkkLMkOkQRSkkkkXYkkkckkkkkkkkkknkkkkskkvwk",
"ABCllFlllllLMlOlQRSlllWXYlllcllllhllkllnllllsllvwl",
"ABCDEFGHmJmLMmOmQRSTUVWXYZmbcdmfghimklmnopmrsmmvwx",
"nnnnnFnnnnnnnnnnnnnnnnnXnnnncnnnnnnnnnnnnnnnnnnvnn",
"ABCoEFGHoooLMoOoQRSoUVWXYoobcdofghooklonoporsoovwx",
"ABCppFpppppLMpOpQRSpUVWXYppbcppfphppklpnpppSsppvwp",
"ABCDEFGHqJqLMqOPQRSTUVWXYZqbcdefghijklmnopqrsqqvwx",
"ABCrEFGHrrrLMrOrQRSrUVWXYrrbcdrfghrrklrnrSrrsrrvwx",
"ABsssFsssssLMsOsQRsssssXYssscssssssssssnsssssssvws",
"ABCDEFGHtJKLMNOPQRSTUVWXYZtbcdefghijklmnopqrsttvwx",
"ABCDEFGHuJKLMNOPQRSTUVWXYZubcdefghijklmnopqrstuvwx",
"vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv",
"AwwwwFwwwwwwwwwwwwwwwwwXwwwwcwwwwwwwwwwnwwwwwwwvww",
"ABCxEFGHxxxLMxOxQRSxUVWXYxxbcdxfghxxklxnxpxxsxxvwx"}
; string Arg1 = "Bad"; verify_case(5, Arg1, theGood(Arg0)); }

// END CUT HERE
// BEGIN CUT HERE
public static void Main() {
try {
BallsConverter ___test = new BallsConverter();
___test.run_test(-1);
} catch(Exception e) {
//Console.WriteLine(e.StackTrace);
Console.WriteLine(e.ToString());
}
}
// END CUT HERE
}
