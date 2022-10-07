namespace Point_of_sale_app.BL
{
    internal class Products
    {
        private string name;
        private float price;
        private string type;
        private float quantity;
        private int min_quantity;
        private float tax;

        public string Name  { get { return name; }set { name = value; }}
        public float Price  { get { return price; } set { price = value; }}
        public string Type   { get { return type; } set { type = value; }}
        public int MinQuantity { get { return min_quantity; } set { min_quantity = value; }}
        public float Tax { get { return tax; } set { tax = value; }}
        public float Quantity { get { return quantity; } set { quantity = value; }}

        public void cal_tax()
        {
            if (type == "grocery")
            {
                tax = price * 0.1f;
            }
            else if (type == "fruit")
            {
                tax = price * 0.05f;
            }
            else
            {
                tax = price * 0.15f;
            }
        }
        public float get_tax()
        {
            return tax;
        }
        public bool minus_quanitity()
        {
            if(quantity>0.0f)
            {
                quantity--;
                return true;
            }
            return false;
        }
    }
}