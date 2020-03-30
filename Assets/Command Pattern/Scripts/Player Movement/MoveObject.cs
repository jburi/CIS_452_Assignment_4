using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MoveObject : IMoveObject
{
	public MoveObject()
	{
		this.movementSpeed = 8f;
	}

	private Stack<Vector3> positionHistory = new Stack<Vector3>();
	public Vector3 GetCurrentPosition()
	{
		return gameObject.transform.position;
	}

	public Stack<Vector3> GetHistory()
	{
		return positionHistory;
	}
	public void MoveForward()
	{
		transform.Translate(Vector3.forward * Time.deltaTime * movementSpeed);
	}
	public void MoveLeft()
	{
		transform.Translate(Vector3.left * Time.deltaTime * movementSpeed);
	}
	public void MoveRight()
	{
		transform.Translate(Vector3.right * Time.deltaTime * movementSpeed);
	}
	public void MoveDown()
	{
		transform.Translate(Vector3.back * Time.deltaTime * movementSpeed);
	}
	//Assignment 4 Implementation
	public override void SetTime(float timeLeft)
	{
		GameObject timer = GameObject.FindGameObjectWithTag("TimerText");
		float theTime = timer.GetComponent<Timer>().GetTime();
		timer.GetComponent<Timer>().SetTime(theTime - timeLeft);
	}
	public float GetMS()
	{
		return movementSpeed;
	}
	public void SetMS(float ms)
	{
		movementSpeed = movementSpeed + ms;
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("PickUp"))
		{
			if (other.gameObject.GetComponent<RedPickup>() != null)
			{
				float temp = other.gameObject.GetComponent<RedPickup>().GetTime();
				other.gameObject.GetComponent<RedPickup>().SetTime(temp);
				other.gameObject.GetComponent<RedPickup>().PlaySoundEffect();
			}
			else //Green Pickup
			{
				other.gameObject.GetComponent<GreenPickup>().MovementSpeed();
				other.gameObject.GetComponent<GreenPickup>().PlaySoundEffect();
			}
			other.gameObject.SetActive(false);
		}
	}
}