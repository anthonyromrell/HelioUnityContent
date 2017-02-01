using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class ColorDot : MonoBehaviour {

	public static Func<Material> GetMaterial;

	// Use this for initialization
	void Start () {
		Renderer rend = GetComponent<Renderer>();
		rend.material = GetMaterial();
	}

}
