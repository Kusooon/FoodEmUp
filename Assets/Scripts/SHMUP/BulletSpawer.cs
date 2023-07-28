using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawer : MonoBehaviour
{
    [SerializeField] private Bullet _bulletPrefab;
    
    private bool heldSpace;
    private bool startScaling;
    [SerializeField] private float bulletSet = 0.25f;
    [SerializeField] private float bulletScale;
    private float scaleTimer;
    [SerializeField] private float bulletScaleRate = 0.005f;
    private float scaleDelay = 0.5f;
    private const float maxBulletScale = 3.0f;

    

    // Start is called before the first frame update
    void Start()
    {
        bulletScale = bulletSet;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        // Handle continuous bullet scaling while the Space key is held down
        if (heldSpace && startScaling)
        {
            bulletScale += bulletScaleRate;
            bulletScale = Mathf.Clamp(bulletScale, bulletSet, maxBulletScale * bulletSet); // Limit the bullet scale to the maximum value
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            heldSpace = true;
            startScaling = false;
            scaleTimer = 0f;
            
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            
            heldSpace = false;
            startScaling = false;
            scaleTimer = 0f;
            

            // Instantiate the bullet prefab when Space is released with the desired scale
            Bullet newBullet = Instantiate(_bulletPrefab, transform.position, transform.rotation);
            newBullet.transform.localScale = new Vector3(bulletScale, bulletScale, 1f);
            bulletScale = bulletSet; // Reset the bullet scale to its initial value
        }

        // Timer to delay bullet scaling until 0.5 seconds
        if (heldSpace && !startScaling)
        {
            scaleTimer += Time.deltaTime;
            if (scaleTimer >= scaleDelay)
            {
                startScaling = true;
            }
        }
    }
}