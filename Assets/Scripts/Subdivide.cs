using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Torec;

public class Subdivide : MonoBehaviour {
	public Mesh mesh;
	public int iter;
	public CatmullClark.Options.BoundaryInterpolation m_boundaryInterpolation;
	public Material m_material;

	// Use this for initialization
	void Start () {

		mesh = CatmullClark.Subdivide(mesh, iter, new CatmullClark.Options {
			boundaryInterpolation = m_boundaryInterpolation,
		});

		var obj = new GameObject("cell");
		obj.transform.SetParent(this.transform);
		obj.transform.position = new Vector3(0, 0, 0);

	}
	
	// Update is called once per frame
	void Update () {

	}
}
