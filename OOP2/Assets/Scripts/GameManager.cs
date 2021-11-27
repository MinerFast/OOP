using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void Death(Enemy enemy)
    {
        if (enemy != null)
        {
            enemy.DeathWords();
        }
    
    }
    void Update()
    {
        
    }
}
