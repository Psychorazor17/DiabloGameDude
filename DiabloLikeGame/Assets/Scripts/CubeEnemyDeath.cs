using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeEnemyDeath : Death
{
    public GameObject particalEffect;
    public string animationTrigger;

    private Animator animator;


    private void Start()
    {
        animator = GetComponent<Animator>();

    }


    public override void Die()
    {
        base.Die();
        animator.SetTrigger(animationTrigger);
        Instantiate(particalEffect, transform.position, transform.rotation);

        StartCoroutine(CheckAnimationDone());

    }

    IEnumerator CheckAnimationDone()
        {
        yield return null;

            while (animator.GetCurrentAnimatorStateInfo(0).normalizedTime <= 1.0f && !animator.IsInTransition(0))
            {
                yield return null;
            }

            Debug.Log("Im dead fo real");
        Destroy(gameObject);
        

    }

}
