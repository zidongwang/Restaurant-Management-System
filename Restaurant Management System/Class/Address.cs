using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management_System
{

    /**
     * @description: storing the address information for customers and employees
     */
    class Address
    {
        String addressId;
        String stressName;
        String city;
        String state;
        String zipCode;

        /**
         * get Id for address
         * @return address Id
         */
        public String getAddressId()
        {
            return addressId;
        }

        /**
         * set Id for address
         * @param addressId   Address id
         */
        public void setAddressId(String addressId)
        {
            this.addressId = addressId;
        }

        /**
         *  get stress Name for address
         * @return
         */
        public String getStressName()
        {
            return stressName;
        }

        /**
         *  set stress Name for address
         * @param stressName
         */
        public void setStressName(String stressName)
        {
            this.stressName = stressName;
        }

        /**
         * get City Name for address
         * @return
         */
        public String getCity()
        {
            return city;
        }

        /**
         *  set city Name for address
         * @param city
         */
        public void setCity(String city)
        {
            this.city = city;
        }

        /**
         *  get state Name for address
         * @return
         */
        public String getState()
        {
            return state;
        }

        /**
         *  set state Name for address
         * @param state
         */
        public void setState(String state)
        {
            this.state = state;
        }

        /**
         *  get zipcode for address
         * @return
         */
        public String getZipCode()
        {
            return zipCode;
        }

        /**
         *  set zipcode for address
         * @param zipCode
         */
        public void setZipCode(String zipCode)
        {
            this.zipCode = zipCode;
        }
    }
}
