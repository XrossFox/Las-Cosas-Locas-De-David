using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountEngine {
    public class FileNamespaces {
        private List<FileClasses> fileClasses;
        private string name;
        private int  size;

        public FileNamespaces(string name) {
            fileClasses = new List<FileClasses>();
            this.name = name;
            size = 1;

        }

        public int SizeOfNamespace {
            get {

                return size;
            }
        }

        public string Name {
            get {
                return name;
            }
        }

        public int NumberOfClasses {
            get {
                return fileClasses.Count;
            }
        }

        public void addClass(FileClasses newClass) {
            fileClasses.Add(newClass);
            size += newClass.ClassSize;
        }

        public override string ToString() {
            string stuff;
            stuff = "";
            for (int n = 0; n < fileClasses.Count; n++) {
                stuff += "--"+fileClasses[n].Name+": "+fileClasses[n].ClassSize+"\n";
            }
            return stuff;
        }

    }
}
