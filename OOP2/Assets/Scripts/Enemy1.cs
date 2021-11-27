using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : Enemy // INHERITANCE
{
    void Start()
    {
        speed = 4f;
    }

    void Update()
    {
        Move();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
            Damage(5);
            Destroy(gameObject);
        }

    }
    public override void DeathWords()
    {
        Debug.Log("Enemy1 say"); // POLYMORPHISM
    }
}
