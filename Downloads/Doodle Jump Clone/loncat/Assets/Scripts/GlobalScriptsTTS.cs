using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GlobalScriptsTTS : MonoBehaviour
{
    [Header("1 Mendatar")]
    public Text char1_1;
    public Text char1_2;
    public Text char1_3;
    public Text char1_4;
    public Text char1_5;
    public Text char1_6;
    public Text char1_7;
    public Text char1_8;
    public Text char1_9;
    public Text char1_10;

    [Header("1 Menurun")]
    public Text char2_1;
    public Text char2_2;
    public Text char2_3;
    public Text char2_4;
    public Text char2_5;
    public Text char2_6;
    public Text char2_7;

    [Header("2 Menurun")]
    public Text char22_1;
    public Text char22_2;
    public Text char22_3;
    public Text char22_4;
    public Text char22_5;
    public Text char22_6;
    public Text char22_7;
    public Text char22_8;

    [Header("3 Menurun")]
    public Text char3_1;
    public Text char3_2;
    public Text char3_3;
    [Header("4 Menurun")]
    public Text char4_1;
    public Text char4_2;
    public Text char4_3;
    public Text char4_4;
    public Text char4_5;
    public Text char4_6;

    [Header("5 mendatar")]
    public Text char5_1_1;
    public Text char5_1_2;
    public Text char5_1_3;
    public Text char5_1_4;
    public Text char5_1_5;
    public Text char5_1_6;
    public Text char5_1_7;
    public Text char5_1_8;
    public Text char5_1_9;
    public Text char5_1_10;
    public Text char5_1_11;

    [Header("5 menurun")]
    public Text char5_2_1;
    public Text char5_2_2;
    public Text char5_2_3;
    public Text char5_2_4;
    public Text char5_2_5;
    public Text char5_2_6;
    public Text char5_2_7;

    [Header("6 mendatar")]
    public Text char6_1;
    public Text char6_2;
    public Text char6_3;
    public Text char6_4;
    public Text char6_5;

[Header("lainnya")]
public Text isiform,textScore,textScoreFinish,textLife;
    public string x, kj;
    public GameObject panelSoal, objBenar, objSalah, panelSubmit,panelFinish;
    public string soalke;
    public int score,life=3;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        textLife.text = "x "+life;
        textScore.text = "Score : "+score;
        textScoreFinish.text = "Score : "+score;
        if(score==8 || life==0){
            panelFinish.SetActive(true);
        }
        if (soalke == "1 mendatar")
        {
            x = "KOORDINASI";
        }
        if (soalke == "1 menurun")
        {
            x = "KOVALEN";
        }
        if (soalke == "3 menurun")
        {
            x = "ION";
        }
        if (soalke == "2 menurun")
        {
            x = "NONPOLAR";
        }
        if (soalke == "4 menurun")
        {
            x = "LINEAR";
        }
        if (soalke == "5 mendatar")
        {
            x = "TETRAHEDRAL";
        }
        if (soalke == "5 menurun")
        {
            x = "TUNGGAL";
        }
        if (soalke == "6 mendatar")
        {
            x = "POLAR";
        }
        if (x == kj)
        {
            if (soalke == "1 mendatar")
            {
                char1_1.text = x[1 - 1].ToString();
                char1_2.text = x[2 - 1].ToString();
                char1_3.text = x[3 - 1].ToString();
                char1_4.text = x[4 - 1].ToString();
                char1_5.text = x[5 - 1].ToString();
                char1_6.text = x[6 - 1].ToString();
                char1_7.text = x[7 - 1].ToString();
                char1_8.text = x[8 - 1].ToString();
                char1_9.text = x[9 - 1].ToString();
                char1_10.text = x[10 - 1].ToString();
            }
            if (soalke == "1 menurun")
            {
                char2_1.text = x[1 - 1].ToString();
                char2_2.text = x[2 - 1].ToString();
                char2_3.text = x[3 - 1].ToString();
                char2_4.text = x[4 - 1].ToString();
                char2_5.text = x[5 - 1].ToString();
                char2_6.text = x[6 - 1].ToString();
                char2_7.text = x[7 - 1].ToString();
            }
            if (soalke == "2 menurun")
            {
                char22_1.text = x[1 - 1].ToString();
                char22_2.text = x[2 - 1].ToString();
                char22_3.text = x[3 - 1].ToString();
                char22_4.text = x[4 - 1].ToString();
                char22_5.text = x[5 - 1].ToString();
                char22_6.text = x[6 - 1].ToString();
                char22_7.text = x[7 - 1].ToString();
                char22_8.text = x[8 - 1].ToString();
            }
            if (soalke == "3 menurun")
            {
                char3_1.text = x[1 - 1].ToString();
                char3_2.text = x[2 - 1].ToString();
                char3_3.text = x[3 - 1].ToString();
            }
            if (soalke == "4 menurun")
            {
                char4_1.text = x[1 - 1].ToString();
                char4_2.text = x[2 - 1].ToString();
                char4_3.text = x[3 - 1].ToString();
                char4_4.text = x[4 - 1].ToString();
                char4_5.text = x[5 - 1].ToString();
                char4_6.text = x[6 - 1].ToString();
            }
            if (soalke == "5 mendatar")
            {
                char5_1_1.text = x[1 - 1].ToString();
                char5_1_2.text = x[2 - 1].ToString();
                char5_1_3.text = x[3 - 1].ToString();
                char5_1_4.text = x[4 - 1].ToString();
                char5_1_5.text = x[5 - 1].ToString();
                char5_1_6.text = x[6 - 1].ToString();
                char5_1_7.text = x[7 - 1].ToString();
                char5_1_8.text = x[8 - 1].ToString();
                char5_1_9.text = x[9 - 1].ToString();
                char5_1_10.text = x[10 - 1].ToString();
                char5_1_11.text = x[11 - 1].ToString();
            }
            if (soalke == "5 menurun")
            {
                char5_2_1.text = x[1 - 1].ToString();
                char5_2_2.text = x[2 - 1].ToString();
                char5_2_3.text = x[3 - 1].ToString();
                char5_2_4.text = x[4 - 1].ToString();
                char5_2_5.text = x[5 - 1].ToString();
                char5_2_6.text = x[6 - 1].ToString();
                char5_2_7.text = x[7 - 1].ToString();
            }
            if (soalke == "6 mendatar")
            {
                char6_1.text = x[1 - 1].ToString();
                char6_2.text = x[2 - 1].ToString();
                char6_3.text = x[3 - 1].ToString();
                char6_4.text = x[4 - 1].ToString();
                char6_5.text = x[5 - 1].ToString();
            }
        }
    }
    public void handleSubmit(Text dimas)
    {
        print(soalke);
        kj = dimas.text.ToUpper();
        panelSoal.SetActive(false);
        panelSubmit.SetActive(true);
        isiform.text = "";
        if (kj == x)
        {
            objBenar.SetActive(true);
            score++;
        }
        else
        {
            objSalah.SetActive(true);
            life--;
        }
    }

    public void showPanel(string ke)
    {
        soalke = ke;
        isiform.text="";
        panelSoal.SetActive(true);
    }
    public void hidePanelSubmit()
    {
        panelSubmit.SetActive(false);
        objBenar.SetActive(false);
        objSalah.SetActive(false);
    }
    
    public void finish(){
        SceneManager.LoadScene(0);
    }
}
