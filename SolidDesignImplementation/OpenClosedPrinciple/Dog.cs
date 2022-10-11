using Microsoft.AspNetCore.Mvc;

namespace SolidDesignImplementation.OpenClosedPrinciple
{
    public class Dog : WildAnimal
    {
        public virtual bool Groom()
        {
            string groomable = " Dog Hair cutting";
            if (groomable != null)
            {
                return true;
            }
            return false;
        }

        public bool Speak()
        {
            string speaking = "Dog barks";
            if(speaking != null)
            {
                return true;
            }
            return false;
        }

        public bool Walk()
        {
            string speaking = "Dog runs";
            if (speaking != null)
            {
                return true;
            }
            return false;
        }
    }
}
