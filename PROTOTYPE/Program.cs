namespace PROTOTYPE 
{ 
    class Program
    {
    /// <summary>
    ///  Клиентский код
    /// </summary>
        static void Main()
        {
            IBaseClass myObject = new ImplementationOne(1);
            myObject.GetId();

            IBaseClass clone = myObject.Clone();
            clone.GetId();

            myObject = new ImplementationTwo(2);
            myObject.GetId();

            clone = myObject.Clone();
            clone.GetId();
        }
    }
}