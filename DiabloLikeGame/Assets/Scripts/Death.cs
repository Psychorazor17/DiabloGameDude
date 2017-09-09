using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
   

    public int XPValue = 1;

    public virtual void Die()
    {

    PlayerLevel.AddXP(XPValue);

    }

}
    

