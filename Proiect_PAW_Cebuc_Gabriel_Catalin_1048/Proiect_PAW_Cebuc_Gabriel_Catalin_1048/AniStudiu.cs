using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW_Cebuc_Gabriel_Catalin_1048
{
     public abstract class AniStudiu
    {
        private string programStudiu;
        private int anStudiu;

        protected string ProgramStudiu { get => programStudiu; set => programStudiu = value; }
        protected int AnStudiu { get => anStudiu; set => anStudiu = value; }

        public AniStudiu()
        {
            ProgramStudiu = "Masterat";
            AnStudiu = 0;
        }
        public AniStudiu(string pS, int aS)
        {
            ProgramStudiu = pS;
            AnStudiu = aS;
        }
        public override string ToString()
        {
            return "Studentul este la programul de studiu " + ProgramStudiu + " in anul " + AnStudiu;
        }
    }
}
