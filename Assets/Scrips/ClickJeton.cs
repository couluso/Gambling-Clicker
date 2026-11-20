using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ClickJeton : MonoBehaviour
{
    [Header("Jetons")]
    public int jetons = 0;
    public float productivite = 0f;
    public List<ClickJeton> chips = new List<ClickJeton>();

    [Header("Références")]
    [SerializeField]
    private TextMeshProUGUI compteur;
    [SerializeField]
    private TextMeshProUGUI prod;


    private void Start()
    {

    }

    private void Update()
    {
        compteur.text = "" + jetons;
        prod.text = "Par seconde : " + productivite;

        UpdateState();

    }

    private void OnMouseDown()
    {
        JetonClick();
    }

    public void JetonClick()
    {
        jetons += 1;
    }

    private void UpdateState()
    {
        bool shown = false;

        if (shown == false)
        {
            if (jetons >= 0)
            {
                Instantiate(chips[0], transform.position, Quaternion.identity);
                shown = true;
            }
            else if (jetons > 1000)
            {
                Instantiate(chips[1], transform.position, Quaternion.identity);
                shown = true;
            }
            else if (jetons > 5000)
            {
                Instantiate(chips[2], transform.position, Quaternion.identity);
                shown = true;
            }
            else if (jetons > 50000)
            {
                Instantiate(chips[3], transform.position, Quaternion.identity);
                shown = true;
            }
        }
    }
}
