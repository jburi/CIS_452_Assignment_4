using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
	private GameManager gm;
	private void Start()
	{
		gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>();
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player") && gm.checkpointHit == true)
		{
			gm.finishHit = true;
		}
	}
}
