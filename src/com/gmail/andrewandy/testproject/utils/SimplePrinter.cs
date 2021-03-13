using System;

namespace com.gmail.andrewandy.TestProject {

    public class SimplePrinter : IPrinter {

        
        public void Print(params string[] args) {
            foreach (string s in args) {
                Console.WriteLine(s);
            }
        }

    }

    public class DummyObject {

        private readonly IPrinter _printer;

        public DummyObject(IPrinter printer) {
            _printer = printer;
        }

        public void Test(string arg) {
            _printer.Print(arg);
        }

    }

}