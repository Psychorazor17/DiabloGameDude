using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterDelay : MonoBehaviour {

    public float delay = 1.0f;

	// Use this for initialization
	void Start () {
        Destroy(gameObject, delay);
	}
	
	
}
