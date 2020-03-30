using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : Command
{
	MoveObject moveObject;
	private Stack<Vector3> positionHistory;

	public MoveForward(MoveObject moveObject)
	{
		this.moveObject = moveObject;

		positionHistory = moveObject.GetHistory();
	}

	public void Execute()
	{
		positionHistory.Push(moveObject.GetCurrentPosition());

		moveObject.MoveForward();

	}
}
