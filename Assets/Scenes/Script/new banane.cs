using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine;
using Unity.VisualScripting;

public class newbanane : MonoBehaviour
{
    public int BananeTotal;
    public int  banane = 1;
    public TextMeshProUGUI monTextUI;
    public int TotalMoney;
    public Button buttonToClick;
    public TextMeshProUGUI money;
    public void CallBanane()
    {
        if ( TotalMoney >= 20)
        {
            TotalMoney -= 20;
            print("banane");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        BananeTotal = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (buttonToClick != null  && TotalMoney >= 20)
        {
            BananeTotal = 0;
        }
    }
}
