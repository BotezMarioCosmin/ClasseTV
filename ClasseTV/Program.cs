using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseTV
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        class TV
        {
            bool stato; //accesa o spenta

            float potenza; //watt

            int luminosita;

            int volume;

            string produttore; //casa produttrice

            string modello;

            int quantitaPixelAltezza; //es 1080p

            int quantitaPixelLunghezza; //es 1920p

            int pollici; //es 55

            string tipologiaPannello; //es led, oled...

            int canaleSelezionato; //42

            bool ethernet; //presenza di porta ethernet

            bool WIFI; //presenza di scheda di rete wireless

            bool statoRete; //connesso o non connesso

            int quantitaPorteHDMI; //es 4

            public void accendi(){
                stato = true;
            }

            public void spegni() {
                stato = false;
            }

            public void canale(int numero) {
                canaleSelezionato = numero;
            }

            public void aumentaVolume() {
                volume += 1;
            }

            public void diminuisciVolume(){
                volume -= 1;
            }
        }
    }
}
