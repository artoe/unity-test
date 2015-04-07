using UnityEngine;
using System.Collections;

public class CollisionColorChanger : MonoBehaviour {

	Color[] c = { Color.cyan, Color.green, Color.magenta, Color.yellow };
	static int i = 0;

	// Use this for initialization
	void Start () {
		Color c = new Color (0,0,1,0.5f);
		gameObject.GetComponent<MeshRenderer> ().material.color = c;
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter (Collision col)
	{
		MeshRenderer x = col.gameObject.GetComponent<MeshRenderer> ();
		x.material.color =c[(i++) % c.Length];
	}
}
