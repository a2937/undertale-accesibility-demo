using Godot;


public abstract partial class BaseItem : Resource
{
    [Export]
    public int ItemID { get; set; }

    [Export]
    public string Name { get; set; }

    [Export]
    public string FlavorText { get; set; }

    [Export]
    public int BuyPrice { get; set; }

    [Export]
    public int SellPrice { get; set; }

    [Export]
    public int NegotiateOnePrice { get; set; }

    [Export]
    public int NegotiateTwoPrice { get; set; }

    protected BaseItem() : this(-1, null, null, -1, 0, 0, 0)
    {
    }

    protected BaseItem(int itemID, string name, string flavorText, int buyPrice, int sellPrice, int negotiateOnePrice, int negotiateTwoPrice)
    {
        ItemID = itemID;
        Name = name;
        FlavorText = flavorText;
        BuyPrice = buyPrice;
        SellPrice = sellPrice;
        NegotiateOnePrice = negotiateOnePrice;
        NegotiateTwoPrice = negotiateTwoPrice;
    }
}

