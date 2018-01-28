using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Edge : MonoBehaviour {

  public int edgeId;
  public int[] connect;
  public bool isLink;

	public MeshRenderer rend;

	void Start(){
		rend = GetComponent<MeshRenderer> ();
	}
	void Update(){
		if (isLink) {
			rend.enabled = true;
			//rend.material.color.a = 0.2;
			//rend.material.shader = Shader.Find ("Specular");
			//rend.material.SetColor ("_SpecColor", Color.yellow);	
		} else {
			rend.enabled = false;
			//rend.material.color.a = 0.8;
			//rend.material.shader = Shader.Find ("Specular");
			//rend.material.SetColor ("_SpecColor", Color.grey);	
		}
	}
}