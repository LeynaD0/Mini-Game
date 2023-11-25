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

    private static Music _instance;

    public static Music Instance
    {
        get
        {
            if (_instance == null)
            {
                // Busca la instancia existente en la escena
                _instance = FindObjectOfType<Music>();

                // Si no existe, crea un nuevo objeto
                if (_instance == null)
                {
                    GameObject singletonObject = new GameObject("Music");
                    _instance = singletonObject.AddComponent<Music>();
                }

                // Marca el objeto para que no se destruya al cargar una nueva escena
                DontDestroyOnLoad(_instance.gameObject);
            }

            return _instance;
        }
    }
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
