﻿using UnityEngine;
using System.Collections;

public class ShieldController : MonoBehaviour {

    public int defense;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("EnemyWeapon"))
        {
            int damageReceived = other.gameObject.GetComponent<DamageDealer>().damage;
            if (damageReceived > defense) {
                other.gameObject.GetComponent<DamageDealer>().damage -= defense;
            }
            else {
                Destroy(other.gameObject);
            }
        }
    }
}
