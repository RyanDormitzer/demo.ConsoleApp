using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.shapes
{
   public class Tri
    {
        
            public Tri()
            {
                length = 0;
                this.width = 0;
            }

            public Tri(int length, int width)
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
                return this.width * this.length/2;
            }
        }
    
}
