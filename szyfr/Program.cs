using System;
using System.Collections.Generic;

public class Szyfrator
{
    public static string SzyfrujGaderyPoluki(string tekst)
    {
        Dictionary<char, char> szyfr = new Dictionary<char, char>()
        {
            { 'G', 'A' }, { 'A', 'G' },
            { 'D', 'E' }, { 'E', 'D' },
            { 'R', 'Y' }, { 'Y', 'R' },
            { 'P', 'O' }, { 'O', 'P' },
            { 'L', 'U' }, { 'U', 'L' },
            { 'K', 'I' }, { 'I', 'K' }
        };

        string wynik = "";

        foreach (char znak in tekst.ToUpper())
        {
            if (szyfr.ContainsKey(znak))
            {
                wynik += szyfr[znak];
            }
            else
            {
                wynik += znak;
            }
        }

        return wynik;
    }
}

class Program
{
    static void Main()
    {
        string tekst = "GRA POLI";
        string zaszyfrowany = Szyfrator.SzyfrujGaderyPoluki(tekst);
        Console.WriteLine(zaszyfrowany);
    }
}
