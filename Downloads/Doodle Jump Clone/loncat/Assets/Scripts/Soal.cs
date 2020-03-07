using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Soal : MonoBehaviour
{
    // Start is called before the first frame update
    public TextAsset soal, kunci1, kunci2, kunci3, kunci4, kunci5, kunci6, kunci7, kunci8, kunci9, kunci10;
    public Text score, soalText, no1, no2, no3, no4, no5, no6, panelTextJawaban, panelScore,panelScoreFinish;
    public int nomor, i = 0, pointSoal = 0, scores = 0,life=3;
    private bool salah = false;
    public GameObject panelNext, objSalah, objBenar,panelFinish,life3,life2,life1;
    public string string1, string2, string3, string4, string5, string6;
    public string[] words, kj;
    void Start()
    {
        words = soal.text.Split(';');
        print(words.Length);
    }

    // Update is called once per frame
    void Update()
    {
        if(life==2){
            life3.SetActive(false);
        }
        if(life==1){
            life2.SetActive(false);
        }
        if(life==0){
            life1.SetActive(false);
        }
        panelScore.text = "Score : " + scores;
        panelScoreFinish.text = "Score : "+scores;
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
        if (nomor == 0)
        {
            kj = kunci1.text.Split(';');
        }
        else if (nomor == 1)
        {
            kj = kunci2.text.Split(',');
        }
        else if (nomor == 2)
        {
            kj = kunci3.text.Split(',');
        }
        else if (nomor == 3)
        {
            kj = kunci4.text.Split(',');
        }
        else if (nomor == 4)
        {
            kj = kunci5.text.Split(',');
        }
        else if (nomor == 5)
        {
            kj = kunci6.text.Split(',');
        }
        else if (nomor == 6)
        {
            kj = kunci7.text.Split(',');
        }
        else if (nomor == 7)
        {
            kj = kunci8.text.Split(',');
        }
        else if (nomor == 8)
        {
            kj = kunci9.text.Split(',');
        }
        else if (nomor == 9)
        {
            kj = kunci10.text.Split(',');
        }
        // print(kj.Length);
        no1.text = string1;
        no2.text = string2;
        no3.text = string3;
        no4.text = string4;
        no5.text = string5;
        no6.text = string6;
        soalText.text = words[nomor].ToString();
        if (i < kj.Length)
        {
            panelTextJawaban.text += kj[i];
            if (i != kj.Length - 1)
            {
                panelTextJawaban.text += ", ";
            }
            i++;
        }
        if (salah)
        {
            panelNext.SetActive(true);
            objSalah.SetActive(true);
        }
        if (pointSoal == kj.Length)
        {
            objBenar.SetActive(true);
            panelNext.SetActive(true);
        }
        score.text = "Score : " + scores;
    }

    public void finish(){
        SceneManager.LoadScene(0);
    }
    public void nextSoal()
    {
        if (nomor < words.Length-1  && life>0)
        {
            nomor++;
            panelNext.SetActive(false);
            objSalah.SetActive(false);
            objBenar.SetActive(false);
            salah = false;
            pointSoal = 0;
            string1 = "";
            string2 = "";
            string3 = "";
            string4 = "";
            string5 = "";
            string6 = "";
            panelTextJawaban.text = "";
            i = 0;
        }
        else{
            panelFinish.SetActive(true);
        }
    }

    public void inputJawban1(string jawabanku)
    {
        if (string1.Length == 0)
        {
            string1 = jawabanku;
            if (jawabanku != kj[0])
            {
                salah = true;
                life--;
                print("disini");
            }
            else
            {
                pointSoal++;
                scores++;
            }
        }
        else if (string2.Length == 0)
        {
            string2 = jawabanku;
            if (jawabanku != kj[1])
            {
                salah = true;
                life--;
            }
            else
            {
                pointSoal++;
                scores++;
            }
        }
        else if (string3.Length == 0)
        {
            string3 = jawabanku;
            if (jawabanku != kj[2])
            {
                salah = true;
                life--;
            }
            else
            {
                pointSoal++;
                scores++;
            }
        }
        else if (string4.Length == 0)
        {
            string4 = jawabanku;
            if (jawabanku != kj[3])
            {
                salah = true;
                life--;
            }
            else
            {
                pointSoal++;
                scores++;
            }
        }
        else if (string5.Length == 0)
        {
            string5 = jawabanku;
            if (jawabanku != kj[4])
            {
                salah = true;
                life--;
            }
            else
            {
                pointSoal++;
                scores++;
            }
        }
        else if (string6.Length == 0)
        {
            string6 = jawabanku;
            if (jawabanku != kj[5])
            {
                salah = true;
                life--;
            }
            else
            {
                pointSoal++;
                scores++;
            }
        }
    }
}
