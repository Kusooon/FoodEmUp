using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class SlotItem : MonoBehaviour
{
    //public Item item;

    public Image image;
    [SerializeField] private List<GameObject> sprites = new List<GameObject>();


    public void setImage(IngredientEnum ID)
    {
        image.sprite = sprites[(int)ID - 1].GetComponent<SpriteRenderer>().sprite;
    }
    
}
