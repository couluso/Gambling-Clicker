using System;
using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class SlotBuy : MonoBehaviour
{

    public GameObject layer;
    public ClickJeton chip;

    public int price;
    public bool buyable;
    public int tick;
    public int value;
    public int number;
    public int exponantiel;
    public int prixPlus;
    public float prod;

    [Tooltip("Chance de donner un jeton sur 100")]
    public int odds = 33;



    // Update is called once per frame
    void Update()
    {
        CheckBuyable();
    }

    private void OnMouseDown()
    {
        if (buyable == true)
        {
            Buy();
        }
    }


    private void CheckBuyable()
    {
        if (chip.jetons >= price)
        {
            layer.SetActive(false);
            buyable = true;
        }
        else
        {
            layer.SetActive(true);
            buyable = false;
        }
    }

    private void Buy()
    {
        chip.jetons -= price;
        chip.productivite += prod;

        exponantiel *= prixPlus;
        price += exponantiel;

        number++;
        StartTime(tick, odds);
    }

    public void StartTime(float tick, int odds)
    {
        StartCoroutine(Timer(tick, odds));
    }

    IEnumerator Timer(float tick, int odds)
    {
        while (true)
        {
            yield return new WaitForSeconds(tick);

            for (int i = 0; i < number; i++)
            {
                if (Random.Range(0f, 100f) < odds)
                {
                    chip.jetons += value;
                }
            }
        }
    }

}
