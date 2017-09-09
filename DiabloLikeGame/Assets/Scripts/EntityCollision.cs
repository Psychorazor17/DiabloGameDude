using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityCollision : MonoBehaviour 
{
    public float radius = 1.0f;
    public LayerMask layermask = -1;

    private Vector3 lastPosition;


	// Use this for initialization
	void Start () {


        lastPosition = transform.position;

		
	}
	
	// Update is called once per frame
	void Update () {

        if (lastPosition != transform.position)

        { 

        Vector3 moveDirection = transform.position - lastPosition;

        RaycastHit hit;

        if (Physics.Raycast(lastPosition, moveDirection, out hit, radius, layermask))
        {
            Vector3 tangent = Vector3.Cross(Vector3.Cross(hit.normal, moveDirection), hit.normal).normalized;
            Debug.DrawRay(transform.position, tangent, Color.black, 1.0f);

                if (!Physics.Raycast(lastPosition, tangent, 1.0f, layermask))
                {
                    transform.position = lastPosition + tangent * Vector3.Project(moveDirection, tangent).magnitude;
                }
                else

                {
                    transform.position = lastPosition;

                }


        }
       

            lastPosition = transform.position;
       }
    }
}
