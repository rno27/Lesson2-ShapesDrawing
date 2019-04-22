using System;

namespace ShapesDrawing{

    public class Point{

        private int Xcoordinate;
        private int Ycoordinate;

        public Point(){
            
        }
        public Point (int X, int Y){
            Xcoordinate = X;
            Ycoordinate = Y;
         }
         
        public int GetXCoordinate(){
            return Xcoordinate;
        }

        public int GetYCoordinate(){
            return Ycoordinate;
        }

        public void SetXCoordinate(int newX){
            Xcoordinate = newX;
        }

        public void SetYCoordinate(int newY){
            Ycoordinate = newY;
        }
    }

}