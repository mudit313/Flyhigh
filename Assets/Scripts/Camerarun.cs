using UnityEngine;
using System.Collections;

public class Camerarun : MonoBehaviour {

	public Transform player;
	public Vector3 offset;

	void Update () {
		if(player != null)
			transform.position = new Vector3 (player.position.x + offset.x, offset.y, offset.z); 
	}
}
