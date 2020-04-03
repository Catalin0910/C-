using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW_Cebuc_Gabriel_Catalin_1048
{
     public class Adeverinta: ICloneable
    {
        private string tipAdeverinta;
        private string altaAdeverinta;
        private string alteNecesitati;
        private string necesitate;

        public Adeverinta()
        {
            TipAdeverinta = "";
            AltaAdeverinta = "";
            AlteNecesitati = "";
            Necesitate = "";
        }
        public Adeverinta(string tA, string aA, string aN, string ne)
        {
            TipAdeverinta = tA;
            AltaAdeverinta = aA;
            AlteNecesitati = aN;
            Necesitate = ne;
        }

        public string TipAdeverinta { get => tipAdeverinta; set => tipAdeverinta = value; }
        public string AltaAdeverinta { get => altaAdeverinta; set => altaAdeverinta = value; }
        public string AlteNecesitati { get => alteNecesitati; set => alteNecesitati = value; }
        public string Necesitate { get => necesitate; set => necesitate = value; }

        public object Clone()
        {
            Adeverinta a = (Adeverinta)this.MemberwiseClone();
            return a;
        }
        public override string ToString()
        {
            return "Adeverință Solicitată: " + tipAdeverinta+ Environment.NewLine+ "Alte necesități: " + alteNecesitati +Environment.NewLine+ "Altă adeverință solicitată: " + AltaAdeverinta + Environment.NewLine+"Necesitate:"+necesitate ;
            
        }
        
    }
}
