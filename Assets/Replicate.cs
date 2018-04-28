using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Replicate : MonoBehaviour {
	public string myName;

	// Use this for initialization
	void Start () {
		Debug.Log (myName + " started");

	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody>().AddTorque(transform.up * 0.5f * 0.1f);

	}
}
