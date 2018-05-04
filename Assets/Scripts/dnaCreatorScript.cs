using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dnaCreatorScript : MonoBehaviour {
	public Transform brick;
	public Transform dnaCreator;
	public int dnaRotationSpeed;
		
	// Use this for initialization
	void Start () {
		for (int y = 0; y < 20; y++) {
			var newNucleotide = Instantiate(brick, new Vector3(dnaCreator.position.x, y, dnaCreator.position.z), Quaternion.Euler(new Vector3(0, y * 10, 0)));
			newNucleotide.transform.parent = dnaCreator.transform;
		}

	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.up * Time.deltaTime * dnaRotationSpeed, Space.World);

	}
}
