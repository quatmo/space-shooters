using UnityEngine;
using System.Collections;

public class DestroyByTime : MonoBehaviour
{
	public float lifetime;
	//destroi os asteroids que nao levaram tiro
	void Start ()
	{
		Destroy (gameObject, lifetime);
	}
}