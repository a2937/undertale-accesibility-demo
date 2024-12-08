using Godot;
using System;

public partial class GameController : Node
{
    [Export]
    public String MainRoomPath { get; set; } = "res://scenes/main.tscn";

    [Export]
    public AudioStreamPlayer2D streamPlayer;
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
    {
    }

    public void PlaySound(String soundPath)
    {
        if (streamPlayer != null)
        {
            var stream = ResourceLoader.Load<AudioStreamOggVorbis>(soundPath);
            streamPlayer.Stream = stream;
            streamPlayer.Play();
        }
        else
        {
            GD.PrintErr("No audioplayer set");
        }
    }

    public void GoToMainScene()
    {
        GetTree().ChangeSceneToFile(MainRoomPath);
    }

    public void Quit()
    {
        // call the quit method from OS class
        GetTree().Quit();
    }
}
