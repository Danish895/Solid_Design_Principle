namespace SolidDesignImplementation.OpenClosedPrinciple
{
    public class Cat : WildAnimal
    {
        public  bool Groom()
        {
            string groomable = " Cat Hair cutting";
            if(groomable != null)
            {
                return true;
            }
            return false;
        }

        public bool Speak()
        {
            string speak = "Cat Meow ";
            if (speak != null)
            {
                return true;
            }
            return false;
        }

        public bool Walk()
        {
            string walk = " Cat Walks";
            if (walk != null)
            {
                return true;
            }
            return false;
        }
    }
}
