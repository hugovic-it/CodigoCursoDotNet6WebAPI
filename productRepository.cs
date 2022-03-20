public static class productRepository  
{ //classe projetada para simular um repositorio de dados
    public static List<Product> Products { get; set; } = Products = new List<Product>(); 
    public static void Init(IConfiguration configuration){
        var products = configuration.GetSection("Products").Get<List<Product>>();
        Products = products;
    }
    public static void Add(Product product){
        //if(Products == null){/*criação da lista<product>*/}
        Products.Add(product);
    }

    public static Product GetBy(string code){
        return Products.FirstOrDefault(p=> p.Code == code);
    }

    public static void Remove(Product product){
        Products.Remove(product);
    }

}
