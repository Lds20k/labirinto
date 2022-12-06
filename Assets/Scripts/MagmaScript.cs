using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MagmaScript : MonoBehaviour
{
    public GameObject Player;
    public GameObject LoseScreen;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player)
        {
            LoseScreen.SetActive(true);
        }
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
