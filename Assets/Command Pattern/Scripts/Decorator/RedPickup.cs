using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPickup : MoveObjectDecorator
{
	public MoveObject _player;
	public float reducedTime = 5f;

	public AudioClip coinPickup;
	AudioSource audioSource;

	private void Start()
	{
		audioSource = GetComponent<AudioSource>();
	}
	public RedPickup(MoveObject player)
	{
		this._player = player;
	}
	public override float GetTime()
	{
		return reducedTime;
	}
	public override void SetTime(float someTime)
	{
		_player.SetTime(someTime);
	}
	public override void PlaySoundEffect()
	{
		audioSource.PlayOneShot(coinPickup);
	}

}
