namespace SolidDesignImplementation.Liskov_sSubstitution
{
    
    public class SquareArea
    {
        public int side;
        public int area(int side)
        {
            return side*side;
        }
    }

    public class RecatangleArea : SquareArea
    {
        public int len;
        public int bre;
        public int perimeter(int len, int bre)
        {
            return 2 * (len + bre);
        }
    }
}
