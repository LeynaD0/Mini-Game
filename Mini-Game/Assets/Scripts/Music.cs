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
    Slider music;
    [SerializeField]
    GameObject audio;
    // Start is called before the first frame update
    void Start()
    {
        percentage.text = music.value.ToString("0") + "%";
    }

    // Update is called once per frame
    void Update()
    {
        percentage.text = music.value.ToString("0") + "%";
    }
}
