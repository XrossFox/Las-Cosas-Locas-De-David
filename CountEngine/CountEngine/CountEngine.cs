using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CountEngine {
    public class CountEngine {


        private Result result;
        private int index;
        private List<string> fileLines;
        private FileNamespaces currentFileNamespace;
        private FileClasses currentFileClass;
        public CountEngine(List<string> fileLines) {
            result = new Result();
            index = 0;
            this.fileLines = fileLines;
        }

        /*
         * i = 0;
         * 
         * 1 leer linea en indice i
         * 2 si comienza con using:
         *      2.1 agregar una linea a usings
         * 3 si contiene la palabra reservada namespace:
         *      3.1 agregar nombre del namespace a la lista de namespaces
         * 4 incrementar i + 1, repetir paso 1
         * 5 si i == tamaño de la lista - 1
         *      5.1 sumar total de lineas del archivo.
         * 6 regresar un objeto resultado
         * 
         * Count engine lee las lineas, recibe una lista de lineas
         * EngineBlock manda analiza las linea actual y manda a llamar al metodo pertinente dependeiendo del tipo de linea
         * 
         *      
         */

        /// <summary>
        /// Receives a list of file lines to count. Returns a Result object.
        /// </summary>
        /// <param name="fileLines"></param>
        /// <returns></returns>
        public Result Ignition() {

            //Be sure to not receive an empty list
            if (fileLines.Count < 1) {
                return result;
            }
            else {
                while (index < fileLines.Count) {
                    if (EngineBlockManager(fileLines[index])) {
                        index++;
                        continue;
                    }
                    else {
                        MessageBox.Show(null, "Oh noes, something went Wrong!", "Error! D:");
                        break;
                    }
                }
            }

            return result;
        }

        /*
         * 
         */ 

        /// <summary>
        /// For when you reach an inner block (something inside namespace/class/metho/if block) while analysing the file.
        /// </summary>
        /// <param name="endCharacter"></param>
        private void secondaryIgnition(string endCharacter) {
            index++;
            while (!fileLines[index].Trim().EndsWith(endCharacter)) {
                if (EngineBlockManager(fileLines[index])) {
                    index++;
                    continue;
                }
                else {
                    MessageBox.Show(null, "Oh noes, something went Wrong!", "Error! D:");
                    break;
                }
            }
        }

        /// <summary>
        /// Analyzes shit and stuff sent by Ignition() to see what kind of line is the current one. Then calls the proper method.
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        private bool EngineBlockManager(string line) {

            //When you stumble with a using
            if (line.Trim().StartsWith("using")) {
                UsingBlock();
                return true;
            }
            //When you stumbke with a namespace block
            else
            if (line.Trim().StartsWith("namespace")) {
                NamespaceBlock(line);
                return true;
            }
            //When you stumble with an empty line
            else
            if (line.Trim().Equals(String.Empty)) {
                return true;
            }
            //When you stumble with a comment
            else
            if (line.Trim().StartsWith("//") || (line.Trim().StartsWith("*") && !line.Trim().EndsWith("/"))) {
                CommentLineBlock();
                return true;
            }
            else
            if (line.Trim().StartsWith("/*")) {
                CommentAreaBlock();
                return true;
            }
            else
            if (line.Trim().Contains(" class ") || line.Trim().Contains(" struct ") || line.Trim().Contains(" interface ")) {
                ClassBlock(line);
                return true;
            }
            else
            if (line.Trim().EndsWith(";")) {
                LineBlock();
                return true;
            }


            return false;
        }

        /// <summary>
        /// When EngineBlockManager() stumbles with a "using" line
        /// </summary>
        private void UsingBlock() {
            result.FileUsings = (result.FileUsings+1);
        }

        /// <summary>
        /// When EngineBlockManager() stumbles with a "namespace" block
        /// </summary>
        /// <param name="line"></param>
        private void NamespaceBlock(string line) {
            string[] intermediateArray;
            intermediateArray = line.Split(' ');
            currentFileNamespace = new FileNamespaces(intermediateArray[1]);

            secondaryIgnition("}");

            result.AddNamespace(currentFileNamespace);
            currentFileNamespace = null;
        }
        /// <summary>
        /// When EngineBlockManager() stumbles with a comment line that start with "//".
        /// </summary>
        private void CommentLineBlock() {
            result.CommentLines = (result.CommentLines + 1);
        }
        /// <summary>
        /// When EngineBlockManager stumbles with a comment block that starts wiht "/*" and ends with "/" (/*).
        /// </summary>
        private void CommentAreaBlock() {
            secondaryIgnition("/");

        }

        private void ClassBlock(string className) {
            string[] intermediate;
            intermediate = className.Split(' ');

            currentFileClass = new FileClasses(intermediate[intermediate.Length-2]);
            secondaryIgnition("}");

            if (currentFileNamespace == null) {
                result.AddLooseClass(currentFileClass);
            }
            else {
                currentFileNamespace.addClass(currentFileClass);
                currentFileClass = null;
            }
        }

        private void LineBlock() {
            currentFileClass.ClassSize = currentFileClass.ClassSize + 1;
        }




    }
}
