using System;
using System.Collections.Generic;

public static class PesoLettere
{

    public static int Pesa(string input)
    {
        int pesoLettere = 0;
        foreach (char lettera in input.ToLower()) 
        {
            switch (lettera)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                case 'l':
                case 'n':
                case 'r':
                case 's':
                case 't':
                    pesoLettere += 1;
                    break;
                case 'd':
                case 'g':
                    pesoLettere += 2;
                    break;
                case 'b':
                case 'c':
                case 'm':
                case 'p':
                    pesoLettere += 3;
                    break;
                case 'f':
                case 'h':
                case 'v':
                case 'w':
                case 'y':
                    pesoLettere += 4;
                    break;
                case 'k':
                    pesoLettere += 5;
                    break;
                case 'j':
                case 'x':
                    pesoLettere += 8;
                    break;
                case 'q':
                case 'z':
                    pesoLettere += 10;
                    break;
            }
        }
        return pesoLettere;
    }
}