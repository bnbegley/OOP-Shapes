using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_ShapesProject {
    class Rect: Quad {

        public Rect(int side_x, int side_y) 
            : base(side_x, side_y, side_x,side_y) {
            
        }
    }
}
