using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class Basket : MonoBehaviour
{

    [Serializable] public struct IngredientCount {public IngredientEnum ID; public int count; };
    [SerializeField]  public IngredientCount[] inventorySlots = new IngredientCount[6];

    [SerializeField] private List<Slot> slots = new List<Slot>();


   
    
    // Start is called before the first frame update
    

    void Start()
    {
        ClearBasket(); //set all items in basket to 0

        
    }


    public bool CanCook(List<IngredientCount> ingredientList)
    {
        int canCook = 0;

        foreach (IngredientCount ingredient in ingredientList)
        {
            
            for (int i = 0; i < inventorySlots.Length; i++)
            {
                if ((inventorySlots[i].ID == ingredient.ID) && (inventorySlots[i].count >= ingredient.count))
                {
                    canCook++;
                }
            }



        }


        return canCook == ingredientList.Count;
    }

    public bool IsFull()
    {
        bool isFull = false;
        int count = 0;

        for (int i = 0; i < inventorySlots.Length; i++)
        {
            
            if (inventorySlots[i].ID != IngredientEnum.None)
            {
                count++;
            }
        }

        return count == inventorySlots.Length;
    }


    public void addItemToBasket(IngredientEnum itemID)
    {
        for (int i = 0; i < inventorySlots.Length; i++)
        {
            if ((inventorySlots[i].ID == 0) || (inventorySlots[i].ID == itemID) )
            {
                inventorySlots[i].ID = itemID;
                inventorySlots[i].count++;
                break;

            }
        }
        updateSlot();


        

    }

    public void removeItemFromBasket(IngredientEnum itemID)
    {
        for (int i = 0; i < inventorySlots.Length; i++)
        {
            if (inventorySlots[i].ID == itemID)
            {
                inventorySlots[i].count--;
                if (inventorySlots[i].count == 0)
                {
                    inventorySlots[i].ID = IngredientEnum.None;
                }
                break;
                
            }
            
        }
        updateSlot();
    }

    public void ClearBasket()
    {
        for (int i = 0; i < inventorySlots.Length; i++)
        {
            inventorySlots[i].ID = IngredientEnum.None;
            inventorySlots[i].count = 0;
            
        }
        updateSlot();
    }


    public void updateSlot()
    {
        for (int i = 0; i < inventorySlots.Length; i++)
        {
            slots[i].setItem(inventorySlots[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    




}
