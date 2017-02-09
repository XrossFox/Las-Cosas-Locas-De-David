using System;
using System.Collections.Generic;
using InputPipeline;

namespace CountEngine {
    public class Test {
        
        public static void Main() {
            List<string> lines;
            Result result;
            //Note to myself: Remove pipeline reference before finalizing dll
            FileInput fi;
            fi = new FileInput();
            lines = fi.FileReader("C:\\David\\test.cs");
            CountEngine ce;
            ce = new CountEngine(lines);
            result = ce.Ignition();
            Console.WriteLine(result);
            Console.ReadLine();


        }
    }
}
