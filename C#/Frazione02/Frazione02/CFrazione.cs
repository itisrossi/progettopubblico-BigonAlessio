using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Frazione02
{
    class CFrazione
    {
        private int  _Numeratore;
        private int  _Denominatore;

        public int Numeratore
        {
            get
            {
                return _Numeratore;
            }
            set
            {
                _Numeratore = value;
            }
        }

        public int Denominatore
        {
            get
            {
                return _Denominatore;
            }
            set
            {
                if (value != 0)
                    _Denominatore = value;
                else
                    _Denominatore = 1;
            }
        }

        public CFrazione()
        {
            Numeratore = 0;
            Denominatore = 0;
        }

        public CFrazione(int Numeratore, int Denominatore)
        {
            this.Numeratore = Numeratore;
            this.Denominatore = Denominatore;
        }
        public override string ToString()
        {
            string risultato = "";
            risultato = this.Numeratore.ToString() + "/" + this.Denominatore.ToString();
            return risultato;
        }

        public string ToString(bool json)
        {
            string ris = "";
            if (json)
                ris = JsonSerializer.Serialize(this);
            else
                ris = ris.ToString();

            return ris;
        }

        public CFrazione simple()
        {
            int mcd = 0;
            mcd = MCD(this.Numeratore, this.Denominatore);
            this.Numeratore /= mcd; 
            this.Denominatore /= mcd;
            return this;
        }
        private CFrazione MCD (int n1, int n2)
        {

        }

        public static CFrazione somma(CFrazione f1, CFrazione f2)
        {
            CFrazione risultato = new CFrazione();
            risultato.Denominatore = f1.Denominatore * f2.Denominatore;
            risultato.Numeratore = (risultato.Denominatore / f1.Denominatore * f1.Numeratore + risultato.Denominatore / f2.Denominatore * f2.Numeratore);
            return risultato;
        }
        public CFrazione somma(CFrazione f1)
        {
            CFrazione risultato = CFrazione.somma(this, f1);
            return risultato;
        }

        public static CFrazione operator +(CFrazione f1, CFrazione f2)
        {
            CFrazione risultato = CFrazione.somma(f1, f2);
            return risultato;
        }

        public CFrazione sottrazione(CFrazione f1)
        {
            CFrazione risultato = CFrazione.sottrazione(this, f1);
            return risultato;
        }

        public static CFrazione sottrazione(CFrazione f1, CFrazione f2)
        {
            CFrazione risultato = new CFrazione();
            risultato.Denominatore = f1.Denominatore * f2.Denominatore;
            risultato.Numeratore = (risultato.Denominatore / f1.Denominatore * f1.Numeratore - risultato.Denominatore / f2.Denominatore * f2.Numeratore);
            return risultato;
        }

        public static CFrazione operator -(CFrazione f1, CFrazione f2)
        {
            CFrazione risultato = CFrazione.somma(f1, f2);
            return risultato;
        }

        public static CFrazione molt(CFrazione f1, CFrazione f2)
        {
            CFrazione ris;
            ris = new CFrazione();
            ris.Denominatore = f1.Denominatore * f2.Denominatore;
            ris.Numeratore = f1.Numeratore * f2.Numeratore;
            return ris;
        }

        public CFrazione molt(CFrazione f1)
        {
            CFrazione ris = CFrazione.molt(this, f1);
            return ris;
        }

        public static CFrazione operator *(CFrazione f1, CFrazione f2)
        {
            CFrazione ris = CFrazione.molt(f1, f2);
            return ris;
        }

        public static CFrazione div(CFrazione f1, CFrazione f2)
        {
            CFrazione ris;
            ris = new CFrazione();
            ris.Denominatore = f1.Denominatore * f2.Numeratore;
            ris.Numeratore = f1.Numeratore * f2.Denominatore;
            return ris;
        }

        public CFrazione div(CFrazione f1)
        {
            CFrazione ris = CFrazione.div(this, f1);
            return ris;
        }

        public static CFrazione operator /(CFrazione f1, CFrazione f2)
        {
            CFrazione ris = CFrazione.div(f1, f2);
            return ris;
        }
    }

    
}
