using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JuegoConHoras : MonoBehaviour
{
    private bool juegoPausado = false;
    private bool juegoGanado = false;
    private int horaObjetivo = 12;  // Hora objetivo, puedes cambiarla seg�n tus necesidades

    void Update()
    {
        if (!juegoGanado)  // Evita que se realicen acciones si el juego ya ha sido ganado
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

            if (!juegoPausado)
            {
                // Aqu� puedes agregar l�gica para la verificaci�n de la hora.
                int horaActual = ObtenerHoraActual();  // Implementa esta funci�n seg�n tus necesidades

                if (horaActual == horaObjetivo)
                {
                    GanarJuego();
                }
            }
        }
    }

    void PausarJuego()
    {
        Time.timeScale = 0f; // Detener el tiempo del juego
        // Aqu� puedes agregar l�gica adicional de pausa, como desactivar controles, mostrar un men� de pausa, etc.
    }

    void ReanudarJuego()
    {
        Time.timeScale = 1f; // Reanudar el tiempo del juego
        // Aqu� puedes agregar l�gica adicional para reanudar, como volver a activar controles, ocultar el men� de pausa, etc.
    }

    void GanarJuego()
    {
        juegoGanado = true;
        Debug.Log("�Ganaste!");
        // Aqu� puedes agregar l�gica adicional para manejar la victoria, como mostrar un mensaje de victoria, cargar un nuevo nivel, etc.
    }

    int ObtenerHoraActual()
    {
        // Implementa la l�gica para obtener la hora actual.
        // Esto podr�a implicar el uso de System.DateTime.Now.Hour o alg�n otro m�todo dependiendo de tus necesidades.
        // Aqu�, de manera simplificada, se retorna siempre la hora actual como 12 para prop�sitos de ejemplo.
        return 12;
    }
}

