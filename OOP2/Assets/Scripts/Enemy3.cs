using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3 : Enemy // INHERITANCE
{   
    
    void Start()
    {
       
        speed = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
            Damage(90);
            Destroy(gameObject);
        }

    }
    public override void DeathWords()
    {
        Debug.Log("Enemy3 say"); // POLYMORPHISM
    }
}
