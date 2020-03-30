using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenPickup : MoveObjectDecorator
{
	public MoveObject _player;
	public float reducedTime = 0f;

	public AudioClip coinPickup;
	AudioSource audioSource;

	private void Start()
	{
		audioSource = GetComponent<AudioSource>();
	}
	public GreenPickup(MoveObject player)
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

	public override void MovementSpeed()
	{
		_player.SetMS(3f);
	}
	public override void PlaySoundEffect()
	{
		audioSource.PlayOneShot(coinPickup);
	}
}
