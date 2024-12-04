public class Product {

    private int Identity ; 
    private String Name ; 
    private double Profit ;
    
    
    public Product(int identity, String name, double profit) {
        Identity = identity;
        Name = name;
        Profit = profit;
    }

    public int getIdentity() {
        return Identity;
    }
    public void setIdentity(int identity) {
        Identity = identity;
    }
    public String getName() {
        return Name;
    }
    public void setName(String name) {
        Name = name;
    }
    public double getProfit() {
        return Profit;
    }
    public void setProfit(double profit) {
        Profit = profit;
    } 
}
