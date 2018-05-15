using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbejde_med_strenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string forNavn = "Mikkel";
            string efterNavn = "Cronberg";

            StringBuilder samletNavn = new StringBuilder(forNavn + " " + efterNavn);
            string navnStort = (samletNavn.ToString()).ToUpper();
            
            Console.WriteLine(navnStort);

            string navnLille = (samletNavn.ToString()).ToLower();
            Console.WriteLine(navnLille);

            string del = (samletNavn.ToString()).Substring(7,4);
            Console.WriteLine(del);

            string[] ar1 = (samletNavn.ToString()).Split(' ');

            for (int i = 0; i < ar1.Length; i++)
            {
                Console.WriteLine(ar1[i]);
            }

            System.IO.File.WriteAllText(forNavn,forNavn);
        }
    }
}
