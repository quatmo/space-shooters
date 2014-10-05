using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour
{
	public GameObject explosion;
	public GameObject playerExplosion;
	
	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Boundary")
		{
			return;
		}

		//Explode o objeto (efeito)
		Instantiate(explosion, transform.position, transform.rotation);
		if (other.tag == "Player")
		{
			Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
			//gameController.GameOver ();
		}
		//Destroi o objeto que colidiu
		Destroy(other.gameObject);
		Destroy(gameObject);
	}
}