using Godot;
using System;
using System.Diagnostics;

public partial class bar : RigidBody2D
{
	float speed = 200f;
	float dir = 0;

	public override void _Ready()
	{

	}

	public override void _Process(double delta)
	{
		dir = 0;
		if (Input.IsActionPressed("MoveUp"))
		{
			dir = -1;
		}
		else if(Input.IsActionPressed("MoveDown"))
		{
			dir = 1;
		}

		Position += new Vector2(0, dir * speed * (float)delta);
	}


}
