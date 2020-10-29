using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management_System
{
    /**
 * @description: saving the information of employees who work in restaurants.
 */
    class Employee
    {
        String employeeId;
        String firstName;
        String lastName;
        String position;
        Address address;

        /**
         *  get Id for employee
         * @return
         */
        public String getEmployeeId()
        {
            return employeeId;
        }

        /**
         *  set Id for employee
         * @param employeeId
         */
        public void setEmployeeId(String employeeId)
        {
            this.employeeId = employeeId;
        }

        /**
         *  get the first name for employee
         * @return
         */
        public String getFirstName()
        {
            return firstName;
        }

        /**
         *  set the first name for employee
         * @param firstName
         */
        public void setFirstName(String firstName)
        {
            this.firstName = firstName;
        }

        /**
         *  get the last name for employee
         * @return
         */
        public String getLastName()
        {
            return lastName;
        }

        /**
         *  set the last name for employee
         * @param lastName
         */
        public void setLastName(String lastName)
        {
            this.lastName = lastName;
        }

        /**
         *  get employee’s position
         * @return
         */
        public String getPosition()
        {
            return position;
        }

        /**

         *  set employee’s position
         * @param position
         */
        public void setPosition(String position)
        {
            this.position = position;
        }

        /**
         *  get employee’s address
         * @return
         */
        public Address getAddress()
        {
            return address;
        }

        /**
         *  set employee’s address
         * @param address
         */
        public void setAddress(Address address)
        {
            this.address = address;
        }
    }
}
