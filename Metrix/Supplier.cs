using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metrix
{
    class Supplier
    {
        private int supId;
        private string companyName;
        private string country;
        private string contact;
        private string refName;
        private string email;

        public int supIdValue
        {

            get 
            {
                return this.supId;
            }
            set 
            {
                supId = value;
            }
        }

        public string companyNameValue
        {

            get 
            {
                return this.companyName;
            }
            set 
            {
                companyName = value;
            }
        
        }

        public string countryValue
        {

            get 
            {
                return this.country;
            }
            set
            {
                country = value;
            }
        
        }

        public string contactValue
        {

            get
            {
                return this.contact;
            }
            set
            {
                contact = value;
            }

        }

        public string refNameValue
        {

            get
            {
                return this.refName;
            }
            set
            {
                refName = value;
            }

        }

        public string emailValue
        {

            get
            {
                return this.email;
            }
            set
            {
                email = value;
            }

        }

        public virtual void SupplierSave() { }

        public virtual void SupplierUpdate() { }

        public virtual void SupplierDelete() { }

    }
}
