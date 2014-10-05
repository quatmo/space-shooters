using UnityEngine;
using System.Collections;

public class RandomRotator : MonoBehaviour
{
	public float tumble;
	
	void Start ()
	{
		//angularVelocity faz a rotaçao do objeto asteroid
		//Random sorteia um numero de 0.0 a 1.0
		rigidbody.angularVelocity = Random.insideUnitSphere * tumble; 
	}
}