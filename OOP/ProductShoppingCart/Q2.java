import java.util.Scanner;

public class Q2 {
    
    public static void main(String[] args) {
        
        Scanner sc = new Scanner(System.in);

        ShoppingCart shoppingCart = new ShoppingCart();

        Product product1 = new Product("Gaming Console", 5, 299.99, 10);
        Product product2 = new Product("Snack", 10, 600, 5);
        Product product3 = new Product("Toy", 20, 400, 20);

        shoppingCart.AddProduct(product1); 
        shoppingCart.AddProduct(product2);
        shoppingCart.AddProduct(product3);

        // =========================================================================
        // đếm quantity 
        System.out.println(shoppingCart.getCurrentProductQuantity());
        System.out.println("================================");
        System.out.println("Total Cost before removing: " + shoppingCart.getTotalCost() );
        System.out.println("================================");

        // remove 
        shoppingCart.RemoveProduct("Snack");
        System.out.println(shoppingCart.getCurrentProductQuantity());
        System.out.println("Total Cost after removing: " + shoppingCart.getTotalCost() );
        System.out.println("================================");

    }


}
