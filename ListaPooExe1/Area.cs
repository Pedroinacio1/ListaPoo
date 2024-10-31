using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPooExe1
{
    internal class Area
    {
        private int altura;
        private int Base;
        private int area;

        public void setaltura(int altura)
        {
            this.altura = altura;
        }
        public void setBase(int Base)
        {
            this.Base = Base;
        }
        public int getaltura()
        {
            return this.altura;
        }
        public int getBase()
        {
            return Base;
        }
        public int getArea()
        {
            return area;
        }
        public void AreaRet()
        {
            this.area = this.altura * this.Base;
        }

    }
}
