using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorScript : MonoBehaviour {

	public List<Material> Colors;

	void Start () {
		ColorDot.GetMaterial += FuncHandler;
	}

	Material FuncHandler () {
		return Colors[Random.Range(0, 0)];
	}


}
