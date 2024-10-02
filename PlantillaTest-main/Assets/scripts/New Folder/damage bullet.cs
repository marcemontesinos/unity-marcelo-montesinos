using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public float da�o = 10f;  // Cantidad de da�o que inflige la bala

    void OnCollisionEnter(Collision colision)
    {
        // Verificar si la bala colisiona con un enemigo
        Enemigo enemigo = colision.gameObject.GetComponent<Enemigo>();
        if (enemigo != null)
        {
            // El enemigo recibe da�o
            enemigo.RecibirDa�o(da�o);
        }

        // Destruir la bala despu�s de impactar
        Destroy(gameObject);
    }
}
