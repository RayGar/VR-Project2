using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGameObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    private void Update()
    {

    }

    private void OnMouseDown()
    {
        Destroy (this.gameObject);
    }
}
