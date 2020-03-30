using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Undo : Command
{
	MoveObject moveObject;
	private Stack<Vector3> positionHistory;

	public Undo(MoveObject moveObject)
	{
		this.moveObject = moveObject;
		positionHistory = moveObject.GetHistory();
	}

	public void Execute()
	{
		//You could consider Undoing the move left with a move to the right...
		//moveObject.MoveRight();

		//Instead, we will assign the Vector3 position in our stack to our gameObject
		if (positionHistory != null)
		{
			moveObject.gameObject.transform.position = positionHistory.Pop();
		}
	}
}
