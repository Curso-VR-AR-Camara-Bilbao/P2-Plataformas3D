using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DetectorCantidadMonedas : MonoBehaviour
{
  public TextMeshPro Texto;

  public int NumeroMonedas;

  private void Start()
  {
    Texto.text = "¿Tienes " + NumeroMonedas + " monedas?";
  }

  private void OnCollisionEnter(Collision collision)
  {
    GameObject ObjetoColisionado = collision.gameObject;
    if (ObjetoColisionado.GetComponent<Jugador>() != null)
    {
      if (ObjetoColisionado.GetComponent<Jugador>().Monedas >= NumeroMonedas)
      {
        Texto.text = "¡Has conseguido todas las monedas!";
      }
    }
  }
}
