using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MoveObjectDecorator : IMoveObject
{
	public override abstract void SetTime(float someTime);
	public abstract float GetTime();
	public abstract void PlaySoundEffect();
}
