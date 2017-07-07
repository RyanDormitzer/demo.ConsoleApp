using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.shapes
{
   public class Rec
    {
        public Rec()
        {
            length = 0;
            this.width = 0;
        }
        /// <param name="length"></param>
        /// <param name="width"></param>
        public Rec(int length, int width)
        {
            this.length = length;
            this.width = width;
        }
        // feilds or variables
        private int length;
        private int width;

        //methods
        public int Area()
        {
            return this.width * this.length;
        }
    }
}
