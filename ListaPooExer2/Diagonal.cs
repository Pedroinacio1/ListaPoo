using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPooExer2
{
    internal class Diagonal
    {
        private int diago;
        private int resul;
        public void setdiago(int diago)
        {
            this.diago = diago;
        }
        public int getdiago()
        {
            return this.diago;
        }
        public int getresul()
        {
            return this.resul;
        }
        public void areadiago()
        {
            this.resul = (this.diago * this.diago) / 2;
        }
    }
}
