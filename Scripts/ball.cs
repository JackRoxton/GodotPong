using Godot;
using System;

public partial class ball : RigidBody2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		this.LinearVelocity = new Vector2(-1,0);
	}
	
}
