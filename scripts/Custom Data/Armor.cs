using Godot;

[GlobalClass]
public partial class Armor : BaseItem
{
    [Export]
    public int ShortName { get; set; }

    [Export]
    public int AttackBoost { get; set; }

    [Export]
    public int DefenseBoost { get; set; }
}