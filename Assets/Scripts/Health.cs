using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    public float health = 100f;

    public void LoseHealth(float damage){
        health -= damage;
        if (health < 0)
            Destroy(gameObject);
        else
           Debug.Log(health);
    }
}
