public class Product {
    
    private String Name ; 
    private int Quantity ; 
    private double Price ; 
    private double Discount ;
    
    // Constructor 
    public Product(String name, int quantity, double price, double discount) {
        Name = name;
        Quantity = quantity;
        Price = price ;
        Discount = discount;
    }

    public double getFinalPrice() {
        double discountAmount = Price * (Discount / 100 ); 
        return Price - discountAmount ; 
    }

    // Getter and Setter
    public int getQuantity() {
        return Quantity;
    }

    public void setQuantity(int quantity) {
        Quantity = quantity;
    }

    public double getPrice() {
        return Price;
    }

    public void setPrice(double price) {
        Price = price;
    }

    public double getDiscount() {
        return Discount;
    }

    public void setDiscount(double discount) {
        Discount = discount;
    }


    public String getName() {
        return Name;
    }


    public void setName(String name) {
        Name = name;
    }

    @Override
    public String toString() {
        return "Name: " + Name + "\nQuantity: " + Quantity + "\nPrice: " + Price + "\nDiscount: " + Discount + "\nFinal Price: " + getFinalPrice() ;
    } 

    
}
