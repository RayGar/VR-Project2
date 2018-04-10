using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class City_manager : MonoBehaviour {
	public GameObject city_window;
	public GameObject this_collider;
	//public Collider local_collider; 
	// Use this for initialization
	void Start () {
		//city_window.SetActive(true);
		//!local_collider.enabled;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnMouseDown()
	{
		city_window.SetActive(true);
		this_collider.SetActive(false);

	}
}
