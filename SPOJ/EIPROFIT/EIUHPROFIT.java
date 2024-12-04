import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class EIUHPROFIT {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int numPro = sc.nextInt(); 
        int numK = sc.nextInt(); 

        List<Product> products = new ArrayList<>() ; 

        for ( int i = 0 ; i < numPro ; i++ ) {
            int identity = sc.nextInt(); 
            String name = sc.next();

            double price = sc.nextDouble(); 
            double cost = sc.nextDouble(); 
            int quantitySold = sc.nextInt() ; 
            
            double profit = ( price - cost ) * quantitySold ; 

            products.add( new Product(identity, name, profit) );
        }

        // sort sản phẩm 
        products.sort( (p1,p2) ->  {
            if ( p2.getProfit() != p1.getProfit() ) {
                return Double.compare(p2.getProfit(), p1.getProfit()) ; 
            } else {
                return Double.compare(p1.getIdentity(), p2.getIdentity() ); 
            }
        });

        // xác định lợi nhuận 
        List<Product> result = new ArrayList<>();
        double minProfit = products.get(numK - 1).getProfit(); // Lợi nhuận nhỏ nhất trong top k

        for (Product product : products) {
            if (product.getProfit() >= minProfit) {
                result.add(product);
            } else {
                break;
            }
        }

        // In kết quả
        for (Product product : result) {
            System.out.println(product.getIdentity() + " " + product.getName() + " " + product.getProfit());
        }


    }

}
