using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnDamageNumberOnDamage : MonoBehaviour {

    private GameObject damageCanvas;

    public Text damageTextObject;


	// Use this for initialization
	void Start ()
    {
        damageCanvas = GameObject.FindGameObjectWithTag("DamageCanvas");
	}

    void Damage(float amount)
    {
        

        Text instance =Instantiate(damageTextObject, transform.position, damageTextObject.transform.rotation) as Text;
        instance.text = ((int)amount).ToString();
        instance.transform.SetParent(damageCanvas.transform, false);
        
    }
}
