using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IMoveObject : MonoBehaviour
{
	public float movementSpeed = 8f;
	public virtual void MovementSpeed()
	{
		movementSpeed = 8f;
	}
	public abstract void SetTime(float someTime);
}
