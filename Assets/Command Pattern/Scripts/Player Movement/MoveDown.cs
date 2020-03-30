using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MoveDown : Command
{
	MoveObject moveObject;
	private Stack<Vector3> positionHistory;

	public MoveDown(MoveObject moveObject)
	{
		this.moveObject = moveObject;
		positionHistory = moveObject.GetHistory();
	}

	public void Execute()
	{
		positionHistory.Push(moveObject.GetCurrentPosition());

		moveObject.MoveDown();
	}
}
