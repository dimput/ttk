using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalScript : MonoBehaviour
{
    public static GlobalScript Instance;
    public Text scoreText;
    public Text scoreGameOvertext;
    public Text lifeText;
    public GameObject panelQuiz,panelGameOver,MonsterObject,objectToSpawn;
    public bool gameOver=false;
    // public Text life;
    public int score = 0,life=3,soalke;
    private float timer=2.7f,spawnPosY,spawnPosX;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.GetComponent<Text>().text = "Score : " + score;
        scoreGameOvertext.GetComponent<Text>().text = "x " + score;
        lifeText.GetComponent<Text>().text = "x " + life;
        if(life==0){
            gameOver=true;
            Time.timeScale=0;
            panelGameOver.SetActive(true);
        }
        // life.GetComponent<Text>().text = GlobalScript.Instance.life.ToString();
        
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                GameObject obj = Instantiate(objectToSpawn, this.transform);
                spawnPosY = MonsterObject.transform.position.y;
                spawnPosX = MonsterObject.transform.position.x;
                print(spawnPosX);
                obj.transform.position = new Vector3(spawnPosX, spawnPosY, 0);
                timer=2.7f;
            }
    }

    public void jawabanBenar(){
        score+=1;
        panelQuiz.SetActive(false);
        Time.timeScale=1;
    }
}
