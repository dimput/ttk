using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class FindWordScript : MonoBehaviour
{
    public Button[] dimas;
    public Button btn00, btn01, btn02;
    public Button btn10, btn11, btn12;
    public Button btn20, btn21, btn22;
    public Button history;
    public string jawab;


    // Start is called before the first frame update
    void Start()
    {
        dimas = new Button[8];
        dimas[0] = btn00;
        dimas[1] = btn01;
        dimas[2] = btn02;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void clickButton(Text input)
    {
        print("Clicked " + input.text);
        jawab += input.text;
    }

    public int findArray(Button input)
    {
        return System.Array.IndexOf(dimas, input);
    }

    public void clickButton2(Button input)
    {
        if (history == null)
        {
            history = input;
            input.interactable = false;
        }
        else
        {
            if (findArray(input) == findArray(history) + 1)
            {
                input.interactable = false;
                history=input;
            }
        }
    }
}
