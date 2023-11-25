using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PausaJuego : MonoBehaviour
{
    private bool juegoPausado = false;
    [SerializeField] private GameObject screenPause;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Cambiar el estado de pausa al presionar la tecla "ESC"
            juegoPausado = !juegoPausado;

            if (juegoPausado)
            {
                PausarJuego();
            }
            else
            {
                ReanudarJuego();
            }
        }
    }

    void PausarJuego()
    {
        Time.timeScale = 0f; // Detener el tiempo del juego
        screenPause.SetActive(true);
        
    }

    void ReanudarJuego()
    {
        Time.timeScale = 1f; // Reanudar el tiempo del juego 
        screenPause.SetActive(false);
        
    }

    public void ReloadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}

