using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundrySystem.Forms.Maintenance {
    public class Staff {
        private string iD;
        private string firstName;
        private string lastName;
        private string middleName;
        private string contactNo;
        private string email;
        private string streetNo;
        private string streetName;
        private string barangay;
        private string username;
        private string password;
        private StaffMode mode;
        private StaffStatus status;

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

        public string Email {
            get {
                return email;
            }

            set {
                email = value;
            }
        }

        public string Username {
            get {
                return username;
            }

            set {
                username = value;
            }
        }

        public string Password {
            get {
                return password;
            }

            set {
                password = value;
            }
        }

        public StaffMode Mode {
            get {
                return mode;
            }

            set {
                mode = value;
            }
        }

        internal StaffStatus Status {
            get {
                return status;
            }

            set {
                status = value;
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

        public Staff() {
        }

        public Staff(string iD, string firstName, string middleName, string lastName,  string contactNo, string email, string streetNo, string streetName, string barangay, string username, string password, StaffMode mode, StaffStatus status) {
            this.iD = iD;
            this.firstName = firstName;
            this.lastName = lastName;
            this.middleName = middleName;
            this.contactNo = contactNo;
            this.email = email;
            this.streetNo = streetNo;
            this.streetName = streetName;
            this.barangay = barangay;
            this.username = username;
            this.password = password;
            this.mode = mode;
            this.status = status;
        }

        public enum StaffMode {
            Encoder,
            Admin
        }
        public enum StaffStatus {
            Inactive,
            Active
        }
    }
}
