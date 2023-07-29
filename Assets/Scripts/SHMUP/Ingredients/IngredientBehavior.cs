using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientBehavior : MonoBehaviour
{
    [SerializeField] private float enemySpeed = 5f;
    [SerializeField] IngredientType type;


    private void FixedUpdate()
    {
        transform.Translate(enemySpeed * Time.deltaTime * -1, 0, 0);
        if (transform.position.x < -9)
        {
            checkTypeOnDestroy();
        }
        
    }
    public void enemyDestroy()
    {
        Destroy(gameObject);
    }

    public IngredientEnum checkType()
    {

        //add code to check type and send to basket
        
        return type.ID;
        
    }

    public void checkTypeOnDestroy()
    {
        checkType();
        enemyDestroy();
    }


}
