using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrophyScript : MonoBehaviour
{
    public GameObject Player;
    public GameObject WinScreen;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player)
        {
            WinScreen.SetActive(true);
        }
    }
}
