// BEGIN CUT HERE
PROBLEM STATEMENT
There is an N x M board divided into 1 x 1 cells. The rows 
of the board are numbered from 0 to N-1, and the columns 
are numbered from 0 to M-1. The cell located in row r and 
column c has coordinates (r, c).  

In a coloring of the board, each cell on the board is 
colored white or black. A coloring is called rectangle-
avoiding if it is impossible to choose 4 distinct cells of 
the same color so that their centers form a rectangle 
whose sides are parallel to the sides of the board. In 
other words, a coloring is rectangle-avoiding if, for each 
a, b, c, and d with 0 <= a < b < N, 0 <= c < d < M, there 
is at least one white cell and at least one black cell 
among the cells (a, c), (a, d), (b, c) and (b, d).

You are given a String[] board representing a board. The j-
th character of the i-th element of board represents cell 
(i, j), and it can be 'W', 'B' or '?'. Here, 'W' indicates 
a white cell, 'B' indicates a black cell and '?' indicates 
an uncolored cell. For each uncolored cell, you may choose 
to color it either white or black. Return the number of 
different rectangle-avoiding colorings that can be 
achieved. If it is impossible to achieve a rectangle-
avoiding coloring, return 0.

DEFINITION
Class:RectangleAvoidingColoring
Method:count
Parameters:String[]
Returns:long
Method signature:long count(String[] board)


NOTES
-Two colorings are different if there is a cell on the 
board that is colored white in one coloring and black in 
the other coloring.
-The answer will always fit into a 64-bit signed integer 
data type.


CONSTRAINTS
-board will contain between 1 and 50 elements, inclusive.
-Each element of board will contain between 1 and 50 
characters, inclusive.
-All elements of board will contain the same number of 
characters.
-Each character in each element of board will be 'W', 'B' 
or '?'.


EXAMPLES

0)
{"??",
 "??"}

Returns: 14

Since each cell can be black or white, there are 2^4 = 16 
ways to color this board. Of them, only 2 monochromatic 
colorings are not rectangle-avoiding, so the answer is 16 
- 2 = 14.

1)
{"B?",
 "?B"}

Returns: 3

It is the same board as in previous example, but colors 
for some cells are already predefined. There are 4 ways to 
color the remaining cells and in one of them the board 
becomes completely black. Therefore the answer is 4 - 1 = 3.

2)
{"WW",
 "WW"}

Returns: 0

This board is already colored and the coloring is not 
rectangle-avoiding.

3)
{"??B??",
 "W???W",
 "??B??"}

Returns: 12



4)
{"??",
 "W?",
 "W?",
 "?W",
 "W?"}

Returns: 16



// END CUT HERE
import java.util.*;
public class RectangleAvoidingColoring {
    public long count(String[] board) {
        long res;
        return res;
    }

// BEGIN CUT HERE
    public static void main(String[] args) {
        try {
            eq(0,(new RectangleAvoidingColoring()).count(new String[] {"??",
                "??"}),14L);
            eq(1,(new RectangleAvoidingColoring()).count(new String[] {"B?",
                "?B"}),3L);
            eq(2,(new RectangleAvoidingColoring()).count(new String[] {"WW",
                "WW"}),0L);
            eq(3,(new RectangleAvoidingColoring()).count(new String[] {"??B??",
                "W???W",
                "??B??"}),12L);
            eq(4,(new RectangleAvoidingColoring()).count(new String[] {"??",
                "W?",
                "W?",
                "?W",
                "W?"}),16L);
        } catch( Exception exx) {
            System.err.println(exx);
            exx.printStackTrace(System.err);
        }
    }
    private static void eq( int n, int a, int b ) {
        if ( a==b )
            System.err.println("Case "+n+" passed.");
        else
            System.err.println("Case "+n+" failed: expected "+b+", received "+a+".");
    }
    private static void eq( int n, char a, char b ) {
        if ( a==b )
            System.err.println("Case "+n+" passed.");
        else
            System.err.println("Case "+n+" failed: expected '"+b+"', received '"+a+"'.");
    }
    private static void eq( int n, long a, long b ) {
        if ( a==b )
            System.err.println("Case "+n+" passed.");
        else
            System.err.println("Case "+n+" failed: expected \""+b+"L, received "+a+"L.");
    }
    private static void eq( int n, boolean a, boolean b ) {
        if ( a==b )
            System.err.println("Case "+n+" passed.");
        else
            System.err.println("Case "+n+" failed: expected "+b+", received "+a+".");
    }
    private static void eq( int n, String a, String b ) {
        if ( a != null && a.equals(b) )
            System.err.println("Case "+n+" passed.");
        else
            System.err.println("Case "+n+" failed: expected \""+b+"\", received \""+a+"\".");
    }
    private static void eq( int n, int[] a, int[] b ) {
        if ( a.length != b.length ) {
            System.err.println("Case "+n+" failed: returned "+a.length+" elements; expected "+b.length+" elements.");
            return;
        }
        for ( int i= 0; i < a.length; i++)
            if ( a[i] != b[i] ) {
                System.err.println("Case "+n+" failed. Expected and returned array differ in position "+i);
                print( b );
                print( a );
                return;
            }
        System.err.println("Case "+n+" passed.");
    }
    private static void eq( int n, long[] a, long[] b ) {
        if ( a.length != b.length ) {
            System.err.println("Case "+n+" failed: returned "+a.length+" elements; expected "+b.length+" elements.");
            return;
        }
        for ( int i= 0; i < a.length; i++ )
            if ( a[i] != b[i] ) {
                System.err.println("Case "+n+" failed. Expected and returned array differ in position "+i);
                print( b );
                print( a );
                return;
            }
        System.err.println("Case "+n+" passed.");
    }
    private static void eq( int n, String[] a, String[] b ) {
        if ( a.length != b.length) {
            System.err.println("Case "+n+" failed: returned "+a.length+" elements; expected "+b.length+" elements.");
            return;
        }
        for ( int i= 0; i < a.length; i++ )
            if( !a[i].equals( b[i])) {
                System.err.println("Case "+n+" failed. Expected and returned array differ in position "+i);
                print( b );
                print( a );
                return;
            }
        System.err.println("Case "+n+" passed.");
    }
    private static void print( int a ) {
        System.err.print(a+" ");
    }
    private static void print( long a ) {
        System.err.print(a+"L ");
    }
    private static void print( String s ) {
        System.err.print("\""+s+"\" ");
    }
    private static void print( int[] rs ) {
        if ( rs == null) return;
        System.err.print('{');
        for ( int i= 0; i < rs.length; i++ ) {
            System.err.print(rs[i]);
            if ( i != rs.length-1 )
                System.err.print(", ");
        }
        System.err.println('}');
    }
    private static void print( long[] rs) {
        if ( rs == null ) return;
        System.err.print('{');
        for ( int i= 0; i < rs.length; i++ ) {
            System.err.print(rs[i]);
            if ( i != rs.length-1 )
                System.err.print(", ");
        }
        System.err.println('}');
    }
    private static void print( String[] rs ) {
        if ( rs == null ) return;
        System.err.print('{');
        for ( int i= 0; i < rs.length; i++ ) {
            System.err.print( "\""+rs[i]+"\"" );
            if( i != rs.length-1)
                System.err.print(", ");
        }
        System.err.println('}');
    }
    private static void nl() {
        System.err.println();
    }
// END CUT HERE
}
