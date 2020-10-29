using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management_System
{
    /**
     * @description: This class is about the order information.
     */
    class OrderFoodInfo
    {

        int OrderID;
        int FoodID;
        string FoodName;
        String FoodType;
        int quantity;
        

        /**
        *  constructor
        * @param orderID
        */
        public OrderFoodInfo(int orderID)
        {

        }
        /**
        *  adds food item
        * @param foodID
        */
        public void setFood(int foodID)
        {
            this.FoodID = OrderID;
        }
        /**
       *  sets quantity for food
       * @param quantity
       */
        public void setQuantity(int quantity)
        {
            this.quantity = quantity;
        }
        /**
       *  sets food type
       * @param type
       */
        public void setFoodType(String type)
        {
            this.FoodType = type;
        }
        
        /**
         *  get ID of food
         * @return FoodID
         */
        public int getFood()
        {
            return FoodID;
        }
        /**
         *  gets food name
         * @return FoodName
         */
        public string getFoodName()
        {
            return FoodName;
        }
        /**
         *  gets the quantity
         * @return quantity
         */
        public int getQuantity()
        {
            return quantity;
        }
        /**
         *  makes customer requests for the food item
         * @param foodID 
         */
        public void modifyFood(int foodID)
        {
            
        }
    }
}


