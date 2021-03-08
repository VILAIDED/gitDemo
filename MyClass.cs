namespace classPro{
    public class MyClass : IFile1,IFile2{
       void IFile2.A(){
            System.Console.WriteLine("A1");
        }
        void IFile1.A(){
            System.Console.WriteLine("Hi A");
        }
        public void B(){
            System.Console.WriteLine("B1");
        }
        public void F(){
            System.Console.WriteLine("F1");
        }
        public void C(){
            System.Console.WriteLine("C1");
        }
    }
}