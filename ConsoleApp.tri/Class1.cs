using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.tri
{
    public class tri

    {
        public tri()
        {
            length = 0;
            this.width = 0;
        }
        /// <summary>
        /// overload constuctor
        /// </summary>
        /// <param name="length"></param>
        /// <param name="width"></param>
        public tri(int length, int width)
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
            return (this.width * this.length)/2;
        }
    }
}
