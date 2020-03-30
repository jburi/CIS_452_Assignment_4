using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : Command
{
	ToggleWall wall;

	public Wall(ToggleWall wall)
	{
		this.wall = wall;
	}
	public void Execute()
	{
		wall.Wall();
	}
}
