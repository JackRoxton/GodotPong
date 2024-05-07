using Godot;
using System;
using System.Diagnostics;

public partial class ball : Area2D
{
	[Signal]
	public delegate void HitEventHandler();

	float speed = 200f;
	Vector2 velocity = Vector2.Zero;

	public override void _Ready()
	{
		this.velocity.X = -1f * speed;
	}

	public override void _Process(double delta)
	{
		Position += velocity * (float)delta;
	}

	/*private void OnBodyEntered(Node2D body)
	{
		GD.Print("hit");
		EmitSignal(SignalName.Hit);
		GetNode<CollisionShape2D>("CollisionShape2D").SetDeferred(CollisionShape2D.PropertyName.Disabled, true);
	}*/

	private void OnBodyEntered(Node2D body)
	{
		GD.Print("hit !");

		if(body.Name == "Bar")
		{
			velocity *= -1f;
		}


		EmitSignal(SignalName.Hit);
        // where did the ball hit ?
        //get_slide_collision(i)
    }

}
