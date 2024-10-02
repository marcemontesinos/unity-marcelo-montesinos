using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public float daño = 10f;  // Cantidad de daño que inflige la bala

    void OnCollisionEnter(Collision colision)
    {
        // Verificar si la bala colisiona con un enemigo
        Enemigo enemigo = colision.gameObject.GetComponent<Enemigo>();
        if (enemigo != null)
        {
            // El enemigo recibe daño
            enemigo.RecibirDaño(daño);
        }

        // Destruir la bala después de impactar
        Destroy(gameObject);
    }
}
