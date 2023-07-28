using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class DishType : ScriptableObject
{

    public List<Basket.IngredientCount> requiredIngredients = new List<Basket.IngredientCount>();
    public Sprite dishSprite;

}
