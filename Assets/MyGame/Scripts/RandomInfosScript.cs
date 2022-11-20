using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomInfosScript : MonoBehaviour
{
    private System.Random rdm = new System.Random();
    private int sysRDM;
    private int unityRDM;
    private float rdmValue;
    private Color rdmColor;
    [SerializeField] private GameObject rdmRotationObj;
    
    private void Start()
    {
        sysRDM = rdm.Next(100);
        unityRDM = Random.Range(0, 100);

        rdmColor = Random.ColorHSV(); //Gibt zuf�llige Farbe aus dem HSV Farbraum aus
        rdmRotationObj.transform.rotation = Random.rotation; //Rotiert das gegebene Object zuf�llig

        for (int i = 0; i <= 10; i++)
        {
            Random.seed = 14; //Setzt den Seed auf 14 (zur�ck)
            rdmValue = Random.value; //Gibt einen Zuf�lligen float Wert zwischen 0 und 1 aus
            Debug.Log(rdmValue);
        }
    }
}
