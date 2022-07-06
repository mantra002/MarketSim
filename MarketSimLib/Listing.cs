using System;

public class Listing
{
    public enum Type
    {
        Buy, Sell, Complete
    }

    private Type typeOfLisitng;
    private double price;
    private Good baseGood;
    private int quantity;

    public Type TypeOfListing { get { return typeOfLisitng; } }
    public double PricePerUnit { get { return price; } }
    public Good BaseGood { get { return baseGood; } }
    public int Quantity { get { return quantity; } }

    public Listing(Type type, Good baseGood, int quant, int price)
	{
        this.typeOfLisitng = type;
        this.price = price;
        this.baseGood = baseGood;
        this.quantity = quant;
	}

    public bool Execute(int quantity)
    {
        if (quantity > this.quantity) return false;
        this.quantity -= quantity;
        if (this.quantity == 0) this.typeOfLisitng = Type.Complete;
        return true;
    }
}
