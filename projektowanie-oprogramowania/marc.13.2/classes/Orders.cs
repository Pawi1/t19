namespace marc._13._2;

public class Orders
{
    Client? Client;
    Product? Product;
    Delivery? Delivery;
    public void SetClient(Client client)
        {
            Client = client;
        }
    public void SetProduct(Product product)
        {
            Product = product;
        }
    public void AssignDelivery(Delivery delivery)
        {
            Delivery = delivery;
        }
}
