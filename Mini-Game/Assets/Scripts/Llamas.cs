using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Llamas : MonoBehaviour
{
    public Sprite[] sprites; // Arreglo que contiene los sprites de la secuencia
    public float speed = 1.0f; // Velocidad del movimiento
    private SpriteRenderer spriteRenderer;
    private int i = 0;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = sprites[i];
    }

    private void Update()
    {
        // Actualiza el sprite en función del tiempo y la velocidad
        float tiempo = Time.time * speed;
        i = (int)tiempo % sprites.Length;
        spriteRenderer.sprite = sprites[i];
    }
}
