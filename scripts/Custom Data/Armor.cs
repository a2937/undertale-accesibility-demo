using Godot;
using Microsoft.VisualBasic;

[GlobalClass]
public partial class Armor : BaseItem
{
    [Export]
    public string ShortName { get; set; }

    [Export]
    public int AttackBoost { get; set; }

    [Export]
    public int DefenseBoost { get; set; }

    public Armor() : this(-1, null, null, -1, 0, 0, 0, null, 0, 0)
    {

    }

    public Armor(int itemID, string name, string flavorText, int buyPrice, int sellPrice, int negotiateOnePrice, int negotiateTwoPrice, string shortName, int attackBoost, int defenseBoost) : base(itemID, name, flavorText, buyPrice, sellPrice, negotiateOnePrice, negotiateTwoPrice)
    {
        ShortName = shortName;
        AttackBoost = attackBoost;
        DefenseBoost = defenseBoost;
    }
}