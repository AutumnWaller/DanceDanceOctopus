using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Bars : MonoBehaviour
{

    float fuelTimer = 3.0f;
    public Slider healthSlider, fuelSlider;

    static float health = 20, fuel = 20;

    public static void ChangeFuel(float amount){
        fuel += amount;
    }

    public static void ChangeHealth(int amount){
        fuel += amount;
    }
    public static void GetFuelCan(){
        ChangeFuel(10);
    }

    public static void GetWoodBoard(){
        ChangeHealth(10);
    }

    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
    {
        ChangeFuel(-(Time.deltaTime * 0.75f));
        healthSlider.value = health / 100;
        fuelSlider.value = fuel / 100;
    }


}
