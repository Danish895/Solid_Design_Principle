namespace SolidDesignImplementation.Liskov_sSubstitution
{
    public class Square : IAreaShape
    {
        public string Area(int side)
        {
            int  a =  side * side;
            return a.ToString();
        }
    }
}
