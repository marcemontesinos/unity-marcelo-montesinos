using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoostItem : MonoBehaviour
{
    public float aumentoVelocidad = 2f;  // Factor de aumento de velocidad
    public float duracionAumento = 5f;    // Duraci�n del aumento de velocidad en segundos

    // Detecta si el jugador colisiona con el �tem
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))  // Verifica si es el jugador
        {
            PlayerMovements playerMovements = other.GetComponent<PlayerMovements>();

            if (playerMovements != null)
            {
                // Aumenta la velocidad del jugador
                StartCoroutine(AumentarVelocidad(playerMovements));

                // Destruir el �tem despu�s de recogerlo
                Destroy(gameObject);
            }
        }
    }

    // Coroutine que aumenta la velocidad temporalmente
    IEnumerator AumentarVelocidad(PlayerMovements playerMovements)
    {
        // Aumenta la velocidad
        playerMovements.Speed *= aumentoVelocidad;

        // Espera la duraci�n del aumento
        yield return new WaitForSeconds(duracionAumento);

        // Restaura la velocidad normal
        playerMovements.Speed /= aumentoVelocidad;
    }
}
