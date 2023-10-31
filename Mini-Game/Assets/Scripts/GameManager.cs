using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public enum Estados
    {
        EnEspera,
        Jugando
    }

    [SerializeField]
    public Estados estadoActual;
    void Awake()
    {
        estadoActual = Estados.EnEspera;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
