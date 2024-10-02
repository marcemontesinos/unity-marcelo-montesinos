using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    // Método que se llama cuando hay una colisión
    private void OnTriggerEnter(Collider other)
    {
        // Verificar si el objeto que colisionó es el jugador
        if (other.CompareTag("Player"))
        {
            // Llamar al método de muerte del jugador
            PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();
            if (playerHealth != null)
            {
                playerHealth.MatarJugador(); // Método que maneja la muerte del jugador
            }
        }
    }
}