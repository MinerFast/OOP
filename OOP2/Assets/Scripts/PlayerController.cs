using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public TextMeshProUGUI hpText;
    private float speed = 10f;
    public static int hp = 100;
    public static int Hp //ENCAPSULATION
    {
        get { return hp; }
        set
        {
            if (value > 0)
            {
                hp = value;
            }
            else
            {
                Debug.LogError("Health dropped below 0");
            }
        }
    }

    void Update()
    {
        hpText.SetText("HP:" + hp);
        Move();

    }
    Vector2 ForMove()
    {
        float horizontal = Input.GetAxis("Horizontal");
        return new Vector2(transform.position.x + horizontal * speed * Time.deltaTime, transform.position.y);
    }
    private void Move()
    {
        //ABSTRACTION
        transform.position = ForMove();
    }

}
