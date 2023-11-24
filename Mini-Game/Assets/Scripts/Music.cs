using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Music : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI percentage;
    [SerializeField]
    Slider musicSlider;
    // Start is called before the first frame update
    void Start()
    {
        LoadValue();
    }

    private void Update()
    {
        float volumeValue = musicSlider.value;
    }

    public void SliderVolume(float volume)
    {
        percentage.text = volume.ToString("0") + "%";
    }

    public void SaveVolumeButton()
    {
        float volumeValue = musicSlider.value;
        PlayerPrefs.SetFloat("VolumeValue", volumeValue);
        LoadValue();
    }

    void LoadValue()
    {
        float volumeValue = PlayerPrefs.GetFloat("VolumeValue");
        musicSlider.value = volumeValue;
        AudioListener.volume = volumeValue;
    }
}
