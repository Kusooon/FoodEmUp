using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float enemySpeed = 5f;
    public string ingredientName;




    private void Awake()
    {
        Debug.Log(ingredientName);
    }

    private void FixedUpdate()
    {
        transform.Translate(enemySpeed * Time.deltaTime * -1, 0, 0);

        if (transform.position.x < -9)
        {
            enemyDestroy();
        }

    }

  

    public void enemyDestroy()
    {
        Destroy(gameObject);
    }
}
