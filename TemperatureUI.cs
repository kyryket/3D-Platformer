using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TemperatureUI : MonoBehaviour
{
    public Temperature playerTemperature;
    public TextMeshProUGUI temperatureText;
    void Update()
    {
        UpdateTemperatureUI();
    }

    void UpdateTemperatureUI()
    {
        if (playerTemperature != null && temperatureText != null)
        {
            float roundedTemperature = Mathf.Round(playerTemperature.temperatureCurrent * 10.0f) * 0.1f;

            temperatureText.text = roundedTemperature.ToString();
        }
    }
}
