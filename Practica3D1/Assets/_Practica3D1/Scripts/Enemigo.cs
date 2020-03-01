using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
  public int Daño;

  private void OnCollisionEnter(Collision collision)
  {
    GameObject ObjetoColisionado = collision.gameObject;
    if (ObjetoColisionado.GetComponent<Jugador>()!=null)
    {
      ObjetoColisionado.GetComponent<Jugador>().RecibirDaño(Daño);
    }
  }
}
