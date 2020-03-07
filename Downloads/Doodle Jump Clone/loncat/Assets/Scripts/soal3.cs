using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
public class soal3 : MonoBehaviour
{
    /// Start is called before the first frame update
    public TextAsset soal, soale, kunci1, kunci2, kunci3, kunci4, kunci5, kunci6, kunci7, kunci8, kunci9, kunci10, kunci1_1, kunci2_1, kunci3_1, kunci4_1, kunci5_1, kunci6_1, kunci7_1, kunci8_1, kunci9_1, kunci10_1;
    public Text score, soalText, soalbentuk;
    public Text pilihan1text, pilihan2text, pilihan3text, pilihan4text, textScoreGame, textLifeGame,textScoreFinish;
    public TextAsset pilihan1, pilihan2, pilihan3, pilihan4, pilihan5, pilihan6, pilihan7, pilihan8, pilihan9, pilihan10;
    public int nomor, i = 0, pointSoal = 0, scores = 0, life = 3;
    public bool salah = false, benar = false;

    public GameObject panelNext, panelgambar, panelnutupgambar, BenarObj, SalahObj,panelFinish;
    public string stringku;
    public string[] words, kj, wordsle, kj_1, pilihan;
    void Start()
    {
        wordsle = soale.text.Split(';');
        words = soal.text.Split(';');
    }

    // Update is called once per frame
    void Update()
    {
        textScoreFinish.text= "Score : "+scores;
        textLifeGame.text = "x " + life;
        textScoreGame.text = "Score : " + scores;
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
        if (nomor == 0)
        {
            kj = kunci1.text.Split(';');
            kj_1 = kunci1_1.text.Split(';');
            pilihan = pilihan1.text.Split(';');
        }
        else if (nomor == 1)
        {
            kj = kunci2.text.Split(';');
            kj_1 = kunci2_1.text.Split(';');
            pilihan = pilihan2.text.Split(';');
        }
        else if (nomor == 2)
        {
            kj = kunci3.text.Split(';');
            kj_1 = kunci3_1.text.Split(';');
            pilihan = pilihan3.text.Split(';');
        }
        else if (nomor == 3)
        {
            kj = kunci4.text.Split(';');
            kj_1 = kunci4_1.text.Split(';');
            pilihan = pilihan4.text.Split(';');
        }
        else if (nomor == 4)
        {
            kj = kunci5.text.Split(';');
            kj_1 = kunci5_1.text.Split(';');
            pilihan = pilihan5.text.Split(';');
        }
        else if (nomor == 5)
        {
            kj = kunci6.text.Split(';');
            kj_1 = kunci6_1.text.Split(';');
            pilihan = pilihan6.text.Split(';');
        }
        else if (nomor == 6)
        {
            kj = kunci7.text.Split(';');
            kj_1 = kunci7_1.text.Split(';');
            pilihan = pilihan7.text.Split(';');
        }
        else if (nomor == 7)
        {
            kj = kunci8.text.Split(';');
            kj_1 = kunci8_1.text.Split(';');
            pilihan = pilihan8.text.Split(';');
        }
        else if (nomor == 8)
        {
            kj = kunci9.text.Split(';');
            kj_1 = kunci9_1.text.Split(';');
            pilihan = pilihan9.text.Split(';');
        }
        else if (nomor == 9)
        {
            kj = kunci10.text.Split(';');
            kj_1 = kunci10_1.text.Split(';');
            pilihan = pilihan10.text.Split(';');
        }
        // print(kj.Length);
        soalbentuk.text = wordsle[nomor].ToString();
        soalText.text = "Buatlah rumus kimia " + words[nomor].ToString() + " dari pecahan senyawa berikut.";
        if (salah || benar)
        {
            panelNext.SetActive(true);
            panelnutupgambar.SetActive(false);
            panelgambar.SetActive(true);
        }
        score.text = "Score : " + scores;
        if (benar)
        {
            BenarObj.SetActive(true);
            SalahObj.SetActive(false);
        }
        if (salah)
        {
            BenarObj.SetActive(false);
            SalahObj.SetActive(true);
        }
        pilihan1text.text = pilihan[0];
        pilihan2text.text = pilihan[1];
        pilihan3text.text = pilihan[2];
        pilihan4text.text = pilihan[3];
    }

    public void nextSoal()
    {
        if (life > 0 && nomor <9)
        {
            nomor++;
            panelNext.SetActive(false);
            benar = false;
            salah = false;
            pointSoal = 0;
            i = 0;
            ButtonInput.Instance.clear();
            panelnutupgambar.SetActive(true);
            panelgambar.SetActive(false);
        }
        else {
            print("here");
            print(panelNext);
            panelFinish.SetActive(true);
        }
    }

    public void finish(){
        SceneManager.LoadScene(0);
    }

    public void submit()
    {
        if (ButtonInput.Instance.atom1 == kj[0])
        {
            if (ButtonInput.Instance.jumlahAtom1.ToString() == kj_1[0])
            {
                if (ButtonInput.Instance.atom2 == kj[1])
                {
                    if (ButtonInput.Instance.jumlahAtom2.ToString() == kj_1[1])
                    {
                        scores++;
                        benar = true;
                    }
                }
                else
                {
                    salah = true;
                    life--;
                }
            }
            else
            {
                salah = true;
                life--;
            }
        }
        else
        {
            salah = true;
            life--;
        }
    }
}
