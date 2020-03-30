using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MoveLeft : Command
{
	MoveObject moveObject;
	Stack<Vector3> positionHistory;

	public MoveLeft(MoveObject moveObject)
	{
		this.moveObject = moveObject;
		positionHistory = moveObject.GetHistory();
	}

	public void Execute()
	{
		positionHistory.Push(moveObject.GetCurrentPosition());

		moveObject.MoveLeft();

	}
}