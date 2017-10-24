using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	public float maxhealth = 100;
	public float currentHealth;

	public Material sphereMat;
	public Image healthbar;

	// Use this for initialization
	void Start () {
		currentHealth = maxhealth;
	}
	
	// Update is called once per frame
	void Update () {
		healthbar.fillAmount = ((currentHealth - 0) * (1 - 0)) / ((maxhealth - 0) + 0);

	}

	public void AddHealth()
	{
		currentHealth += 10;
	}

	public void RemoveHealth()
	{
		currentHealth -= 10;
	}

	public void ChangeColor()
	{
		sphereMat.color = Random.ColorHSV ();
	}
}