namespace Facade
{
    public class Facade
    {
        private SubSystemA subSystemA = new SubSystemA();
        private SubSystemB subSystemB = new SubSystemB();
        private SubSystemC subSystemC = new SubSystemC();

        public void OperationAB()
        {
            subSystemA.OperationA();
            subSystemB.OperationB();
        }

        public void OperationBC() 
        {
            subSystemB.OperationB();
            subSystemC.OperationC();
        }
    }
}
