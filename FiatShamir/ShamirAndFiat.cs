using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace FiatShamir
{
    class ShamirAndFiat
    {
        private byte p = 0, q = 0;
        private int n, s, v;

        #region Возвращаем значения
        public int GetP()
        {
            return p;
        }

        public int GetNKey()
        {
            return n;
        }

        public int GetVKey()
        {
            return v;
        }

        public int GetSKey()
        {
            return s;
        }

        #endregion

        public ShamirAndFiat()
        {
            Initialization();
        }
        #region Инициализируем компоненты
        /// <summary>
        /// Инициализация(метод не принимает параметров).
        /// </summary>
        private void Initialization()
        {
            Random random = new Random();

            byte[] simple = GetDivideableError();
            this.p = simple[random.Next(0, simple.Length)];
            this.q = simple[random.Next(0, simple.Length)];
            this.n = (ushort)(this.p * this.q);

            do
            {
                this.s = random.Next(1, n - 1);
            }
            while (this._G(n, s) != 1);

            this.v = Convert.ToInt32(Math.Pow(s, 2)) % n;
        }

        #endregion

        /// <summary>
        /// Генерируем новые 
        /// </summary>
        public void NewSGen()
        {
            Random random = new Random();

            do
            {
                s = random.Next(1, n - 1);
            }
            while (this._G(n, s) != 1);

            v = (int)(Math.Pow(s, 2)) % n;
        }

      
        public bool Check(int nK, int vK, int sK, ref int tmp1, ref int tmp2)
        {
            Random _rand = new Random();
            
            int r = _rand.Next(1, nK - 1);
            int x = Convert.ToInt32(Math.Pow(r, 2) % nK);

            int e = _rand.Next(1, 1000) % 2;

            int y = (r * Convert.ToInt32(Math.Pow(sK, e))) % nK;

            tmp2 = Convert.ToInt32(Math.Pow(y, 2) % this.n);
            tmp1 = ((x * Convert.ToInt32(Math.Pow(this.v, e))) % this.n);

            if ( tmp1 == tmp2)
                return true;
            else return false;
        }
        
        public int _G(int i, int j)
        {
            int a = i;
            int b = j;

            while (b != 0)
                b = a % (a = b);
            return a;
        }

        static private byte[] GetDivideableError()
        {
            List<byte> noDivideable = new List<byte>();

            for (int x = 2; x < 256; x++)
            {
                int n = 0;
                for (int y = 1; y <= x; y++)
                {
                    if (x % y == 0)
                        n++;
                }

                if (n <= 2)
                    noDivideable.Add((byte)x);
            }
            return noDivideable.ToArray();
        }
    }    
}
