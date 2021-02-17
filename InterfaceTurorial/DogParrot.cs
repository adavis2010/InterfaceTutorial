using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceTurorial {
    class DogParrot : IBarkable {
        public string Name { get; set; }

        public string Bark() {
            return "barcaw";

        }

        public string GetName() {
            return Name;
        }


        public void SetName(string name) {
            this.Name = name;
        }

    }
} 


