using System;

namespace LogicalPrograms
{
    class Program
    {
        string pattern = "^[M-Z]{3}[a-z]{3,}$";
        static void Main(string[] args)
        {
            Regexpattern obj = new Regexpattern();
            obj.validating();
            obj.Replacingwhitesapce();
        }

    }
}
