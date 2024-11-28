using Godot;
using System;
using System.IO;

public partial class MercyRoom : Node
{
    [Export]
    public String SaveText { get; set; }

    [Export]
    public Label MessageLabel { get; set; }

    [Export]
    public AudioStreamPlayer2D StreamPlayer { get; set; }

    [Export]
    public AudioStreamOggVorbis SaveNarration { get; set; }

    [Export]
    public AudioStreamOggVorbis SaveSound { get; set; }

    [Export]
    public String GameSavedText { get; set; } = "Your game has been saved";

    [Export]
    public String NorthRoomPath { get; set; } = "res:/scenes/candy_room.tscn";

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
    {
    }

    public void PlaySaveClip()
    {
        StreamPlayer.Stream = SaveSound;
        StreamPlayer.Play();
        StreamPlayer.Finished -= PlaySaveClip;
        MessageLabel.Text = GameSavedText;
    }

    public void OnSaveClick()
    {
        StreamPlayer.Stream = SaveNarration;
        MessageLabel.Text = SaveText;
        StreamPlayer.Play();
        StreamPlayer.Finished += PlaySaveClip;
    }

    public void OnGoNorth()
    {
        GetTree().ChangeSceneToFile(NorthRoomPath);
    }
}
