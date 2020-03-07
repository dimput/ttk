using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ButtonInput : MonoBehaviour
{
    public static ButtonInput Instance;
    public string jawaban, atom1, atom2;
    public int jumlahAtom1 = 1, jumlahAtom2 = 1;

    public Text jumlah1, jumlah2, a1, a2;
    public GameObject jum1, jum2;
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        a1.text = atom1;
        a2.text = atom2;
        jumlah1.text = jumlahAtom1.ToString();
        jumlah2.text = jumlahAtom2.ToString();
        if (jumlahAtom1 > 1)
        {
            jum1.SetActive(true);
        }
        else
        {
            jum1.SetActive(false);
        }
        if (jumlahAtom2 > 1)
        {
            jum2.SetActive(true);
        }
        else
        {
            jum2.SetActive(false);
        }
        
    }
    public void inputJawban1(Text jawabanku)
    {
        if (atom1.Length == 0)
        {
            atom1 = jawabanku.text;
            jawaban += jawabanku.text;

        }
        else if (jawabanku.text == atom1)
        {
            jumlahAtom1++;
            jawaban += jawabanku.text;
        }
        else if (atom2.Length == 0)
        {
            atom2 = jawabanku.text;
            jawaban += jawabanku.text;
        }
        else if (jawabanku.text == atom2)
        {
            jumlahAtom2++;
            jawaban += jawabanku.text;
        }
        else
        {
            if (jawabanku.text == atom1)
            {
                jumlahAtom1++;
            }
            else if (jawabanku.text == atom1)
            {
                jumlahAtom2++;

            }
        }
    }

    public void clear()
    {
        jawaban = "";
        atom1 = "";
        atom2 = "";
        jumlahAtom2 = 1;
        jumlahAtom1 = 1;
    }
}
