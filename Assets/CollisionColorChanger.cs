using UnityEngine;
using System.Collections;

public class CollisionColorChanger : MonoBehaviour {

	Color[] c = { Color.cyan, Color.green, Color.magenta, Color.yellow };
	static int i = 0;

	// Use this for initialization
	void Start () {
		gameObject.GetComponent<MeshRenderer> ().material.color = Color.blue;
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
