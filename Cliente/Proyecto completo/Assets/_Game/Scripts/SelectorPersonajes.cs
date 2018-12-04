using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectorPersonajes : MonoBehaviour {
	public GameObject[] personajes;
	public Text 		txtNombres;
	public string[]		nombres;

	public void CambiarPersonaje (float cual)
	{
		for(int i = 0; i<personajes.Length; i++)
		{
			personajes[i].SetActive(i==Mathf.FloorToInt(cual));
		}
		txtNombres.text = nombres[Mathf.FloorToInt(cual)];
	}
}
