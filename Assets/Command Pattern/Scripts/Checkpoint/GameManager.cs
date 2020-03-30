using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public bool checkpointHit;
	public bool finishHit;
	public float timeLeft = 20;

	private void Update()
	{
		timeLeft -= Time.deltaTime;
		if (timeLeft < 0)
		{
			SceneManager.LoadScene("Lose");
		}
		else if (checkpointHit == true && finishHit == true)
		{
			SceneManager.LoadScene("Win");
		}
	}
}
