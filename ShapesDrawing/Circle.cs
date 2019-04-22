using System;
using System.Drawing;
using System.Windows;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;


namespace ShapesDrawing{

    public class Circle: IShape {

            private Point center;
            private int radius;

            public Circle(){
                center = new Point();
            }
            public Circle(Point centerPoint, int radius){
                center.SetXCoordinate(centerPoint.GetXCoordinate());
                center.SetYCoordinate(centerPoint.GetYCoordinate());
                this.radius = radius;
            }

            public void ReadCircleCoordinates(){
                
                Console.WriteLine("Center point:");
                Console.Write("Xcoordinate:");
                string var = Console.ReadLine();
                int result = Int32.Parse(var);
                center.SetXCoordinate(result);
                Console.Write("Ycoordinate:");
                var =  Console.ReadLine();
                result = Int32.Parse(var);
                center.SetYCoordinate(result);
                Console.Write("Radius:");
                var =  Console.ReadLine();
                result = Int32.Parse(var);
                radius = result;
               
            }

            public void Draw(){
                Console.WriteLine("Circle added ! -> central point = ({0},{1}), radius={2}",center.GetXCoordinate(),center.GetYCoordinate(),radius);
            }

    }

}