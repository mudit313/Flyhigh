using UnityEngine;
using System.Collections;

public class Dest : MonoBehaviour {
	public static bool dead = false;

	void OnCollisionEnter2D (Collision2D col)
	{
		if(col.gameObject.name == "Player")
		{
			Gun.gun = false;
			dead = true;
			Destroy(col.gameObject);
		}
	}
}
