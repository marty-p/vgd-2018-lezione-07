using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCaster : MonoBehaviour {
	
	void FixedUpdate () {

        RaycastHit hit;

        if (Input.GetButton("Fire1"))
        {
            Debug.DrawRay(transform.position, transform.forward * 100f, Color.red);
            if (Physics.Raycast(transform.position, transform.forward, out hit, 100f))
            {
                Health health = hit.collider.gameObject.GetComponent<Health>();
                if (health != null)
                {
                    health.LoseHealth(5f);
                }
            }
        }




    }
}
