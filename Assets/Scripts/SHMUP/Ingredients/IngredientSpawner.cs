using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientSpawner : MonoBehaviour
{
    [SerializeField] private IngredientType[] _ingredientPrefab;

    [SerializeField] private Vector2 minPos;
    [SerializeField] private Vector2 maxPos;
    
    [SerializeField] private float enemyCooldown = 5f;
    private float baseEnemyCooldown;
    private int randomIngredientID;

    private Vector2 enemySpawnPosition = new Vector2();

    // Start is called before the first frame update
    void Start()
    {
        baseEnemyCooldown = enemyCooldown;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {


        if (enemyCooldown <= 0)
        {
            randomIngredientID = Random.Range(0, _ingredientPrefab.Length);
            enemySpawnPosition.x = Random.Range(minPos.x, maxPos.x) / 10;
            enemySpawnPosition.y = Random.Range(minPos.y, maxPos.y) / 10;

            enemyCooldown = baseEnemyCooldown;
            Instantiate(_ingredientPrefab[randomIngredientID], new Vector3(enemySpawnPosition.x, enemySpawnPosition.y, 0f), Quaternion.identity);
            
        }
        else
        {
            enemyCooldown -= Time.deltaTime;
        }
    }
}
