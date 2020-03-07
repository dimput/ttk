using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public int soaleke;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if( other.gameObject.name == "emoji"){
            // Text my_text = GameObject.Find("Middleground/Coins/Canvas/score").GetComponent<Text>();
            // print ("kena");
            Destroy(this.gameObject);
            // SFXManager.Instance.PlayCoinSFX();
            GlobalScript.Instance.score += 1;
            Time.timeScale = 0;
            GlobalScript.Instance.soalke = soaleke;
            GlobalScript.Instance.panelQuiz.SetActive(true);

        }        
    }
}
