using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killzone : MonoBehaviour
{
  private void OnCollisionEnter(Collision collision)
  {
    GameObject ObjetoColisionado = collision.gameObject;
    if (ObjetoColisionado.GetComponent<Jugador>() != null)
    {
      ObjetoColisionado.GetComponent<Jugador>().ReiniciarJugador();
    }
  }
}
