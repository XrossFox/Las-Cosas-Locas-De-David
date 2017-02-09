using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountEngine {
    public class Result {
        private int fileUsings;
        private List<FileNamespaces> fileNamespaces;
        private List<List<string>> namespaceClasses;
        private List<List<int>> classLines;
        private int fileTotalLines;
        private int commentLines;
        private List<FileClasses> looseClasses;

        public Result() {
            fileNamespaces = new List<FileNamespaces>();
            namespaceClasses = new List<List<string>>();
            classLines = new List<List<int>>();
            looseClasses = new List<FileClasses>();
            fileUsings = 0;
            fileTotalLines = 0;
            commentLines = 0;
        }

        public int CommentLines {
            get {
                return commentLines;
            }
            set {
                commentLines = value;
            }
        }

        public int FileUsings {
            get {
                return fileUsings;
            }
            set {
                fileUsings = value;
            }

        }

        public List<FileNamespaces> FileNamespaces {
            get {
                return fileNamespaces;
            }
        }

        public void AddNamespace(FileNamespaces namespaceName) {
            fileNamespaces.Add(namespaceName);
        }

        public void AddLooseClass(FileClasses classy) {
            looseClasses.Add(classy);
        }

        public int FileTotalLines {
            get {
                return fileTotalLines;
            }
            set {
                fileTotalLines = value;
            }

        }


        public override string ToString() {
            string thingies;
            thingies = "";
            thingies += ("usings: "+fileUsings+"\n");
            for (int n = 0; n < fileNamespaces.Count; n++) {
                thingies += "Namespace: "+fileNamespaces[n].Name+" = "+fileNamespaces[n].SizeOfNamespace+"\n";
                thingies += (fileNamespaces[n].ToString());
                FileTotalLines += fileNamespaces[n].SizeOfNamespace;
            }

            if (looseClasses.Count > 0) {
                thingies += "\n:::Loose Classes:::\n";
                for (int n = 0; n < looseClasses.Count; n++) {
                    thingies += looseClasses[n].Name + " = " + looseClasses[n].ClassSize + "\n";
                    FileTotalLines += looseClasses[n].ClassSize;

                }
            }

            FileTotalLines += fileUsings;
            thingies += "\nComment Lines: "+commentLines+"\n"; 
            thingies += "Total Lines:" + FileTotalLines;

            return thingies;
        }

    }
}
