using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DestroyBox : MonoBehaviour
{
    bool box = false;
    bool enemy = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Caja")
        {
            box = true;
            Debug.Log("box true.");
        }
        if (other.tag == "Enemy")
        {
            enemy = true;
            Debug.Log("enemy true.");
        }
        if (other.tag == "Win")
        {
            SceneManager.LoadScene("Win");
        }
    }

    void Update()
	{
        if (Input.GetKeyDown(KeyCode.A) && box == true)
        {
            Destroy(GameObject.FindWithTag("Caja"));
            Debug.Log("A key was pressed.");
            box = false;
        }
        if (Input.GetKeyDown(KeyCode.A) && enemy == true)
        {
            Destroy(GameObject.FindWithTag("Enemy"));
            Debug.Log("A key was pressed.");

        }
    }
}
