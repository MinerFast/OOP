using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : Enemy // INHERITANCE
{
  
    void Start()
    {
        speed = 2f;
    }
    void Update()
    {
        Move();
    }
 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
            Damage(20);
            Destroy(gameObject);
        }
        
    }
    public override void DeathWords()
    {
        Debug.Log("Enemy2 say"); // POLYMORPHISM
    }


}
