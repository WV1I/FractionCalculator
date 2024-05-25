using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkulatorUlamki
{
    class Kalkulator
    {
        Label view { get; set; }
        private int NWD { get; set; }
        public Kalkulator(Label view)
        {
            this.view = view;
        }
        public void Calculate(Ulamek u1, Ulamek u2, int curtask)
        {
            switch(curtask)
            {
                case 1:
                    Add(u1, u2);
                    break;
                case 2:
                    Substract(u1, u2);
                    break;
                case 3:
                    Multiply(u1, u2);
                    break;
                case 4:
                    Divide(u1, u2);
                    break;
            }
                
        }
        void Euklides(int l1,int l2)
        {
            while (l1 != l2)
            {
                if (l1 > l2)
                    l1 -= l2;
                else
                    l2 -= l1;
            }
            NWD = l1;
        }
        void Add(Ulamek u1, Ulamek u2)
        {
            Ulamek wynik = u1 + u2;
            Euklides(wynik.licznik, wynik.mianownik);
            if (NWD != 1)
            {
                wynik.licznik /= NWD;
                wynik.mianownik /= NWD;
            }
            view.Text = wynik.ToString();
        }
        void Substract(Ulamek u1, Ulamek u2)
        {

            Ulamek wynik = u1 - u2;
            Euklides(wynik.licznik, wynik.mianownik);
            if (NWD != 1)
            {
                wynik.licznik /= NWD;
                wynik.mianownik /= NWD;
            }
            view.Text = wynik.ToString();
        }
        void Multiply(Ulamek u1, Ulamek u2)
        {

            view.Text = (u1 * u2).ToString();
        }
        void Divide(Ulamek u1, Ulamek u2)
        {

            view.Text = (u1 / u2).ToString();
        }
    }
}
