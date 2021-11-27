using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    public float speed;
   
    

    void Update()
    {
        Move();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
            Damage(10);
            Destroy(gameObject);
        }
    }
    public void Damage(int valueDamage)
    {
        PlayerController.Hp -= valueDamage;
    }
     public void Move()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
    public abstract void DeathWords();

}
