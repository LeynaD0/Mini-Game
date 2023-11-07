using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.Timeline;
using Palmmedia.ReportGenerator.Core.Reporting.Builders;
using UnityEngine.UI;

public class Reloj : MonoBehaviour
{
    [SerializeField]
    public TextMeshProUGUI hora_Texto;
    [SerializeField]
    public TextMeshProUGUI reloj_Texto;
    [SerializeField]
    TextMeshProUGUI contrareloj_Texto;
    [SerializeField]
    private Slider contraRelojSlider;
    [SerializeField]
    Animator animador;

    [SerializeField]
    float speed_reloj;
    float minutos;
    [SerializeField]
    float contraReloj;
    [SerializeField]
    float timeSpeed;

    float horas;
    int hour;
    int minutes;
    int morning_afternoon;
    int am_pm;

    bool jugando;
    [SerializeField]
    bool am, pm;
     
    void Start()
    {
        //Al empezar el juego, este dara un tiempo aletorio para definir la hora que tenemos que poner
        horas = Random.Range(1, 12);
        minutos = Random.Range(0, 59);

        //morning_afternoon = Random.Range(1, 2);

        morning_afternoon = (Random.Range(0, 2) == 0) ? 1 : 2;


        if (Random.Range(0, 2) == 0)
        {
            am_pm = 1; // "am"
        }
        else
        {
            am_pm = 2; // "pm"
        }

        contrareloj_Texto.text = contraReloj.ToString();

        hour = Random.Range(1, 12);
        minutes = Random.Range(1, 59);

        AmOPmDespertardor();

        if (morning_afternoon <= 1)
        {
            hora_Texto.text = hour.ToString() + ":" + minutes.ToString("00") + " am";
            //Debug.Log("Son las " + hour.ToString() + ":" + minutes.ToString("00") + " am");
        }
        else if (morning_afternoon > 1)
        {
            hora_Texto.text = hour.ToString() + ":" + minutes.ToString("00") + " pm";
            //Debug.Log("Son las " + hour.ToString() + ":" + minutes.ToString("00") + " pm");
        }

        //Debug.Log(horas + ":" + minutos);

        jugando = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(jugando == true)
        {
            SumarHoras();

            RestarHoras();

            Contrareloj();
        }

        if(horas > 12)
        {
            horas = 1;
        }

        else if (horas < 1)
        {
            horas = 12;
        }

        contrareloj_Texto.text = contraReloj.ToString("0");

        if (morning_afternoon <= 1)
        {
            am = true;
            pm = false;
        }

        else
        {
            am = false;
            pm = true;
        }

        if (horas == hour && minutos == minutes && morning_afternoon == am_pm)
        {
            jugando = false;
            animador.SetTrigger("Despierto");
            horas = hour;
            minutos = minutes;
            am_pm = morning_afternoon;
            //Debug.Log("You win");
        }

        AmOPmDespertardor();

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

                if (horas > 12)
                {
                    horas = 1;
                    CambioDeHora();
                }
            }
        }
    }

    void RestarHoras()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            minutos -= speed_reloj;

            if (minutos < 0)
            {
                minutos = 59;
                horas--;

                if (horas < 1)
                {
                    horas = 12;
                    CambioDeHora();
                }
            }
        }
    }

    void Contrareloj()
    {
        contraReloj -= Time.deltaTime * timeSpeed;

        if(contraReloj < 0)
        {
            jugando = false;
            contraReloj = 0;
        }

        contraRelojSlider.value = contraReloj;
    }

    void AmOPmDespertardor()
    {
        if (am_pm <= 1)
        {
            reloj_Texto.text = horas.ToString() + ":" + minutos.ToString("00") + " am";
        }

        else
        {
            reloj_Texto.text = horas.ToString() + ":" + minutos.ToString("00") + " pm";
        }
    }

    void CambioDeHora()
    {
        if (am_pm == 1)
        {
            am_pm = 2;
        }

        else
        {
            am_pm = 1;
        }
    }
}
