using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour
{
    public Animator Canvas;
    public GameObject canvasOBJ;

    private void Start()
    {
        StartCoroutine(GameEnd());
    }
    private void Awake()
    {
        Canvas = canvasOBJ.GetComponent<Animator>();
    }

    IEnumerator GameEnd()
    {
        yield return new WaitForSeconds(16);
        Canvas.SetBool("Fade", true);
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("Home");
    }



}
