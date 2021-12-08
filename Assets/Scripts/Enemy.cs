using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : GameBehaviour
{
    public float maxHealth;
    private float health = 100;
    public float currentHealth;
    public float healthMultiplier;

    public int moneyWorth;

    private Rigidbody rb;
    public float moveSpeed;

    public PlayerController thePlayer;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        thePlayer = FindObjectOfType<PlayerController>();
        maxHealth = health * (_GM.waveCount * healthMultiplier);
        currentHealth = maxHealth;
    }

    void Update()
    {
        transform.LookAt(thePlayer.transform.position);

    }

    void FixedUpdate()
    {
        rb.velocity = (transform.forward * moveSpeed);
    }

    public void HurtEnemy(int _Damage)
    {
        currentHealth -= _Damage;
        if (currentHealth <= 0)
        {
            Debug.Log("enemy died");
            _GM.AddScore(moneyWorth);
            _EM.DestroyEnemy(this.gameObject);
            
            
        }
    }
 

}
