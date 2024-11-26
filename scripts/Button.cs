using Godot;
using System;

public partial class Button : Node
{
    [Export]
    CollisionObject2D MyCollider;
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        MyCollider.InputEvent += MyInputMethod;
    }

    void MyInputMethod(Node viewport, InputEvent @event, long shapeIdx)
    {
        if (@event is InputEventMouseButton mousButt)
        {

            if (mousButt.Pressed)
            {
                GD.Print("I clicked");
                //Do things
            }
        }
    }
}
