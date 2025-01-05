using Godot;

[GlobalClass]
public partial class ConsumableItem : BaseItem
{
    [Export]
    public string ShortName { get; set; }

    // Note: Invalid Values will be used for special values
    [Export]
    public int HealAmount { get; set; }

    public ConsumableItem() : this(-1, null, null, -1, 0, 0, 0, null, 0)
    {

    }

    public ConsumableItem(int itemID, string name, string flavorText, int buyPrice, int sellPrice, int negotiateOnePrice, int negotiateTwoPrice, string shortName, int healAmount) : base(itemID, name, flavorText, buyPrice, sellPrice, negotiateOnePrice, negotiateTwoPrice)
    {
        ShortName = shortName;
        HealAmount = healAmount;
    }
}