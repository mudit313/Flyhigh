using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour {
	public static bool gun = false;
	public static float startx;
	public Transform player;

	void OnCollisionEnter2D (Collision2D col)
	{
		startx = player.position.x;
		gun = true;
		Destroy (gameObject);
	}

}
