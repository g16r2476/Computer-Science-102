using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CS102_Prac_2_B
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int length(string s)
        {
            int leng = 0;
            foreach (char c in s)
            {
                leng++;
            }
            return leng;
        }
        bool contains(string s, string subs)
        {
            bool yes = false;
            int leng = length(subs);
            int leng2 = length(s);
            int x = 0;
            int y = 0;
            while ((leng > 0) && (leng2 > 0))
            {
                if (s[x] == subs[y])
                {
                    x++;
                    y++;
                    leng--;
                    leng2--;
                }
                else
                {
                    x++;
                    leng2--;
                }
            }
            if (leng == y)
            {
                yes = true;
            }
            return yes;
        }
        int indexOf(string s, string subs)
        {
            int leng = length(subs);
            int leng2 = length(s);
            int x = 0;
            int y = 0;
            if (contains(s, subs) == true)
            {
                while (leng2 > 0)
                {
                    if (s[x] == subs[y])
                    {
                        break;
                    }
                    else
                    {
                        x++;
                        leng2--;
                    }
                }
            }
            else
            {
                x = -1;
            }
            return x;
        }
        string insertSubString(string s, string x, int pos)
        {
            int leng = length(x);
            int leng2 = length(s);
            int y = 0;
            int z = pos + 1;
            string answer = "";
            string sub1 = "";
            string sub2 = "";
            if (pos > leng2)
            {
                return answer;
            }
            else {
                while (y < pos)
                {
                    sub1 = sub1 + s[y];
                    y++;
                }
                while (z < (leng2 - 1))
                {
                    sub2 = sub2 + s[z];
                    z++;
                }
                answer = sub1 + x + sub2;
            }
            return answer; 
        }
        string replaceSubString(string s, string neew, string old)
        {
            string answer = "";
            int x = 0;
            if (contains(s, old) == true)
            {
                while (contains(s, old) == true)
                {
                  answer = insertSubString(s, neew, indexOf(s, old));
                }
            }
            else
            {
                answer = "";
            }
            return answer;
        }
        string deleteSubString(string s, string subs)
        {
            string replace = "";
            string answer = replaceSubString(s, replace, subs);
            return answer;
        }
        List<string> split(string s, char c)
        {
            List<string> answers = new List<string> ();
            int x = 0;
            int y = 0;

            foreach (char d in s)
            {
                if(d == s[x])
                {
                    int z = 
                }
            }
        }
        int stringCompare(string s1, string s2)
        {

        }
        string toLower1(string s)
        {
            switch (s)
            {
                case "A": return "a";
                case "B": return "b";
                case "C": return "c";
                case "D": return "d";
                case "E": return "e";
                case "F": return "f";
                case "G": return "g";
                case "H": return "h";
                case "I": return "i";
                case "J": return "j";
                case "K": return "k";
                case "L": return "l";
                case "M": return "m";
                case "N": return "n";
                case "O": return "o";
                case "P": return "p";
                case "Q": return "q";
                case "R": return "r";
                case "S": return "s";
                case "T": return "t";
                case "U": return "u";
                case "V": return "v";
                case "W": return "w";
                case "X": return "x";
                case "Y": return "y";
                case "Z": return "z";
                default: return "error";
                    // method used for the lower case replace method
            }    
        }
        string toLower(string s)
        {
            foreach (char c in s)
            {
               s = replaceSubString(s, toLower1(s), s);
            }
            return s;
        }
        string toUpper1(string s)
        {
            switch (s)
            {
                case "a": return "A";
                case "b": return "B";
                case "c": return "C";
                case "d": return "D";
                case "e": return "E";
                case "f": return "F";
                case "g": return "G";
                case "h": return "H";
                case "i": return "I";
                case "j": return "J";
                case "k": return "K";
                case "l": return "L";
                case "m": return "M";
                case "n": return "N";
                case "o": return "O";
                case "p": return "P";
                case "q": return "Q";
                case "r": return "R";
                case "s": return "S";
                case "t": return "T";
                case "u": return "U";
                case "v": return "V";
                case "w": return "W";
                case "x": return "X";
                case "y": return "Y";
                case "z": return "Z";
                default: return "error";
                    // method used for the lower case replace method
            }
        }
        string toUpper(string s)
        {
            foreach (char c in s)
            {
                s = replaceSubString(s, toUpper1(s), s);
            }
            return s;
        }
    }
}
