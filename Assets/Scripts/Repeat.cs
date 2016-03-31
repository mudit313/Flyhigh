using UnityEngine;
using System.Collections;

// @NOTE the attached sprite's position should be "top left" or the children will not align properly
// Strech out the image as you need in the sprite render, the following script will auto-correct it when rendered in the game
[RequireComponent (typeof (SpriteRenderer))]

// Generates a nice set of repeated sprites inside a streched sprite renderer
// @NOTE Vertical only, you can easily expand this to horizontal with a little tweaking
public class Repeat : MonoBehaviour {
	SpriteRenderer sprite;
	public float sc;
	public int lay;
	public string st;
	public bool add = true;
	public GameObject pl;
	private int i = 1;
	
	void Update () {
		// Get the current sprite with an unscaled size
		sprite = GetComponent<SpriteRenderer> ();
		//Vector2 spriteSize = new Vector2(sprite.bounds.size.x , sprite.bounds.size.y);
		//Debug.Log (sprite.bounds.size.x);
		
		// Generate a child prefab of the sprite renderer
		GameObject childPrefab = new GameObject ();
		SpriteRenderer childSprite = childPrefab.AddComponent<SpriteRenderer> ();
		childPrefab.transform.position = transform.position + (new Vector3(sprite.bounds.size.x - 0.3f, 0, 0) * i);
		childPrefab.transform.localScale = new Vector3 (sc, sc, sc);
		childPrefab.layer = lay;
		childSprite.sprite = sprite.sprite;
		childSprite.sortingLayerName = st;
		if (add) {
			PolygonCollider2D childcoll = childPrefab.AddComponent<PolygonCollider2D> ();
		}
		i = i + 1;
	}

		// Loop through and spit out repeated tiles
		/*void Update(){
		GameObject child;
		//for (int i = 1, l = (int)Mathf.Round(sprite.bounds.size.x); i < l; i++) {

			child = Instantiate(Awake.childPrefab) as GameObject;
			child.transform.position = transform.position + (new Vector3(childPrefab.sprite.bounds.size.x - 0.3f, 0, 0) * 1);
			child.transform.localScale = new Vector3(sc, sc, sc);
			child.layer = lay;
			child.transform.parent = transform;
		
		// Set the parent last on the prefab to prevent transform displacement
		childPrefab.transform.parent = transform;
		
		// Disable the currently existing sprite component since its now a repeated image
		sprite.enabled = false;
	}*/
}