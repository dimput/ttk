using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeButtonColor : MonoBehaviour
{
    private Color color = Color.white;
    // Start is called before the first frame update
    public void changeColor(){
        color.a = 0.25f;
        gameObject.GetComponent<Renderer> ().material.color = color;
    }
    public void changeColorAgain(){
        gameObject.GetComponent<Renderer> ().material.color = Color.white;
    }
}
