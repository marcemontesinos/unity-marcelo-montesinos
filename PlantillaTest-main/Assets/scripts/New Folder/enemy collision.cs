using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    // M�todo que se llama cuando hay una colisi�n
    private void OnTriggerEnter(Collider other)
    {
        // Verificar si el objeto que colision� es el jugador
        if (other.CompareTag("Player"))
        {
            // Llamar al m�todo de muerte del jugador
            PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();
            if (playerHealth != null)
            {
                playerHealth.MatarJugador(); // M�todo que maneja la muerte del jugador
            }
        }
    }
}