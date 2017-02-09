using System;
using System.IO;
using System.Collections.Generic;
namespace InputPipeline {
    public class StandarInput {
        /// <summary>
        /// It recives an array of questions printed to stdout. Returns a string of answers gathered form stdin
        /// </summary>
        /// <param name="Questions"></param>
        /// <returns>
        /// </returns>
        public string[] MultipleInputReader(string[] Questions) {
            //Answers array
            string[] Answers;
            /*
             * Answers array is initialized with the same questions array size
             * Questions are printed to stdinput
             * Answers are saved into array, recolected from stdinput
             * Return Answers array
             */
            Answers = new string[Questions.Length];
            for (int i = 0; i < Questions.Length; i++) {
                Console.WriteLine(Questions[i]);
                Answers[i] = Console.ReadLine();
            }
            return Answers;
        }

        /// <summary>
        /// Recives a question, printed to stdout. Returns an answer read from stdin.
        /// </summary>
        /// <param name="Question"></param>
        /// <returns></returns>
        public string SimpleInputReader(string Question) {
            //Answers array
            string Answer;
            /*
             * Recibes a Question
             * Prints Question to Stdinput
             * Recollect Answer from Stdinput
             * Returns Answer
             */

            Console.WriteLine(Question);
            Answer = Console.ReadLine();
            return Answer;
        }


    }

    public class FileInput {
        /// <summary>
        /// Recives a file path, reads an entire text file. Returns an ArrayList of such file.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public List<string> FileReader(string path) {
            //Array List declaration:
            List<string> list;
            list = new List<string>();

            //Open data stream:
            StreamReader file;
            file = new StreamReader(path);

            /*
             * Reads first line
             * if not null, adds it to the list
             * repeat untill intermediate becomes null
             * after cicle, closes file, returns list object.
            */

            String intermediate;
            intermediate = file.ReadLine();
            while (intermediate != null) {
                list.Add(intermediate);
                intermediate = file.ReadLine();
            }
            file.Close();
            return list;
        }
    }
}

