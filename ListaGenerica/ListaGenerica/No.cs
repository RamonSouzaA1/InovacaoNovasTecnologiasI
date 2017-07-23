using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1
{
    class No<T>
    {
        private T no;
        private No<T> proxNo;

        public T Set
        {
            get { return no; }
            set { no = value; }
        }

        public No<T> SetProx
        {
            get { return proxNo; }
            set { proxNo = value; }
        }
    }
}
