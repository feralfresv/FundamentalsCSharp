namespace ACM.BL
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            var product = new Product();
            if(productId == 2)
            {
                product.ProductName = "Fernando";
                product.ProductDescription = "Descriptions...";
                product.CurrentPrice = 15.69m;
            }

            return product;
        }

        public bool Save(Product product) 
        {
            return true;
        }
    }
}