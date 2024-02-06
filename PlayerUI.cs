using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class PlayerUI : MonoBehaviour
{
    public CoinsCounter player;
	public Health player1;
	public TextMeshProUGUI coinsCounterText;
	public Slider healthSlider;
    
    void Update()
	{
		healthSlider.maxValue = player1.maxHealth;
		healthSlider.value = player1.health;
		
		coinsCounterText.text = player.coins.ToString();
	}

}
