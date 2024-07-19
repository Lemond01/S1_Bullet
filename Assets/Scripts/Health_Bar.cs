using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health_Bar : MonoBehaviour
{
    private Slider slider;

    private void Awake()
    {
        slider = GetComponent<Slider>();
    }

    public void ChangeMaxHealth(float maxHealth)
    {
        if (slider == null)
        {
            slider = GetComponent<Slider>();
        }
        slider.maxValue = maxHealth;
    }

    public void ChangeCurHealth(float quaHealth)
    {
        if (slider == null)
        {
            slider = GetComponent<Slider>();
        }
        slider.value = quaHealth;
    }

    public void InitialHealthBar(float quaHealth)
    {
        ChangeMaxHealth(quaHealth);
        ChangeCurHealth(quaHealth);
    }

}

