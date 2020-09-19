using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekti
{
    class Päävalikko
    {
        // Kyllä osaa vituttaa
        public void Aloitusvalikko()
        {
            // Päävalikon käynnistyksen ehto
            bool start = true;

            // Loputon luuppi päävalikosta
            while (start)
            {
                // Tyhjentää konsolin
                Console.Clear();

                // Konsolissa näkyvä valikko
                Console.WriteLine("Valitse toiminto \n1. Laske uusi palkka \n2. Muuta työntekijöiden tietoja \n3. Katso työntekijöiden tietoja \n4. Lisää uusi työntekijä \n5. Työntekijöiden aijemmat palkat \n6. Lopeta ohjelma");
                // Annetaan muuttujaan valittu vaihtoehto
                string valinta = Console.ReadLine();

                // ´Tarkastetaan minkä vaihtoehdon käyttäjä syötti
                switch (valinta)
                {
                    // Käynnistää vaihtoehdon 1.
                    case "1":
                        break;

                    // Käynnistää vaihtoehdon 2.
                    case "2":
                        break;

                    // Käynnistää vaihtoehdon 3.
                    case "3":
                        break;

                    // Käynnistää vaihtoehdon 4.
                    case "4":
                        break;

                    // Käynnistää vaihtoehdon 5.
                    case "5":
                        break;

                    // Sammuttaa ohjelman
                    case "6":
                        start = false;
                        break;

                    // Ilmoittaa käyttäjälle ettei kyseistä toimintaa ole ja käynnistää päävalikon alusta
                    default:
                        Console.WriteLine("\nTällaista vaihtoehtoa ei ole! \n\nJatka painamalla ENTER...");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
