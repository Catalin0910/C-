using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW_Cebuc_Gabriel_Catalin_1048
{
    class Discipline : ICloneable, IComparable, IMediaCalculata
    {
        protected readonly int id;
        private string denumire;
        private string numeProfesor;
        private int priorityLevel;
        private int nrCredite;
        private int[] note;

        public Discipline()
        {
            this.id = 0;
            Denumire = "";
            NumeProfesor = "";
            PriorityLevel = 0;
            NrCredite = 0;
            Note = null;
        }
        public Discipline (int id, string d, string nP, int pL, int nC, int[] not)
        {
            this.id = id;
            Denumire = d;
            NumeProfesor = nP;
            PriorityLevel = pL;
            NrCredite = nC;
            Note = new int[not.Length];
            for (int i = 0; i < not.Length; i++)
            {
                Note[i] = not[i];
            }

        }
        public int Id => id;

        public string NumeProfesor { get => numeProfesor; set => numeProfesor = value; }
        public string Denumire { get => denumire; set => denumire = value; }
        public int PriorityLevel { get => priorityLevel; set => priorityLevel = value; }
        public int NrCredite { get => nrCredite; set => nrCredite = value; }
        public int[] Note { get => note; set => note = value; }

        public object Clone()
        {
            Discipline disciplina = new Discipline(this.id, denumire, numeProfesor, priorityLevel, nrCredite, note);
            int[] noteNoi = (int[])Note.Clone();
            disciplina.note = noteNoi;
            return disciplina;
        }

        public int CompareTo(object obj)
        {
            Discipline disciplina = (Discipline)obj;
            if(priorityLevel>disciplina.priorityLevel)
            {
                return 1;
            }
            else if(priorityLevel<disciplina.priorityLevel)
            {
                return -1;
            }
            else
            {
                return String.Compare(this.denumire, disciplina.denumire);
            }
        }
        public float CalculeazaMedia()
        {
            return (float)this;
        }

        public int this[int index]
        {
            get
            {
                if (note != null && index >= 0 && index < note.Length)
                {
                    return note[index];
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                if (value > 0 && index >= 0 && index < note.Length)
                {
                    note[index] = value;
                }
            }
        }

        public static Discipline operator +(Discipline s, int nota)
        {
            int[] noteNoi = new int[s.note.Length + 1];
            for (int i = 0; i < s.note.Length; i++)
            {
                noteNoi[i] = s.note[i];
            }
            noteNoi[noteNoi.Length - 1] = nota;
            s.note = noteNoi;
            return s;
        }

        public static Discipline operator ++ (Discipline d)
        {
            return d + 1;
        }


        public static explicit operator float(Discipline d)
        {
            if (d.note != null)
            {
                int suma = 0;
                for (int i = 0; i < d.note.Length; i++)
                {
                    suma += d.note[i];
                }
                return (float)suma / d.note.Length;
            }
            else
            {
                return 0;
            }
        }
    }
}
