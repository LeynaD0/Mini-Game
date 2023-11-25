using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    [SerializeField] private AudioSource[] musicAudioSouce;
    public static AudioController instance { get; private set; }

    private int musicIndex = 0;

    [SerializeField] private GameObject winSound, music;

    private void Awake()
    {
        if(instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
            
        }
    }

    private void Start()
    {
        music.SetActive(false);
        musicAudioSouce[musicIndex].Play();
    }

    public void PlaySounds()
    {
        music.SetActive(true);
    }

    public void TutorialMusic()
    {
        musicAudioSouce[musicIndex].Stop();
        musicIndex = (musicIndex + 1) % musicAudioSouce.Length;
        musicAudioSouce[musicIndex].Play();
    }

    public void EnterOptionsMusic()
    {
        musicAudioSouce[musicIndex].Stop();
        musicIndex = (musicIndex + 2) % musicAudioSouce.Length;
        musicAudioSouce[musicIndex].Play();
    }
    public void ExitOptionsMusic()
    {
        musicAudioSouce[musicIndex].Stop();
        musicIndex = (musicIndex - 2) % musicAudioSouce.Length;
        musicAudioSouce[musicIndex].Play();
    }

    public void WinSound()
    {
        winSound.SetActive(true);
        music.SetActive(false);
    }

    public void LostSound()
    {
        musicAudioSouce[musicIndex + 1].Play();
    }
}
