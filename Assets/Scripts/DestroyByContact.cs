using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour
{
	//Destroy os Asteroids
	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Boundary")
		{
			return;
		}
		Destroy(other.gameObject);
		Destroy(gameObject);
	}
}