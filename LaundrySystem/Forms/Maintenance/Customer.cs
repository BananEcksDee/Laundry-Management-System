using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundrySystem {
    public class Customer {
        private string iD;
        private string firstName;
        private string lastName;
        private string middleName;
        private string streetNo;
        private string streetName;
        private string barangay;
        private string contactNo;
        private membershipStatus membership;
        public Customer() {

        }
        public Customer(string iD, string firstName, string middleName, string lastName, string contactNo, string streetNo, string streetName, string barangay,  membershipStatus membership) {
            this.iD = iD;
            this.firstName = firstName;
            this.lastName = lastName;
            this.middleName = middleName;
            this.streetNo = streetNo;
            this.streetName = streetName;
            this.barangay = barangay;
            this.contactNo = contactNo;
            this.membership = membership;
        }

        public string ID {
            get {
                return iD;
            }

            set {
                iD = value;
            }
        }

        public string FirstName {
            get {
                return firstName;
            }

            set {
                firstName = value;
            }
        }

        public string LastName {
            get {
                return lastName;
            }

            set {
                lastName = value;
            }
        }

        public string MiddleName {
            get {
                return middleName;
            }

            set {
                middleName = value;
            }
        }


        public string ContactNo {
            get {
                return contactNo;
            }

            set {
                contactNo = value;
            }
        }

        internal membershipStatus Membership {
            get {
                return membership;
            }

            set {
                membership = value;
            }
        }

        public string StreetNo {
            get {
                return streetNo;
            }

            set {
                streetNo = value;
            }
        }

        public string StreetName {
            get {
                return streetName;
            }

            set {
                streetName = value;
            }
        }

        public string Barangay {
            get {
                return barangay;
            }

            set {
                barangay = value;
            }
        }

        public enum membershipStatus {
            No,Yes
        }
    }
}
