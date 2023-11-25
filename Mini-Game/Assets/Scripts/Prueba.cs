using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JuegoConHoras : MonoBehaviour
{
    private bool juegoPausado = false;
    private bool juegoGanado = false;
    private int horaObjetivo = 12;  // Hora objetivo, puedes cambiarla según tus necesidades

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
                // Aquí puedes agregar lógica para la verificación de la hora.
                int horaActual = ObtenerHoraActual();  // Implementa esta función según tus necesidades

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
        // Aquí puedes agregar lógica adicional de pausa, como desactivar controles, mostrar un menú de pausa, etc.
    }

    void ReanudarJuego()
    {
        Time.timeScale = 1f; // Reanudar el tiempo del juego
        // Aquí puedes agregar lógica adicional para reanudar, como volver a activar controles, ocultar el menú de pausa, etc.
    }

    void GanarJuego()
    {
        juegoGanado = true;
        Debug.Log("¡Ganaste!");
        // Aquí puedes agregar lógica adicional para manejar la victoria, como mostrar un mensaje de victoria, cargar un nuevo nivel, etc.
    }

    int ObtenerHoraActual()
    {
        // Implementa la lógica para obtener la hora actual.
        // Esto podría implicar el uso de System.DateTime.Now.Hour o algún otro método dependiendo de tus necesidades.
        // Aquí, de manera simplificada, se retorna siempre la hora actual como 12 para propósitos de ejemplo.
        return 12;
    }
}

