using Godot;
using System;

[GlobalClass]
public partial class Weapon : BaseItem
{
    [Export]
    public int AttackBoost { get; set; }

    [Export]
    public int NegotiateOnePrice { get; set; }

    [Export]
    public int NegotiateTwoPrice { get; set; }
}
