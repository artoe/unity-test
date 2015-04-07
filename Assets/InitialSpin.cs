using UnityEngine;
using System.Collections;

public class InitialSpin : MonoBehaviour {
	void Start ()
	{
		GetComponent<Rigidbody>().AddTorque(12,-56, 14, ForceMode.Impulse);
	}

	// Use this for initialization
	void Update () {

	}
}
