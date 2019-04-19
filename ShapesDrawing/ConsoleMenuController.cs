using System;
using System.Linq;

namespace ShapesDrawing
{
    public class ConsoleMenuController
    {

        Menu mainMenu = new Menu();


        void HandleDrawCircle(){
            Circle circle = new Circle();
            circle.ReadCircleInfo();
            circle.ReadCircleInfo();
        }

        public ConsoleMenuController()
        {
           
        }    
    
        public void HandleDrawRectangle(){}
        public void HandleDrawTriangle(){}
       
        public void Initialize()
        {   

            Menu newCustomerMenu = new Menu();
            Menu newSellerMenu = new Menu();
            Menu newOrderMenu = new Menu();

            mainMenu.SetMenuItem(1, "Seller accout", newCustomerMenu, () => HandleDrawCircle());
            mainMenu.SetMenuItem(2, "Customer accout",newSellerMenu, () => HandleDrawRectangle());
            mainMenu.SetMenuItem(3, "Customer accout",newSellerMenu, () => HandleDrawTriangle());

            /* 
            newCustomerMenu.OnPreRender = new Action( ()=> DisplayCustomerName());
            newCustomerMenu.SetMenuItem(1, "New Order", newOrderMenu, () => orderController.StartNewOrder(LoggedInCustomer));  
            newCustomerMenu.SetMenuItem(2, "Back", mainMenu);  
            */

           
        }
        public void EnterMainMenu()
        {
            mainMenu.EnterMenu();            
        } 
        
    }
}