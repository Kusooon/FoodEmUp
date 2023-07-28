using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class DishInven : MonoBehaviour
{

    [Serializable] public struct IngredientCount { public IngredientEnum ID; public int count; };
    [SerializeField] public IngredientCount[] inventorySlots = new IngredientCount[5];

    [SerializeField] private List<Slot> slots = new List<Slot>();

        


    // Start is called before the first frame update


    void Start()
    {
        ClearDishInven(); //set all items in basket to 0


    }



    public void addItemToDishInven(IngredientEnum itemID)
    {
        for (int i = 0; i < inventorySlots.Length; i++)
        {
            if ((inventorySlots[i].ID == 0) || (inventorySlots[i].ID == itemID))
            {
                inventorySlots[i].ID = itemID;
                inventorySlots[i].count++;
                break;
            }
        }
        updateSlot();
    }

    public void removeItemFromDishInven(IngredientEnum itemID)
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

    public void ClearDishInven()
    {
        for (int i = 0; i < inventorySlots.Length; i++)
        {
            inventorySlots[i].ID = IngredientEnum.None;
            inventorySlots[i].count = 0;
        }
    }


    public void updateSlot()
    {
        for (int i = 0; i < inventorySlots.Length; i++)
        {
            
        }
    }

    // Update is called once per frame
    void Update()
    {

    }






}
