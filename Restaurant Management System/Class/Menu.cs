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



    class Menu
    {
      
        int MenuID;      //Id of menu
        String MenuName;     //Name of the menu
        String MenuDescription;   //Describes the type of menu  
        String MenuDate;   //Period of time that certain a menu will be used

        


        /**
        *  get Id of Menu
        * @return MenuID
        */
        public int getMenuID()
        {
            return MenuID;
        }
        /**
         *  set Id of Menu
         * @param MenuID
         */
        public void setMenuID(int MenuID)
        {
            this.MenuID = MenuID;
        }


        /**
       *  get name of Menu
       * @return MenuName
       */
        public string getMenuName()
        {
            return MenuName;
        }

        /**
         *  set name of Menu
         * @param  MenuName
         */
        public void setMenuName(string MenuName)
        {
            this.MenuName = MenuName;
        }


        /**
       *  get description of Menu
       * @return MenuDescription
       */
        public String getMenuDescription()
        {
            return MenuDescription;
        }

        /**
         *  set description of Menu
         * @param MenuDescription
         */
        public void setMenuDescription(string MenuDescription)
        {
            this.MenuDescription = MenuDescription;
        }


        /**
       *  get date of Menu
       * @return MenuDate
       */
        public String getMenuDate()
        {
            return MenuDate;
        }

        /**
         *  set date of Menu
         * @param MenuDate
         */
        public void setMenuDate(string MenuDate)
        {
            this.MenuDate = MenuDate;
        }


   

        /**  add new menu to the system
@param[in]  N/A
@return    N/A
*/
        void AddNewMenu()
        {
        }
        /**  edit existing menu information
  @param[in]  MenuID
  @return    N/A
  @warning NullError--if the MenuID doesn’t exist
*/
        void EditMenu(int MenuID)
        {
            this.MenuID = MenuID;
        }
        /**  delete an existing menu information
  @param[in]  MenuID
  @return    N/A
  @warning NullError--if the MenuID doesn’t exist
*/
        void DeleteMenu(int MenuID)
        {
            this.MenuID = MenuID;
        }
    }
}
