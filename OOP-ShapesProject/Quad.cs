﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_ShapesProject {
   public class Quad {

       public double side1;
       public double side2;
       public double side3;
       public double side4;


        public double Perimeter() {
            return side1 + side2 + side3 + side4;
        }

        public Quad (int side_a, int side_b, int side_c, int side_d) {
            this.side1 = side_a;
            this.side2 = side_b;
            this.side3 = side_c;
            this.side4 = side_d;
        }


        

    }
}
