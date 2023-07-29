using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class DishSpawner : MonoBehaviour
{
    [SerializeField] private List<DishType> dishes = new List<DishType>();

    private DishType currentDish = null;
    private int randomDishID;
    private Vector2 SpawnPosition = new Vector2();

    [SerializeField] private List<Slot> slots = new List<Slot>();
    [SerializeField] private TextMeshProUGUI text;

    [SerializeField] private SpriteRenderer thought;

    

    void Awake()
    {
        randomDish();
    }
    public void randomDish()
    {
        if (currentDish == null)
        {
            currentDish = dishes[Random.Range(0, dishes.Count)];
            setDish();
        }
    }

    public void checkBasket()
    {
        Basket basket = FindObjectOfType<Basket>().GetComponent<Basket>();
        if (basket.CanCook(currentDish.requiredIngredients))
        {
            basket.ClearBasket();
            currentDish = null;
            randomDish();

        }
        else if (basket.IsFull())
        {
            Debug.Log("Game Over");
        }
        
    }



    public void setDish()//pierre thought bubble
    {
        text.text = currentDish.name.ToString();
        for (int i = 0; i < slots.Count; i++)
        {
            bool inUse = i < currentDish.requiredIngredients.Count;
            slots[i].gameObject.SetActive(inUse);
            if (inUse )
            {
                slots[i].setItem(currentDish.requiredIngredients[i]);
                
            }
        }
        thought.sprite = currentDish.dishSprite;
    }


    void Update()
    {
        checkBasket();
    }


}
