using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class ButtonResizer : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private RectTransform rectTransform;
    private Vector3 originalScale;
    private Vector3 enlargedScale;
    public TextMeshProUGUI monTextUI;
    public TextMeshProUGUI bananeUI;
    public TextMeshProUGUI bananePrixUI;
    public TextMeshProUGUI poirePrixUI;
    public TextMeshProUGUI cacaPrixUI;

    public float Money;
    public float TotalMoney = 0;

    public int BananeTotal = 0;
    public int bananePrix = 20;
    public int banane = 1; // Ajuster cette valeur si nécessaire
    public Button bananeToClick;
    public Button buttonToClick;
    public int bananeAuto;

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
    }

    private void UpdateUI()
    {
        if (monTextUI != null)
            monTextUI.text = Money.ToString("0");

        if (bananeUI != null)
            bananeUI.text = BananeTotal.ToString("0");

        bananePrixUI.text = bananePrix.ToString("0 $");
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
