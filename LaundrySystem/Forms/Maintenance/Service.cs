using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundrySystem.Forms.Maintenance {
    public class Service {
        private string iD;
        private string name;
        private double price;
        private string category;
        private CategoryUnit unit;

        public string ID {
            get {
                return iD;
            }

            set {
                iD = value;
            }
        }

        public string Name {
            get {
                return name;
            }

            set {
                name = value;
            }
        }

        public double Price {
            get {
                return price;
            }

            set {
                price = value;
            }
        }

        public string Category {
            get {
                return category;
            }

            set {
                category = value;
            }
        }

        public CategoryUnit Unit {
            get {
                return unit;
            }

            set {
                unit = value;
            }
        }

        public Service(string iD, string name, double price, string category, CategoryUnit unit) {
            this.iD = iD;
            this.name = name;
            this.price = price;
            this.category = category;
            this.unit = unit;
        }
        public Service() {

        }

        public enum CategoryUnit {
            kg,pcs
        }
    }
}
