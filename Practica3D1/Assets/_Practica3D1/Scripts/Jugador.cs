using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{

  public static Jugador Instance = null;

  public int Vida;

  public int Monedas;

  public Transform PuntoReinicio;

  private void Awake()
  {   
    if(Instance == null)
    {
      Instance = this;
    }
    else if (Instance != this)
    {
      Destroy(gameObject);
    }
  }
  // Start is called before the first frame update
  void Start()
  {
    Monedas = 0;
    ReiniciarJugador();
  }

  public void RecibirDaño(int Daño)
  {
    Vida -= Daño;

    if (Vida <= 0)
    {
      ReiniciarJugador();
    }
  }

  public void ReiniciarJugador()
  {
    Vida = 100;
    transform.position = PuntoReinicio.position;
  }
}
