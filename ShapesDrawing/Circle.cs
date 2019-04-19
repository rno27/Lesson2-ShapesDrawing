using System;

namespace ShapesDrawing{

    public class Circle: IShape {

            private Point center;
            private float Radius;

            public Circle(Point p, float radius){
                
            }

            public void ReadCircleInfo(){
                
                Console.WriteLine();
                Console.WriteLine("Read central point coordintes:");
                Console.Write("X-coordinate: ");
                Console.Read();
                Console.WriteLine();
                Console.Write("Y-coordinate: ");
                Console.Read();
                Console.WriteLine();
                Console.Write("Radius = ");
                Console.Read();
                Console.WriteLine();

            }

            public void draw(){
                
            }

    }

}