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
    class Order
    {

        int OrderID;
        int CustomerID;
        int employeeID;
        String customerName;
        float amount;
        DateTime orderDate;

        /**
        *  constructor
        * @param orderID
        */
        public Order(int orderID)
        {
            
        }
        /**
        *  get Id of order
        * @return OrderID
        */
        public int getOrderID()
        {
            return OrderID;
        }
        /**
        *  set order ID
        * @param orderID
        */
        public void setOrderID(int orderID)
        {
            this.OrderID = orderID;
        }
        /**
       *  get name of Customer
       * @return CustomerName
       */
        public string getCustomerName()
        {
            return customerName;
        }
        /**
       *  get employee ID
       * @return employeeID
       */
        public int getEmployeeID()
        {
            return employeeID;
        }
        /**
         *  sets the employee
         * @param employeeID
         */
        public void setEmployee(int employeeID)
        {
            this.employeeID = employeeID;
        }
        /**
         *  get ID of customer
         * @return CustomerID
         */
        public void getCustomer()
        {
          //  return CustomerID;
        }
        /**
         *  deletes order
         * @param 
         */
        public void deleteOrder()
        {

        }
        /**
         *  sets the $ amount
         * @param amount 
         */
        public void setAmount(float amount)
        {
            this.amount = amount;
        }
         /**
         *  gets the $ amount
         * @return amount 
         */
        public float getAmount()
        {
            return amount;
        }
        /**
         *  gets the date
         * @return orderDate 
         */
        public DateTime getDate()
        {
            return orderDate;
        }
        /**
         *  sets the date
         * @param date 
         */
        public void setDate(DateTime orderDate)
        {
            this.orderDate = orderDate;
        }
    }
}

