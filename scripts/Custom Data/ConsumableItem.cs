using Godot;

[GlobalClass]
public partial class ConsumableItem : BaseItem
{
    [Export]
    public int ShortName { get; set; }

    // Note: Invalid Values will be used for special values
    [Export]
    public int HealAmount { get; set; }
}