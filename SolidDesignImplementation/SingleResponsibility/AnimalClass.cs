namespace SolidDesignImplementation.SingleResponsibility
{
    public class AnimalClass
    // only methods & functions related to  Animals
    {
        public string dog;

        public bool run()
        {
            if(dog!= null)
            {
                return true;
            }
            return false;
        }
    }
}
