using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageOnTriggerEnter : MonoBehaviour {


    public float damageAmount = 1.0f;


	// Use this for initialization
	void Start () {
		
	}
	
	
	void OnTriggerEnter (Collider col)

    {
        col.SendMessageUpwards("Damage", damageAmount, SendMessageOptions.DontRequireReceiver);
	}
}
