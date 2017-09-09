using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelScaledDamageOnTriggerEnter : MonoBehaviour {


    public float damageBonus= 1.0f;


	// Use this for initialization
	void Start () {
		
	}
	
	
	void OnTriggerEnter (Collider col)

    {
        col.SendMessageUpwards("Damage", damageBonus*PlayerLevel.Instance.currentLevel, SendMessageOptions.DontRequireReceiver);
	}
}
