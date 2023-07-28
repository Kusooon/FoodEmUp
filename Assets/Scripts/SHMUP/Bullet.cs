using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

   /* [SerializeField] private int worth = 1;*/
    [SerializeField] private float bulletSpeed = 5f;
    private float bulletX;
    private float bulletY;
    



    private void Awake()
    {
        bulletX = transform.position.x;
        bulletY = transform.position.y;
    
    }


    private void FixedUpdate()
    {
        /*if (!GetComponent<Renderer>().isVisible)
        {
            // Destroy the bullet game object
            Destroy(gameObject);
        }*/

        transform.Translate(bulletSpeed * Time.deltaTime, 0, 0);

        if (transform.position.x > 9)
        {
            bulletDestroy();
        }
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the bullet collided with an object that has the Enemy script attached
        IngredientBehavior enemy = other.GetComponent<IngredientBehavior>();
        

        if (enemy != null)
        {
            GameObject.FindObjectOfType<Basket>().addItemToBasket(enemy.checkType());
            bulletDestroy();
            Debug.Log(enemy.checkType());
            enemy.enemyDestroy(); // Destroy the enemy

        }

        
    }

    public void bulletDestroy()
    {
        Destroy(gameObject);
    }



}
