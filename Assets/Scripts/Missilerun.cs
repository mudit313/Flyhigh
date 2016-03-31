using UnityEngine;
using System.Collections;

public class Missilerun : MonoBehaviour {

	public Transform cam;
	public float missileSpeed = -10f;
	private float h;
	private int k = 0;

	void Update () {
		h = Random.Range (94.4f, 101.2f);
		if (cam.position.x >= (transform.position.x-10) && k == 0) {
			//Debug.Log("Yes");
			transform.position = new Vector3 (transform.position.x, h, 0f);
			//Debug.Log(h);
			k = 1;
		}
		if (k == 1) {
			transform.Translate (Vector2.right * missileSpeed * Time.deltaTime);
		}
	}
}
