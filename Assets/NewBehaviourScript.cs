using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
	public static float fallSpeed = 10f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.down * fallSpeed * Time.deltaTime);
	}
}
