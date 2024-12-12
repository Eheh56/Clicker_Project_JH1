using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public int Pomme;
    public int Banane;
    public int dollars;
    public int bananaPrice;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MaCoroutine());

    }

    public void AddBanane()
    {
        if (dollars >= bananaPrice)
        {
            dollars -= bananaPrice;
            bananaPrice += 5;
            Banane += 1;
        }
    }

    IEnumerator MaCoroutine()
    {
        while (true)
        {

            dollars += Banane;

            yield return new WaitForSeconds(1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
