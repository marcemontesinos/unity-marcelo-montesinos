using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Transform bulletSpawnPoint;  // Punto de origen de la bala
    public GameObject bulletPrefab;     // Prefab de la bala
    public float bulletSpeed = 10f;     // Velocidad de la bala

    // Update is called once per frame
    void Update()
    {
        // Verificar si se presiona la barra espaciadora
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Disparar();
        }
    }

    // Método para disparar la bala
    void Disparar()
    {
        // Crear la bala en el punto de disparo
        GameObject bala = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);

        // Agregar velocidad a la bala para que se mueva hacia adelante
        Rigidbody rb = bala.GetComponent<Rigidbody>();
        rb.velocity = bulletSpawnPoint.forward * bulletSpeed;
    }
}
