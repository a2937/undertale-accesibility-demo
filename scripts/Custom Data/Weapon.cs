using Godot;
using System;

[GlobalClass]
public partial class Weapon : BaseItem
{
    [Export]
    public int AttackBoost { get; set; }

    public Weapon() : this(-1, null, null, -1, 0, 0, 0, 0)
    {

    }

    public Weapon(int itemID, string name, string flavorText, int buyPrice, int sellPrice, int negotiateOnePrice, int negotiateTwoPrice, int attackBoost) : base(itemID, name, flavorText, buyPrice, sellPrice, negotiateOnePrice, negotiateTwoPrice)
    {
        AttackBoost = attackBoost;
    }
}
