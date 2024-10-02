using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Necesario para reiniciar la escena

public class PlayerHealth : MonoBehaviour
{
    public int vida = 100; // Vida inicial del jugador

    // Método para matar al jugador
    public void MatarJugador()
    {
        // Reducir la vida a 0
        vida = 0;

        // Mostrar un mensaje en la consola
        Debug.Log("¡El jugador ha muerto!");

        // Reiniciar la escena (puedes cambiar esto por otra lógica de Game Over si prefieres)
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}