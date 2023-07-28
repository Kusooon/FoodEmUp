using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour
{
    [SerializeField] private SlotItem slotItem;
    [SerializeField] private TextMeshProUGUI text;

    public void setItem(Basket.IngredientCount ingredient)
    {
        if (setItemActive(ingredient.ID != IngredientEnum.None))
        {
            slotItem.setImage(ingredient.ID);
            text.text = ingredient.count.ToString();
        }
        
      
    }

    public bool setItemActive(bool checker)
    {
        slotItem.gameObject.SetActive(checker);
        text.gameObject.SetActive(checker);

        return checker;
    }



}
