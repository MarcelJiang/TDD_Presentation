using TDD_Presentation_domain;


namespace TDD_PresentationTest
{
    public class ShoppingCartTests
    {
        [Fact]
        public void CountItems_All()
        {
            // Arrange
            var cart = new ShoppingCart();
            var product1 = new Product() { Name = "Apfel" };
            var product2 = new Product() { Name = "Apfel" };
            var product3 = new Product() { Name = "Apfel" };

            cart.AddProduct(product1);
            cart.AddProduct(product2);
            cart.AddProduct(product3);

            // Act
            var count = cart.ProductCountAll();

            // Assert
            Assert.Equal(3, count);
        }

        [Fact]
        public void CountItems_Unique()
        {
            // Arrange
            var cart = new ShoppingCart();
            var product1 = new Product() { Name = "Apfel" };
            var product2 = new Product() { Name = "Apfel" };
            var product3 = new Product() { Name = "Birne" };
            var product4 = new Product() { Name = "Birne" };
            var product5 = new Product() { Name = "Birne" };
            var product6 = new Product() { Name = "Tee" };
            var product7 = new Product() { Name = "Tee" };
            var product8 = new Product() { Name = "Kirsche" };

            cart.AddProduct(product1);
            cart.AddProduct(product2);
            cart.AddProduct(product3);
            cart.AddProduct(product4);
            cart.AddProduct(product5);
            cart.AddProduct(product6);
            cart.AddProduct(product7);
            cart.AddProduct(product8);

            // Act
            var count = cart.ProductCountUnique();

            // Assert
            Assert.Equal(4, count);
        }

        [Fact]
        public void Add_ManyProducts()
        {
            //Arrange
            var cart = new ShoppingCart();
            var product1 = new Product() { Name = "Apfel" };
            var product2 = new Product() { Name = "Apfel" };
            var product3 = new Product() { Name = "Birne" };
            var product4 = new Product() { Name = "Birne" };
            var product5 = new Product() { Name = "Birne" };
            var product6 = new Product() { Name = "Tee" };
            var product7 = new Product() { Name = "Tee" };
            var product8 = new Product() { Name = "Kirsche" };

            cart.AddManyProducts(new List<Product> { product1, product2, product3, product4,
                product5, product6, product7,product8});
            //Act

            //Assert
            Assert.Equal(4, cart.ProductCountAll());

        }
    }
}