using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace task3._16
{
    class Sign
    {
        private char ch;
        private int count = 0;

       

        public char getChar()
        {
            return ch;
        }
        public int getCount()
        {
            return count;
        }
        public void addCount(int count)
        {
            this.count += count;
        }
        public void setSign(char ch)
        {
            this.ch = ch;
        }
    }
}
