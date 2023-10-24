using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.Timeline;

public class Reloj : MonoBehaviour
{
    [SerializeField]
    public TextMeshProUGUI hora;
    [SerializeField]
    public TextMeshProUGUI reloj_Texto;

    [SerializeField]
    float speed_reloj;
    float minutos;
    [SerializeField]
    float contraReloj;

    [SerializeField]
    GameObject hour_hand, minutes_hand;

    float horas;
    int hour;
    int minutes;

    bool jugando;
     
    void Start()
    {
        //Al empezar el juego, este dara un tiempo aletorio para definir la hora que tenemos que poner
        horas = Random.Range(1, 12);
        minutos = Random.Range(0, 59);
        reloj_Texto.text = horas.ToString() + ":" + minutos.ToString("00");

        hour = Random.Range(1, 12);
        minutes = Random.Range(1, 59);

        hora.text = hour.ToString() + ":" + minutes.ToString("00");

        Debug.Log("Son las: " + hour + " y " + minutes);

        Debug.Log(horas + ":" + minutos);

        jugando = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(jugando == true)
        {
            SumarHoras();

            RestarHoras();
        }

        if(horas > 12)
        {
            horas = 1;
        }

        else if (horas < 1)
        {
            horas = 12;
        }

        reloj_Texto.text = horas.ToString() + ":" + minutos.ToString("00");

        if(horas == hour && minutos == minutes)
        {
            Debug.Log("You win");
            Comprobacion();
            jugando = false;
        }

        //Debug.Log(horas + " " + minutos);
    }

    void SumarHoras()
    {
        if (Input.GetKey(KeyCode.E))
        {
            minutos += speed_reloj;
            //Debug.Log("ha sido presionado");

            if (minutos > 59)
            {
                minutos = 0;
                horas++;
            }

            if (minutos < 0)
            {
                minutos = 59;
                horas--;
            }
        }
    }

    void RestarHoras()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            minutos -= speed_reloj;
            //Debug.Log("ha sido presionado");

            if (minutos > 59)
            {
                minutos = 0;
                horas++;
            }


            if (minutos < 0)
            {
                minutos = 59;
                horas--;
            }
        }
    }

    void Comprobacion()
    {
        if(horas == hour && minutos == minutes)
        {
            horas = hour;
            minutos = minutes;
        }
    }
}
