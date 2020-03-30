using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRight : Command
{
	MoveObject moveObject;
	private Stack<Vector3> positionHistory;

	public MoveRight(MoveObject moveObject)
	{
		this.moveObject = moveObject;
		positionHistory = moveObject.GetHistory();
	}

	public void Execute()
	{
		positionHistory.Push(moveObject.GetCurrentPosition());

		moveObject.MoveRight();

	}
}
