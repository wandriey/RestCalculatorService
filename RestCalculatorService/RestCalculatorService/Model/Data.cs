using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestCalculatorService.Model
{
    public class Data
    {
        private int _A;
        private int _B;

        public Data()
        {

        }
        public Data(int A, int B)
        {
            _A = A;
            _B = B;
        }
 
        public int getA
        {
            get { return _A; }
            set { _A = value; }
        }
        public int getB
        {
            get { return _B; }
            set { _B = value; }
        }
    }
}
