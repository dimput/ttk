using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class introScript : MonoBehaviour
{
    public GameObject text1, text2;
    private int x = 0;
    // Start is called before the first frame update
    void Start()
    {
        Screen.orientation = ScreenOrientation.Portrait;
    }
    public void next()
    {
        if (x == 1)
        {
            nextScene(1);
        }
        else
        {
            text2.SetActive(true);
            text1.SetActive(false);
            x++;
        }
    }

    public void nextScene(int x)
    {
        SceneManager.LoadScene(x);
    }
}
