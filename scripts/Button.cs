using Godot;

public partial class Button : Node
{
    [Export]
    private CollisionObject2D MyCollider;

    [Signal]
    public delegate void ClickEventHandler();

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        MyCollider.InputEvent += MyInputMethod;
    }

    private void MyInputMethod(Node viewport, InputEvent @event, long shapeIdx)
    {
        if (@event is InputEventMouseButton mousButt)
        {
            if (mousButt.Pressed)
            {
                EmitSignal(SignalName.Click);
                //Do things
            }
        }
    }
}