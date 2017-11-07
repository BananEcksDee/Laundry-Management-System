using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundrySystem.Forms.Transaction {
    public class Transaction {
        private string transactionID;
        private string customerID;
        private string dateOrdered;
        private string datePickup;
        private string status;
        public Transaction(){

        }
        public Transaction(string transactionID, string customerID, string dateOrdered, string datePickup, string status) {
            this.transactionID = transactionID;
            this.customerID = customerID;
            this.dateOrdered = dateOrdered;
            this.datePickup = datePickup;
            this.status = status;
        }

        public string TransactionID {
            get {
                return transactionID;
            }

            set {
                transactionID = value;
            }
        }

        public string CustomerID {
            get {
                return customerID;
            }

            set {
                customerID = value;
            }
        }

        public string DateOrdered {
            get {
                return dateOrdered;
            }

            set {
                dateOrdered = value;
            }
        }

        public string DatePickup {
            get {
                return datePickup;
            }

            set {
                datePickup = value;
            }
        }

        public string Status {
            get {
                return status;
            }

            set {
                status = value;
            }
        }
    }
}
