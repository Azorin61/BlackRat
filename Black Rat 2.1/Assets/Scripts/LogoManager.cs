using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogoManager : MonoBehaviour
{
    public float delay = 440;
    void Start()
    {
       
        StartCoroutine(LoadMenu(delay));
    }
    private void Update()
    {
        if (Input.anyKey)
        {
            SceneManager.LoadScene("TitleScene");
        }
    }
    IEnumerator LoadMenu(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene("TitleScene");
    }
}