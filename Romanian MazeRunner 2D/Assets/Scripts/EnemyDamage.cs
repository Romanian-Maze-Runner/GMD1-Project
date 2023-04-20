using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public float damage;
    
    private PlayerHealth pHealth;
    private IHealthUtility _healthUtility;

    // Start is called before the first frame update
    void Start()
    {
        pHealth = GameObject.Find("Player").GetComponent<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerHealth.health -= damage;
            _healthUtility.Hurt();
        }
    }
}
