using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using TMPro;

public class ControlMusic : MonoBehaviour
{
    public Slider volGeneral, volMusic, volSFX;
    public AudioMixer audioMixer;
    public TextMeshProUGUI textGeneral, textMusic, textSFX;

    private float convertToPercent(float value)
    {
        return (value + 80) / 80 * 100;
    }

    private void UpdateSliderText(Slider slider, TextMeshProUGUI text)
    {
        float percent = convertToPercent(slider.value);
        text.text = Mathf.RoundToInt(percent).ToString() + "%";
    }

    public void ControlGeneralVol()
    {
        float general = volGeneral.value;
        audioMixer.SetFloat("General", general);
        PlayerPrefs.SetFloat("VolGeneral", general);
        UpdateSliderText(volGeneral, textGeneral); 
    }

    public void ControlMusicVol()
    {
        float vmusic = volMusic.value;
        audioMixer.SetFloat("V_Music", vmusic);
        PlayerPrefs.SetFloat("VolMusic", vmusic);
        UpdateSliderText(volMusic, textMusic); 
    }

    public void ControlSFXVol()
    {
        float vsfx = volSFX.value;
        audioMixer.SetFloat("V_SFX", vsfx);
        PlayerPrefs.SetFloat("VolSFX", vsfx);
        UpdateSliderText(volSFX, textSFX);
    }

    private void Start()
    {
        volGeneral.value = PlayerPrefs.GetFloat("VolGeneral", -40f);
        volMusic.value = PlayerPrefs.GetFloat("VolMusic", -40f);
        volSFX.value = PlayerPrefs.GetFloat("VolSFX", -40f);

        audioMixer.SetFloat("General", volGeneral.value);
        audioMixer.SetFloat("V_Music", volMusic.value);
        audioMixer.SetFloat("V_SFX", volSFX.value);

        UpdateSliderText(volGeneral, textGeneral);
        UpdateSliderText(volMusic, textMusic); 
        UpdateSliderText(volSFX, textSFX);
    }
}

