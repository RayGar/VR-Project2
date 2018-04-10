using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class CityWindoChoice1 : MonoBehaviour {
	public Button buttonComponent; 
	public GameObject this_window;
	public GameObject next_window;
	// Use this for initialization
	void Start () {
		buttonComponent.onClick.AddListener (HandleClick);
	}
	public void HandleClick()
	{
		next_window.SetActive (true);
		this_window.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

}
