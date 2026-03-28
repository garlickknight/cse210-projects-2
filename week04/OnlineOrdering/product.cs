public class product
{
    public class address
    {
        private string name;
        private int productId;
        private float price;
        private int quantity;

        private float totalcost(float price, int quantity)
        {
            float total = price * quantity;
            return total;
        }


    }
}