namespace SolidDesignImplementation.OpenClosedPrinciple
{
    public class BadCode
    {
        public bool qualities(string Animal)
        {
            if(Animal == "Cat")
            {
                bool Groom()
                {
                    string groomable = " Cat Hair cutting";
                    if (groomable != null)
                    {
                        return true;
                    }
                    return false;
                }

                bool Speak()
                {
                    string speak = " Cat Meow ";
                    if (speak != null)
                    {
                        return true;
                    }
                    return false;
                }

                bool Walk()
                {
                    string walk = "Cat  Walks";
                    if (walk != null)
                    {
                        return true;
                    }
                    return false;
                }
            }
            else if(Animal == "Dog")
            {
                bool Groom()
                {
                    string groomable = "Dog Hair cutting";
                    if (groomable != null)
                    {
                        return true;
                    }
                    return false;
                }

                bool Speak()
                {
                    string speak = "Dog  Barks";
                    if (speak != null)
                    {
                        return true;
                    }
                    return false;
                }

                bool Walk()
                {
                    string walk = "Dog Walks";
                    if (walk != null)
                    {
                        return true;
                    }
                    return false;
                }
            }
            return false ;
        }
    }
}
