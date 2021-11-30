using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : GameBehaviour
{
    public int health;
    private int currentHealth;
    public int moneyWorth;

    private Rigidbody rb;
    public float moveSpeed;
    

    public PlayerController thePlayer;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        thePlayer = FindObjectOfType<PlayerController>();
        currentHealth = health;
    }

    void Update()
    {
        transform.LookAt(thePlayer.transform.position);
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    void FixedUpdate()
    {
        rb.velocity = (transform.forward * moveSpeed);
    }

    public void HurtEnemy(int _Damage)
    {
        currentHealth -= _Damage;
        if (health <= 0)
        {
            _GM.AddScore(moneyWorth);
            Destroy(this);
            
        }
    }
 

}
