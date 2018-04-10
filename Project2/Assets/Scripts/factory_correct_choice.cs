using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
public class factory_correct_choice : MonoBehaviour {
	public Button buttonComponent; 
	public GameObject this_window;
	public GameObject river_state;
	void Start () {
		buttonComponent.onClick.AddListener (HandleClick);
	}
	public void HandleClick()
	{
		this_window.SetActive(false);
		river_state.SetActive(false);
	}

	// Update is called once per frame
	void Update () {

	}
}
