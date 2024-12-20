using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using System.Collections;
using Unity.VisualScripting;


public class ButtonResizer : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private RectTransform rectTransform;
    private Vector3 originalScale;
    private Vector3 enlargedScale;
    public TextMeshProUGUI monTextUI;
    //banane
    public TextMeshProUGUI bananePrixUI;
    public TextMeshProUGUI bananeUI;
    public long BananeTotal = 0;
    public long bananePrix = 20;
    public long bananeAuto;
    public long banane = 1; // Ajuster cette valeur si nécessaire
    public Button bananeToClick;
    //poire
    public TextMeshProUGUI poirePrixUI;
    public TextMeshProUGUI poireUI;
    public long poireTotal = 0;
    public long poirePrix = 100;
    public long poireAuto;
    public long poire = 1; // Ajuster cette valeur si nécessaire
    public Button poireToClick;

    //melon
    public TextMeshProUGUI melonPrixUI;
    public TextMeshProUGUI melonUI;
    public long melonTotal = 0;
    public long melonPrix = 1000;
    public long melonAuto;
    public long melon = 1; // Ajuster cette valeur si nécessaire
    public Button melonToClick;

    //cerise
    public TextMeshProUGUI cerisePrixUI;
    public TextMeshProUGUI ceriseUI;
    public long ceriseTotal = 1;
    public long cerisePrix = 10000;
    public long cerise = 1;
    public Button ceriseToClick;
       

    public float Money;
    public float TotalMoney = 0;

    public Button buttonToClick;

    [SerializeField]
    private float scaleFactor = 1.1f;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        originalScale = rectTransform.localScale;
        enlargedScale = originalScale * scaleFactor;

    }
   


    private void Start()
    {
        Money = TotalMoney;
        UpdateUI();

        if (buttonToClick != null)
        {
            buttonToClick.onClick.AddListener(AddMoney);
        }

        if (bananeToClick != null)
        {
            bananeToClick.onClick.AddListener(CallBanane);
        }
        if (poireToClick != null)
        {
            poireToClick.onClick.AddListener(CallPoire);
        }
        if (melonToClick != null)
        {
            melonToClick.onClick.AddListener(CallMelon);
        }
        if (ceriseToClick != null)
        {
            ceriseToClick.onClick.AddListener(CallCerise);
        }

        StartCoroutine(BananeCouroutine());
        StartCoroutine(PoireCouroutine());
        StartCoroutine(melonCouroutine());
    }

    private void UpdateUI()
    {
        if (monTextUI != null)
            monTextUI.text = Money.ToString("0 $");

        if (bananeUI != null)
            bananeUI.text = BananeTotal.ToString("0");

        bananePrixUI.text = bananePrix.ToString("0 $");

        if (poireUI != null)
            poireUI.text = poireTotal.ToString("0");

        poirePrixUI.text = poirePrix.ToString("0 $");

        if (melonUI != null)
            melonUI.text = melonTotal.ToString("0");

        melonPrixUI.text = melonPrix.ToString("0 $");

        if (ceriseUI != null)
            ceriseUI.text = ceriseTotal.ToString("multiplicateur : x 0");

        cerisePrixUI.text = cerisePrix.ToString("0 $");

    }

    public void CallBanane()
    {
        if (Money >= bananePrix)
        {
            Money -= bananePrix;
            bananePrix = bananePrix + 5;
            BananeTotal += banane;
            UpdateUI();
            Debug.Log("Banane achetée!");
        }
        else
        {
            Debug.Log("Pas assez d'argent pour acheter une banane.");
        }
    }
    public void CallPoire()
    {
        if (Money >= poirePrix)
        {
            Money -= poirePrix;
            poirePrix = poirePrix + 50;
            poireTotal += poire;
            UpdateUI();
            Debug.Log("poire achetée!");
        }
        else
        {
            Debug.Log("Pas assez d'argent pour acheter une poire.");
        }
    }

    public void CallMelon()
    {
        if (Money >= melonPrix)
        {
            Money -= melonPrix;
            melonPrix = melonPrix + 500;
            melonTotal += melon;
            UpdateUI();
            Debug.Log("melon achetée!");
        }
        else
        {
            Debug.Log("Pas assez d'argent pour acheter un melon.");
        }
    }

    public void CallCerise()
    {
        if (Money >= cerisePrix)
        {
            Money -= cerisePrix;
            cerisePrix *= 10;
            ceriseTotal *=2;
            UpdateUI();
            Debug.Log("Cerise Acheté");
        }
        else
        {
            Debug.Log("Pas assez d'argent pour acheter une cerise.");
        }
    }

    IEnumerator BananeCouroutine()
    {
        while (true)
        {
            Money += BananeTotal*ceriseTotal;
            UpdateUI() ;

            yield return new WaitForSeconds(1);
        }
    }
    IEnumerator PoireCouroutine()
    {
        while (true)
        {
            Money += poireTotal*ceriseTotal;
            UpdateUI();

            yield return new WaitForSeconds(0.1f);
        }
    }
 

    IEnumerator melonCouroutine()
    {
        while (true)
        {   
            Money += melonTotal * ceriseTotal;
            UpdateUI();

            yield return new WaitForSeconds(0.01f);
        }
    }

    private void OnDestroy()
    {
        if (buttonToClick != null)
        {
            buttonToClick.onClick.RemoveListener(AddMoney);
        }

        if (bananeToClick != null)
        {
            bananeToClick.onClick.RemoveListener(CallBanane);
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        rectTransform.localScale = enlargedScale;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        rectTransform.localScale = originalScale;
    }

    private void AddMoney()
    {
        Money++;
        UpdateUI();
    }

    
}
