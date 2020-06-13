using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalScripts : MonoBehaviour
{
    public static GlobalScripts Instance;

    public TextAsset txtSoal, txtJawaban;
    public InputField n;
    public Text pertanyaan, inputJawaban, timeText, scoreGameOver, leftText, textAnswer;
    public int soalke, countBenar, jumlahSoal, left = 3;
    private string[] jawaban;
    float timeLeft = 120.0f;

    public int[] guru;
    public GameObject[] gmbrJawaban;
    public bool panelActive;
    public string[] soal;

    public GameObject panelSoal, panelDone, panelGameOver, panelBefore, wrongAnswerText;
    public string minutess, secondss;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        Screen.orientation = ScreenOrientation.Portrait;
        soal = txtSoal.text.Split(';');
        jawaban = txtJawaban.text.Split(';');
        jumlahSoal = soal.Length;
        guru = new int[jumlahSoal];
        Time.timeScale = 0;
        panelActive = true;
    }

    // Update is called once per frame
    void Update()
    {
        pertanyaan.text = soal[soalke];
        scoreGameOver.text = "Correct : " + countBenar;
        leftText.text = "Left : " + left;

        if (timeLeft <= 0 || left <= 0)
        {
            panelGameOver.SetActive(true);
            panelSoal.SetActive(false);
            panelActive = true;
            Time.timeScale = 0;
        }
        if (countBenar == jumlahSoal)
        {
            PlayerPrefs.SetInt("LevelPassed", 1);
            panelDone.SetActive(true);
            panelActive = true;
        }

        timeLeft -= Time.deltaTime;
        // int menit = (int)timeLeft % 3600;
        // int detik = (int)timeLeft % 60;
        float minutes = Mathf.Floor(timeLeft / 60);
        float seconds = Mathf.RoundToInt(timeLeft % 60);

        if (minutes < 10)
        {
            minutess = "0" + minutes.ToString();
        }
        else
        {
            minutess = minutes.ToString();
        }
        if (seconds < 10)
        {
            secondss = "0" + Mathf.RoundToInt(seconds).ToString();
        }
        else
        {
            secondss = seconds.ToString();
        }
        timeText.text = minutess + ":" + secondss;
    }

    public void showPanel(int num)
    {
        panelSoal.SetActive(true);
        panelActive = true;
        soalke = num;
        inputJawaban.text = "";
    }

    public void closePanel()
    {
        panelActive = false;
        panelSoal.SetActive(false);
        n.text = "";
        wrongAnswerText.SetActive(false);
        textAnswer.color = Color.black;
        n.image.color = Color.white;
    }

    public void submit(Text dimas)
    {
        if (jawaban[soalke] == dimas.text.ToUpper())
        {
            gmbrJawaban[soalke].SetActive(true);
            n.text = "";
            guru[soalke] = 1;
            Debug.Log("benerrr");
            panelActive = false;
            panelSoal.SetActive(false);
        }
        else
        {
            Debug.Log("salah");
            left--;
            wrongAnswerText.SetActive(true);
            textAnswer.color = Color.white;
            n.image.color = Color.red;
        }
        countBenar = 0;
        for (int i = 0; i < jumlahSoal; i++)
        {
            countBenar += guru[i];
        }
    }

    public void next()
    {
        SceneManager.LoadScene(3);
    }
    public void mainMenu()
    {
        SceneManager.LoadScene(1);
    }
    public void start()
    {
        panelActive = false;
        Time.timeScale = 1;
        panelBefore.SetActive(false);
    }
}
