using System;
using System.Linq;
using System.Drawing;
using System.Collections.Generic;

namespace ShapesDrawing
{
    public class ConsoleMenuController
    {


        Menu mainMenu = new Menu();

        List<IShape> shapesList = new List<IShape>();

        public void RenderCanvas(){
            Console.Clear();
            foreach (IShape var in shapesList)
                var.Draw();
            Console.ReadLine();
        }

        public void HandleDrawSquare(){
            Console.Clear();
            Square square = new Square();
            square.ReadSquareInfo();
            shapesList.Add(square);
        }
           
        public void HandleDrawCircle(){
            Console.Clear();
            Circle circle = new Circle();
            circle.ReadCircleCoordinates();
            shapesList.Add(circle);
        }

        public void HandleDrawTriangle(){
            Console.Clear();
            Triangle triangle = new Triangle();
            Console.WriteLine("Not implemented !");
            Console.ReadLine();

        }

        public void Initialize()
        {   
            
            Menu newOrderMenu = new Menu();

            mainMenu.SetMenuItem(1, "Draw Square", () => HandleDrawSquare());
            mainMenu.SetMenuItem(2, "Draw Circle", () => HandleDrawCircle());
            mainMenu.SetMenuItem(3, "Draw Triangle", () => HandleDrawTriangle());
            mainMenu.SetMenuItem(4, "Render Canvas", () => RenderCanvas());
            

        }
        public void EnterMainMenu()
        {
            mainMenu.EnterMenu();            
        } 
        
    }
}