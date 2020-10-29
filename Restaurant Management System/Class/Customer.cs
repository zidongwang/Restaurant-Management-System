
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management_System
{
    /**
     * @description: This class is about the customer information.
     */
    class Customer
    {
      
        int CustomerID;      
        String CustomerName;     
        String Address;     
        String Phone;   
        int MembershipType;


        /**
        *  get Id of Customer
        * @return CustomerID
        */
        public int getCustomerID()
        {
            return CustomerID;
        }
        /**
         *  set Id of Customer
         * @param CustomerID
         */
        public void setCustomerID(int CustomerID)
        {
            this.CustomerID = CustomerID;
        }
        /**
       *  get name of Customer
       * @return CustomerName
       */
        public string getCustomerName()
        {
            return CustomerName;
        }

        /**
         *  set name of Customer
         * @param CustomerName
         */
        public void setCustomerName(string CustomerName)
        {
            this.CustomerName = CustomerName;
        }
        /**
       *  get address of Customer
       * @return Address
       */
        public String getAddress()
        {
            return Address;
        }

        /**
         *  set address of Customer
         * @param address
         */
        public void setAddress(string address)
        {
            this.Address = address;
        }
        /**
       *  get phonenumber of Customer
       * @return phonenumber
       */
        public String getPhone()
        {
            return Phone;
        }

        /**
         *  set phonenumber of Customer
         * @param phonenumber
         */
        public void setPhonenumber(string phonenumber)
        {
            this.Phone = phonenumber;
        }


        /**
 *  get Membershiptype of Customer
 * @return MembershipType
 */
        public int getMembershiptype()
        {
            return MembershipType;
        }

        /**
         *  set Membershiptype of Customer
         * @param type
         */
        public void setMembershiptype(int type)
        {
            this.MembershipType = type;
        }

        /**  add new customer to the system
@param[in]  N/A
@return    N/A
*/
        void AddNewCustomer()
        {
        }
        /**  edit exist customer information
  @param[in]  CustomerID
  @return    N/A
  @warning NullError--if the CustomerID doesn’t exist
*/
        void EditCustomer(int CustomerID)
        {
            this.CustomerID = CustomerID;
        }
        /**  delete an exist customer information
  @param[in]  CustomerID
  @return    N/A
  @warning NullError--if the CustomerID doesn’t exist
*/
        void DeleteCustomer(int CustomerID)
        {
            this.CustomerID = CustomerID;
        }
    }
}
