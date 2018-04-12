using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class object_manager_var1 : MonoBehaviour {
	public GameObject this_window;
	public GameObject next_window;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	public void MoveBoxUp(){

		//Destroy (this.gameObject);
	}

	public void OnTriggerEnter ()
	{
		StartCoroutine("Activate_event"); //Call new function
	}

	public IEnumerator Activate_event ()
	{

		//print("Do now");
		//5f
		yield return new WaitForSeconds(1f);
		//Destroy (this.gameObject);
		next_window.SetActive (true);
		this_window.SetActive(false);
		//print("Do 5 seconds later");


	}

	public void OnTriggerExit ()
	{
		StopCoroutine("Activate_event");
	}
}
