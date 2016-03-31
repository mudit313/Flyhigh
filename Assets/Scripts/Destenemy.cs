using UnityEngine;
using System.Collections;

public class Destenemy : MonoBehaviour {

	void OnCollisionEnter2D (Collision2D col)
	{
		if(col.gameObject.name != "Player" && col.gameObject.name != "New Game Object")
		{
			Destroy(col.gameObject);
		}

		if(col.gameObject.name == "New Game Object")
		{
			Destroy(gameObject);
		}
	}
}
