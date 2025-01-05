using Godot;


public abstract partial class BaseItem : Resource
{
    [Export]
    public int ItemID { get; set; }

    [Export]
    public int Name { get; set; }

    [Export]
    public string FlavorText { get; set; }

    [Export]
    public int BuyPrice { get; set; }

    [Export]
    public int SellPrice { get; set; }

    [Export]
    public int NegotatieOnePrice { get; set; }

    [Export]
    public int NegotatieTwoPrice { get; set; }
}

