using Godot;
using System;

public partial class CombatantPanel : PanelContainer
{

	[Export]
	public Texture2D PortraitTexture { get; set; }
	[Export]
	public Texture2D BlockSprite { get; set; }
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		GetNode<TextureRect>("Portrait").Texture = PortraitTexture;
		GetNode<TextureRect>("Block/BlockSprite").Texture = BlockSprite;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
