using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_ShapesProject {
   public class Square2 {

        private Quad quad;

        public int Perimeter() {
            return (int) quad.Perimeter();
        }

        public int Area() {
            return (int)(quad.side1 * quad.side1);
        }
        public Square2 (int sides) {
            quad = new Quad(sides, sides, sides, sides);

        }

    }
}
