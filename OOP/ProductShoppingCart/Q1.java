import java.util.Scanner;

public class Q1 {
    

    public static void main(String[] args) {
        
        Scanner sc = new Scanner(System.in);

        Product product1 = new Product("Gaming Console", 5, 299.99, 10);

        Product product2 = new Product("4K TV", 3, 799.99, 15);
       
        Product product3 = new Product("Bluetooth Headphones", 10, 149.99, 5);


        System.out.println(product2);
        
    }


}
