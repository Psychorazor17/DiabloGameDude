using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnTiggerEnter : MonoBehaviour {

    

	// Use this for initialization
	void Start () {
		
	}

    void OnTriggerEnter ()
    {
        Destroy(gameObject);
    }
}
