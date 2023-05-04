
class Programm
{
    static void IPv4OrIPv6(string str)
    {
        int countDot = str.Count(s => s == '.');
        int countColon = str.Count(s => s == ':');

        if (countDot != 3 && countColon != 7) Console.WriteLine("Neither");
        else
        {
            if (countDot == 3 && countColon == 0) IPv4(str);
            else if (countDot == 0 && countColon == 7) IPv6(str);
            else Console.WriteLine("Neither");
        }
    }

    static void IPv4(string str)
    {
        string x1 = "";
        string x2 = "";
        string x3 = "";
        string x4 = "";

        int k = 0;
        for(int i = 0;i < str.Length && k < 4; i++)
        {
            if (str[i] != '.')
            {
                if (k == 0) x1 += str[i];
                if (k == 1) x2 += str[i];
                if (k == 2) x3 += str[i];
                if (k == 3) x4 += str[i];
            }
            else k++;
        }

        bool x1b = true;
        bool x2b = true;
        bool x3b = true;
        bool x4b = true;

        if (Convert.ToInt32(x1) >= 0 && Convert.ToInt32(x1) <= 255) x1b = true;
        else x1b= false;
        if (x1.Length > 1) if (x1[0] == '0') x1b = false;

        if (Convert.ToInt32(x2) >= 0 && Convert.ToInt32(x2) <= 255) x2b = true;
        else x2b = false;
        if (x2.Length > 1) if (x2[0] == '0') x2b = false;

        if (Convert.ToInt32(x3) >= 0 && Convert.ToInt32(x3) <= 255) x3b = true;
        else x3b = false;
        if (x3.Length > 1) if (x3[0] == '0') x3b = false;

        if (Convert.ToInt32(x4) >= 0 && Convert.ToInt32(x4) <= 255) x4b = true;
        else x4b = false;
        if (x4.Length > 1) if (x4[0] == '0') x4b = false;

        string answer;

        if (x1b && x2b && x3b && x4b == true) answer = "IPv4";
        else answer = "Neither";

        Console.WriteLine(answer);
    }

    static void IPv6(string str)
    {
        string x1 = "";
        string x2 = "";
        string x3 = "";
        string x4 = "";
        string x5 = "";
        string x6 = "";
        string x7 = "";
        string x8 = "";

        int k = 0;
        for (int i = 0; i < str.Length && k < 9; i++)
        {
            if (str[i] != ':')
            {
                if (k == 0) x1 += str[i];
                if (k == 1) x2 += str[i];
                if (k == 2) x3 += str[i];
                if (k == 3) x4 += str[i];
                if (k == 4) x5 += str[i];
                if (k == 5) x6 += str[i];
                if (k == 6) x7 += str[i];
                if (k == 7) x8 += str[i];
            }
            else k++;
        }

        bool x1b = true;
        bool x2b = true;
        bool x3b = true;
        bool x4b = true;
        bool x5b = true;
        bool x6b = true;
        bool x7b = true;
        bool x8b = true;

        if (x1.Count(s => (s > 'F' && s < 'a') || (s > 'f')) == 0 && x1.Length <= 4 && x1.Length >= 1) x1b = true;
        else x1b = false;

        if (x2.Count(s => (s > 'F' && s < 'a') || (s > 'f')) == 0 && x2.Length <= 4 && x2.Length >= 1) x2b = true;
        else x2b = false;

        if (x3.Count(s => (s > 'F' && s < 'a') || (s > 'f')) == 0 && x3.Length <= 4 && x3.Length >= 1) x3b = true;
        else x3b = false;

        if (x4.Count(s => (s > 'F' && s < 'a') || (s > 'f')) == 0 && x4.Length <= 4 && x4.Length >= 1) x4b = true;
        else x4b = false;

        if (x5.Count(s => (s > 'F' && s < 'a') || (s > 'f')) == 0 && x5.Length <= 4 && x5.Length >= 1) x5b = true;
        else x5b = false;

        if (x6.Count(s => (s > 'F' && s < 'a') || (s > 'f')) == 0 && x6.Length <= 4 && x6.Length >= 1) x6b = true;
        else x6b = false;

        if (x7.Count(s => (s > 'F' && s < 'a') || (s > 'f')) == 0 && x7.Length <= 4 && x7.Length >= 1) x7b = true;
        else x7b = false;

        if (x8.Count(s => (s > 'F' && s < 'a') || (s > 'f')) == 0 && x8.Length <= 4 && x8.Length >= 1) x8b = true;
        else x8b = false;

        string answer;

        if (x1b && x2b && x3b && x4b && x5b && x6b && x7b && x8b == true) answer = "IPv6";
        else answer = "Neither";

        Console.WriteLine(answer);
    }

    static void Main(string[] args)
    {
        string str = "2001:0db8:85a3:0000:00u0:8a2e:0370:7334";

        IPv4OrIPv6(str);
    }
}
