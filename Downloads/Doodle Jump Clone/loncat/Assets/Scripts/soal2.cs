using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class soal2 : MonoBehaviour
{
    // Start is called before the first frame update
    public TextAsset soal, soale, kunci1, kunci2, kunci3, kunci4, kunci5, kunci6, kunci7, kunci8, kunci9, kunci10;
    public Text score, soalText, panelTextJawaban, panelGameScore, scoreFinish;
    public int nomor, i = 0, pointSoal = 0, scores = 0, life = 3;
    private bool salah = false, benar = false;
    public GameObject panelNext, life3, life2, life1, panelFinish, objBenar, objSalah;
    public string stringku, kj;
    public string[] words, wordsle;
    void Start()
    {
        wordsle = soale.text.Split(';');
        words = soal.text.Split(';');
    }

    // Update is called once per frame
    void Update()
    {
        panelGameScore.text = "Score : " + scores;
        scoreFinish.text = "Score : " + scores;
        if (life == 2)
        {
            life3.SetActive(false);
        }
        if (life == 1)
        {
            life2.SetActive(false);
        }
        if (life == 0)
        {
            life1.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
        if (nomor == 0)
        {
            kj = kunci1.text;
        }
        else if (nomor == 1)
        {
            kj = kunci2.text;
        }
        else if (nomor == 2)
        {
            kj = kunci3.text;
        }
        else if (nomor == 3)
        {
            kj = kunci4.text;
        }
        else if (nomor == 4)
        {
            kj = kunci5.text;
        }
        else if (nomor == 5)
        {
            kj = kunci6.text;
        }
        else if (nomor == 6)
        {
            kj = kunci7.text;
        }
        else if (nomor == 7)
        {
            kj = kunci8.text;
        }
        else if (nomor == 8)
        {
            kj = kunci9.text;
        }
        else if (nomor == 9)
        {
            kj = kunci10.text;
        }
        // print(kj.Length);
        soalText.text = "Unsur " + words[nomor].ToString() + " memiliki nomor atom " + wordsle[nomor].ToString() + ". Tentukan elektron valensi dari unsur tersebut.";
        panelTextJawaban.text = kj;
        if (salah)
        {
            panelNext.SetActive(true);
        }
        if (pointSoal == kj.Length)
        {
            panelNext.SetActive(true);
        }
        score.text = "Score : " + scores;
    }

    public void nextSoal()
    {
        if (life > 0)
        {
            nomor++;
            panelNext.SetActive(false);
            benar = false;
            salah = false;
            pointSoal = 0;
            panelTextJawaban.text = "";
            objBenar.SetActive(false);
            objSalah.SetActive(false);
            i = 0;
        }
        else
        {
            panelFinish.SetActive(true);
        }
    }

    public void finish()
    {
        SceneManager.LoadScene(0);
    }

    public void inputJawban1(string jawabanku)
    {
        if (kj == jawabanku)
        {
            scores++;
            panelNext.SetActive(true);
            benar = true;
            objBenar.SetActive(true);
        }
        else
        {
            salah = true;
            life--;
            objSalah.SetActive(true);
        }
    }
}
