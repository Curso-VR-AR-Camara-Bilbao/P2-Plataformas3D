using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PropiedadesUI : MonoBehaviour
{
  public TextMeshProUGUI txtVida;

  public TextMeshProUGUI txtMonedas;

  private void Update()
  {
    txtVida.text = Jugador.Instance.Vida.ToString();
    txtMonedas.text = Jugador.Instance.Monedas.ToString();
  }
}
