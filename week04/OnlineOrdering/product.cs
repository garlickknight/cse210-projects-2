public class Product
{
        private string name;
        private int productId;
        private float price;
        private int quantity;

        public Product(string _name, int productID, float _price, int _quantity)
    {
        name = _name;
        productId = productID;
        price = _price;
        quantity = _quantity;

    }
        public string GetName()
        {
            return name;
        }
        public int GetProductId()
        {
            return productId;
        }
        public float GetPrice()
        {
            return price;
        }
        public int GetQuantity()
        {
            return quantity;
        }
        public float GetTotalCost()
        {
            float total = price * quantity;
            return total;

        }

    }