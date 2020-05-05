using System;
using System.Collections;

namespace Brain_Cs
{
   
    class MainApp
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht["company"] = "Microsoft";
            ht["URL"] = "www.microsoft.com";

            Console.WriteLine("회사 : {0}", ht["company"]);
            Console.WriteLine("URL : {0}", ht["URL"]);
        }
    }

}