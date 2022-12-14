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
            int numero = 0;

            TV tv1 = new TV();
            tv1.accendi();
            tv1.spegni();
            tv1.canale(numero);
            tv1.canalePiu();
            tv1.canaleMeno();
            tv1.aumentaVolume();
            tv1.diminuisciVolume();
            tv1.Rete();
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

            public void canalePiu()
            {
                canaleSelezionato += 1;
            }

            public void canaleMeno()
            {
                canaleSelezionato -= 1;
            }

            public void aumentaVolume() {
                volume += 1;
            }

            public void diminuisciVolume(){
                volume -= 1;
            }

            public void Rete(){ //accende la connessione WIFI
                if (statoRete == false)
                {
                    statoRete = true;
                }
                else
                    statoRete = false;
            }
        }
    }
}
