using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacmanScriptsGlobal : MonoBehaviour
{

    public GameObject panelSoal;
    public int nomor;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 0)
        {
            panelSoal.SetActive(true);
        }
    }

    public void hidePanel(){
        nomor++;
        Time.timeScale=1;
        panelSoal.SetActive(false);
    }
}
