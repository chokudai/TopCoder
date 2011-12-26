using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class PotatoGame {
    public string theWinner(int n)
    {
        if ((n % 5) % 2 == 1) return "Taro";
        else return "Hanako";
    }
}


// Powered by FileEdit
// Powered by TZTester 1.01 [25-Feb-2003] [modified for C# by Petr]
// Powered by CodeProcessor
