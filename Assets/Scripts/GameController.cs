using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{
	public GameObject hazard;
	public Vector3 spawnValues;
	
	void Start ()
	{
		SpawnWaves ();
	}
	//Funçao que sorteia o local que aparecera os asteroids
	void SpawnWaves ()
	{
		//Random.Rage vai sortear local que aparecera os asteroids
		Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
		Quaternion spawnRotation = Quaternion.identity;
		Instantiate (hazard, spawnPosition, spawnRotation);
	}
}