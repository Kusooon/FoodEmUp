using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class DishCounter : MonoBehaviour
{

    [SerializeField] private TMP_Text countTxt;
    [SerializeField] private int totalDishesNeeded;

    [SerializeField] public DishSpawner dishCount;

    [SerializeField] NextScene NextScene;
    [SerializeField] public string stringlol;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {   
        countTxt.text = $"{dishCount.totalDishesCompleted} / {totalDishesNeeded}";

        if (dishCount.totalDishesCompleted >= totalDishesNeeded) 
        {
            NextScene.btn_change_scene("Win");
        }
    }
}
