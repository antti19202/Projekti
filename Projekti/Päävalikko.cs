using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekti
{
    class Päävalikko
    {
        public void Aloitusvalikko()
        {
            bool start = true;

            while (start)
            {
                Console.Clear();

                Console.WriteLine("Valitse toiminto \n1. Laske uusi palkka \n2. Muuta työntekijöiden tietoja \n3. Katso työntekijöiden tietoja \n4. Lisää uusi työntekijä \n5. Työntekijöiden aijemmat palkat \n6. Lopeta ohjelma");
                string valinta = Console.ReadLine();

                switch (valinta)
                {
                    case "1":
                        break;

                    case "2":
                        break;

                    case "3":
                        break;

                    case "4":
                        break;

                    case "5":
                        break;

                    case "6":
                        start = false;
                        break;

                    default:
                        Console.WriteLine("\nTällaista vaihtoehtoa ei ole! \n\nJatka painamalla ENTER...");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
