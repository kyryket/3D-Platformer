using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    public int jump = 3;
    void OnTriggerEnter(Collider other)
    {
      other.GetComponent<Jump>().jumpStrength *= jump;
    }
    void OnTriggerExit(Collider other)
    {
      other.GetComponent<Jump>().jumpStrength /= jump;
    }
}
