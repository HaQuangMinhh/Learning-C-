
import java.util.List;
import java.util.*;

public class ShoppingCart {

    private List<Product> Products ;

    // Constructor 
    public ShoppingCart() {
        Products = new ArrayList<Product>() ;
    } 
    
    public void AddProduct(Product newProduct) {
        Products.add(newProduct);
        System.out.println("\nyour product: " + newProduct + " added to the Shopping cart");
    }

    public void RemoveProduct( String name ) {

        boolean found = false ;      // flag 
        for (Product currentProduct : Products) {
            if (currentProduct.getName().equals( name )  ) {
                Products.remove(currentProduct);
                found = true ;
                break ;  
            }
        }
        if ( !found ) {
            System.out.println("Don't have your product: " + name );
        }
    }

    // Calculate Total Cost
    public double getTotalCost() {
        double totalCost = 0 ; 

        for ( Product nextProduct : Products ) {
            totalCost += nextProduct.getFinalPrice();
        }
        return totalCost ; 
    }

    public int getCurrentProductQuantity() {
        return Products.size();
    }


}
