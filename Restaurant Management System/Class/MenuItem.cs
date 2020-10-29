using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management_System



{

    /*
author: Sarah Noshin
date: 10/2/20
*/



    class MenuItem
    {
      
        int MenuItemID;      //Id of menu item
        String MenuItemName;     //Name of the menu item
        String MenuItemDescription;   //Describes the type of menu item
        decimal MenuItemPrice;   //Price of menu item

        


        /**
        *  get Id of MenuItem
        * @return MenuItemID
        */
        public int getMenuItemID()
        {
            return MenuItemID;
        }
        /**
         *  set Id of MenuItem
         * @param MenuItemID
         */
        public void setMenuItemID(int MenuItemID)
        {
            this.MenuItemID = MenuItemID;
        }


        /**
       *  get name of MenuItem
       * @return MenuNameItem
       */
        public string getMenuItemName()
        {
            return MenuItemName;
        }

        /**
         *  set name of MenuItem
         * @param  MenuNameItem
         */
        public void setMenuItemName(string MenuItemName)
        {
            this.MenuItemName = MenuItemName;
        }


        /**
       *  get description of Menu Item
       * @return MenuItemDescription
       */
        public String getMenuItemDescription()
        {
            return MenuItemDescription;
        }

        /**
         *  set description of Menu
         * @param MenuDescription
         */
        public void setMenuItemDescription(string MenuItemDescription)
        {
            this.MenuItemDescription = MenuItemDescription;
        }


        /**
       *  get price of MenuItem
       * @return MenuItemPrice
       */
        public decimal getMenuItemPrice()
        {
            return MenuItemPrice;
        }

        /**
         *  set price of MenuItem
         * @param MenuItemPrice
         */
        public void setMenuItemPrice(decimal MenuItemPrice)
        {
            this.MenuItemPrice = MenuItemPrice;
        }


   

        /**  add new menu  item to the system
@param[in]  N/A
@return    N/A
*/
        void AddNewMenuItem()
        {
        }
        /**  edit exist menu item information
  @param[in]  MenuItemID
  @return    N/A
  @warning NullError--if the MenuItemID doesn’t exist
*/
        void EditMenuItem(int MenuItemID)
        {
            this.MenuItemID = MenuItemID;
        }
        /**  delete an exist menu item 
  @param[in]  MenuID
  @return    N/A
  @warning NullError--if the MenuItemID doesn’t exist
*/
        void DeleteMenuItem(int MenuItemID)
        {
            this.MenuItemID = MenuItemID;
        }
    }
}
