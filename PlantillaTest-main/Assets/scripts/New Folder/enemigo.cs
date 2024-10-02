using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public Transform jugador;  // Referencia al jugador
    public float velocidad = 3f;  // Velocidad del enemigo al moverse
    public float distanciaAtaque = 1.5f;  // Distancia mínima para atacar
    public float daño = 10f;  // Daño que el enemigo hace al jugador
    public float tiempoEntreAtaques = 2f;  // Tiempo entre ataques
    private float siguienteAtaqueTiempo = 0f;  // Tiempo del próximo ataque

    public float salud = 100f;  // Salud del enemigo

    void Update()
    {
        // Seguir al jugador
        SeguirJugador();

        // Comprobar si el enemigo está cerca del jugador para atacar
        float distanciaAlJugador = Vector3.Distance(transform.position, jugador.position);
        if (distanciaAlJugador <= distanciaAtaque && Time.time >= siguienteAtaqueTiempo)
        {
            AtacarJugador();
        }
    }

    void SeguirJugador()
    {
        // El enemigo se mueve hacia el jugador
        Vector3 direccion = (jugador.position - transform.position).normalized;
        transform.position += direccion * velocidad * Time.deltaTime;
        transform.LookAt(jugador);  // El enemigo siempre mira al jugador
    }

    void AtacarJugador()
    {
        // Daño al jugador
        Jugador jugadorScript = jugador.GetComponent<Jugador>();
        if (jugadorScript != null)
        {
            jugadorScript.RecibirDaño(daño);
        }

        // Actualiza el tiempo del próximo ataque
        siguienteAtaqueTiempo = Time.time + tiempoEntreAtaques;
    }

    public void RecibirDaño(float cantidad)
    {
        salud -= cantidad;
        Debug.Log("El enemigo ha recibido " + cantidad + " de daño. Salud restante: " + salud);

        if (salud <= 0f)
        {
            Morir();
        }
    }

    void Morir()
    {
        Debug.Log("El enemigo ha muerto.");
        Destroy(gameObject);  // Destruir el enemigo
    }
}

public class Jugador : MonoBehaviour
{
    public float salud = 100f;  // Salud del jugador

    public void RecibirDaño(float cantidad)
    {
        salud -= cantidad;
        Debug.Log("El jugador ha recibido " + cantidad + " de daño. Salud restante: " + salud);

        if (salud <= 0f)
        {
            Morir();
        }
    }

    void Morir()
    {
        Debug.Log("El jugador ha muerto.");
        // Puedes añadir efectos o reiniciar el nivel si lo deseas
    }
}
