using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour {


    public float maxHealth = 1.0f;

    private bool isDead = false;

    private float currentHealth;




	// Use this for initialization
	void Start () {
        currentHealth = maxHealth;

	}


    void Damage(float amount)
    {

        currentHealth -= amount;
        if (currentHealth <= 0.0f && !isDead)

        {
            Death();
            isDead = true;
        }

    }
	// Update is called once per frame
	void Death ()
    {

    


        GetComponent<Death>().Die();
       

	}
}
