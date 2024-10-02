using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    void Update()
    {
        // Verifica si la tecla "R" fue presionada
        if (Input.GetKeyDown(KeyCode.R))
        {
            RestartGame();
        }
    }

    void RestartGame()
    {
        // Obtiene el nombre de la escena actual
        string currentSceneName = SceneManager.GetActiveScene().name;

        // Carga de nuevo la escena actual
        SceneManager.LoadScene(currentSceneName);
    }
}