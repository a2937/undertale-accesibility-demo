using Godot;

public partial class FriskMove : AnimatedSprite2D
{
    [Export]
    private int WalkSpeed = 1;

    private Node2D _node;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
    {
        if (_node != null)
        {
            Position.MoveToward(_node.Position, 0.01f);
            if (Position.DistanceTo(_node.Position) <= 1f)
            {
                _node = null;

            }
        }
    }

    public void WalkTo(Node2D node)
    {
        _node = node;
    }
}
