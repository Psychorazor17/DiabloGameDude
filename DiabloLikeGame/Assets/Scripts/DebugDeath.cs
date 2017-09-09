using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugDeath : Death {

    public override void Die()
    {
        base.Die();
        Destroy(gameObject);
    }

}
