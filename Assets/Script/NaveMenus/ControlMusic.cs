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
    [SerializeField] private TextMeshProUGUI sliderText = null;
    [SerializeField] private float maxSliderAmount = 100.0f;

    public void sliderUpdate(float value)
    {
        float localValue = value * maxSliderAmount;
        sliderText.text = localValue.ToString("0%");
    }

    public void ControlGeneralVol()
    {
        float general = volGeneral.value;
        audioMixer.SetFloat("General", general);

        /*
        volMusic.value = general;
        volSFX.value = general;

        audioMixer.SetFloat("V_Music", general);
        audioMixer.SetFloat("V_SFX", general);
        */

        PlayerPrefs.SetFloat("VolGeneral", general);
        /*
        PlayerPrefs.SetFloat("VolMusic", general);
        PlayerPrefs.SetFloat("VolSFX", general);
        */
    }

    public void ControlMusicVol()
    {
        float  vmusic = volMusic.value;
        audioMixer.SetFloat("V_Music", vmusic);

        PlayerPrefs.SetFloat("VolMusic", vmusic);
    }
    public void ControlSFXVol()
    {
        float vsfx = volSFX.value;
        audioMixer.SetFloat("V_SFX", vsfx);

        PlayerPrefs.SetFloat("VolSFX", vsfx);
    }

    private void Start()
    {
        volGeneral.value = PlayerPrefs.GetFloat("VolGeneral", -40f);
        volMusic.value = PlayerPrefs.GetFloat("VolMusic", -40f);
        volSFX.value = PlayerPrefs.GetFloat("VolSFX", -40f);

        audioMixer.SetFloat("General", volGeneral.value);
        audioMixer.SetFloat("V_Music", volMusic.value);
        audioMixer.SetFloat("V_SFX", volSFX.value);
    }
}

