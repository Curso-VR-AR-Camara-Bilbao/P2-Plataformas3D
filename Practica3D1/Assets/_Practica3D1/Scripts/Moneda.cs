using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneda : MonoBehaviour
{
  public int ValorMoneda;

  private void OnCollisionEnter(Collision collision)
  {
    GameObject ObjetoColisionado = collision.gameObject;
    if (ObjetoColisionado.GetComponent<Jugador>()) {
      //Al ser Jugador un singleton puedo hacerlo de dos formas
      //ObjetoColisionado.GetComponent<Jugador>().Monedas += ValorMoneda;
      Jugador.Instance.Monedas += ValorMoneda;
      Destroy(gameObject);
    }
  }
}
