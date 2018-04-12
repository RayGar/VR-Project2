using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class object_manager_var3 : MonoBehaviour {
	public GameObject this_window;
	public GameObject next_window1;
	public GameObject next_window2;
	public GameObject next_windowf;
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
		next_window1.SetActive (true);
		next_window2.SetActive (true);
		next_windowf.SetActive (false);
		this_window.SetActive(false);
		//print("Do 5 seconds later");


	}

	public void OnTriggerExit ()
	{
		StopCoroutine("Activate_event");
	}
}
