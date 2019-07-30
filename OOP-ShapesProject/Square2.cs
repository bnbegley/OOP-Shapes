using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_ShapesProject {
   public class Square2 {

        private Rect rect;

        public int Perimeter() {
            return rect.Perimeter();
        }

        public int Area() {
            return rect.Area();
        }
        public Square2 (int sides) {
            rect = new Rect(sides, sides);

        }

    }
}
