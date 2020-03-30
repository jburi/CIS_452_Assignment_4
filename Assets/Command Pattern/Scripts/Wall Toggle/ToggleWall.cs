using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleWall : MonoBehaviour
{
	public GameObject wall1;
	public GameObject wall2;

	public void Wall()
	{
		if(wall1.activeSelf == true)
		{
			wall1.SetActive(false);
			wall2.SetActive(true);
		}
		else
		{
			wall1.SetActive(true);
			wall2.SetActive(false);
		}
		
	}
}
