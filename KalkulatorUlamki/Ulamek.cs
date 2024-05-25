using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorUlamki
{
    public class Ulamek
    {
        public int licznik { get; set; }
        public int mianownik {get; set;}
        
        public Ulamek(int licznik, int mianownik)
        {
            if (mianownik == 0)
            {
                throw new ArgumentException("Mianownik nie może być równy 0", nameof(mianownik));
            }
            this.licznik = licznik;
            this.mianownik = mianownik;
            
        }
        public static Ulamek operator -(Ulamek U)
        {
            Ulamek uResult = new Ulamek(-U.licznik, U.mianownik);
            return uResult;

        }
        public static Ulamek operator +(Ulamek U)
        {
            
            return U;

        }


        public static Ulamek operator +(Ulamek Ulamek1,Ulamek Ulamek2)
        {
            Ulamek uResult = new Ulamek(Ulamek1.licznik * Ulamek2.mianownik + Ulamek2.licznik * Ulamek1.mianownik, Ulamek1.mianownik * Ulamek2.mianownik);
            return uResult;
        }
        public static Ulamek operator -(Ulamek Ulamek1, Ulamek Ulamek2)
        {
            Ulamek uResult = Ulamek1 + (-Ulamek2);
            return uResult;

        }
        public static Ulamek operator *(Ulamek Ulamek1, Ulamek Ulamek2)
        {
            Ulamek uResult = new Ulamek(Ulamek1.licznik * Ulamek2.licznik, Ulamek1.mianownik * Ulamek2.mianownik);
            return uResult;

        }
        public static Ulamek operator /(Ulamek Ulamek1, Ulamek Ulamek2)
        {
            if (Ulamek2.licznik == 0)
            {
                throw new DivideByZeroException();
            }
            Ulamek uResult = new Ulamek(Ulamek1.licznik * Ulamek2.mianownik, Ulamek1.mianownik * Ulamek2.licznik);
            return uResult;

        }
        public override string ToString() => $"{licznik} / {mianownik}";
    }
}
