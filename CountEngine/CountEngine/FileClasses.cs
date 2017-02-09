using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountEngine {
    public class FileClasses {
        private string name;
        private int classSize;


        public FileClasses(string name) {
            this.name = name;
            classSize = 1;

        }

        public string Name {
            get {
                return name;
            }
        }

        public int ClassSize {
            get {
                return classSize;
            }
            set {
                classSize = value;
            }
        }

    }
}
