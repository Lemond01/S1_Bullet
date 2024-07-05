using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ControlVideo : MonoBehaviour
{
    public Button displayButton;
    public Slider brightnessSlider;
    public Image brightnessPanel;
    public TextMeshProUGUI brightnessText;

    public float sliderValue;

    void Start()
    {
        displayButton.onClick.AddListener(DisplayMode);

        brightnessSlider.value = PlayerPrefs.GetFloat("Brightness", 0.5f);
        brightnessPanel.color = new Color(brightnessPanel.color.r, brightnessPanel.color.g, brightnessPanel.color.b, brightnessSlider.value);

        UpdateSliderText(brightnessSlider, brightnessText);
    }

    private void UpdateSliderText(Slider slider, TextMeshProUGUI text)
    {
        float percent = (1f - slider.value / 0.9f) * 100f;
        text.text = Mathf.RoundToInt(percent).ToString() + "%";
    }

    public void BrigthnessSettings(float valor)
    {
        sliderValue = valor;
        PlayerPrefs.SetFloat("Brightness", sliderValue);
        brightnessPanel.color = new Color(brightnessPanel.color.r, brightnessPanel.color.g, brightnessPanel.color.b, sliderValue);

        UpdateSliderText(brightnessSlider, brightnessText);
    }

    public void DisplayMode()
    {
        if(Screen.fullScreen)
        {
            Screen.fullScreenMode = FullScreenMode.Windowed;
        }
        else 
        {
            Screen.fullScreenMode = FullScreenMode.FullScreenWindow;
        }
    }


}
