using System;
using System.Drawing;

namespace ShapesDrawing
{
    class Program
    {       
            static void Main(string[] args)
        {
            ConsoleMenuController menuController = new ConsoleMenuController();
            menuController.Initialize();
            menuController.EnterMainMenu();
            
        }
    }
}
