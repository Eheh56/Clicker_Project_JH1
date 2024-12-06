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

    public float Money;
    public float TotalMoney = 0;

    public int BananeTotal =0;
    public int banane = 0;
    public Button bananeToClick;
    // Bouton à cliquer pour augmenter l'argent
    public Button buttonToClick;

    // Facteur d'agrandissement (10% de plus)
    [SerializeField]
    private float scaleFactor = 1.1f;
    public void CallBanane()
    {
        if (Money >= 20)
        {
            Money -= 20;
            print("banane");
            BananeTotal = BananeTotal + banane;
            BananeTotal++;
            bananeUI.text = BananeTotal.ToString("0");
        }
    }

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        originalScale = rectTransform.localScale;
        enlargedScale = originalScale * scaleFactor;
    }

    private void Start()
    {
        Money = TotalMoney;

        // Ajouter un listener pour l'événement OnClick du bouton
        if (buttonToClick != null)
        {
            buttonToClick.onClick.AddListener(AddMoney);
        }
    }
    void Update()
    {
        if (buttonToClick != null && Money >= 20)
        {
            CallBanane();
            print("oui");
        }
        if (buttonToClick != null && Money < 20) {

            print("non");
        }
    }

    private void OnDestroy()
    {
        // Retirer le listener pour éviter les erreurs si l'objet est détruit
        if (buttonToClick != null)
        {
            buttonToClick.onClick.RemoveListener(AddMoney);
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        rectTransform.localScale = enlargedScale; // Augmente la taille
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        rectTransform.localScale = originalScale; // Retourne à la taille originale
    }

    // Méthode pour ajouter de l'argent
    private void AddMoney()
    {
        Money++;
        monTextUI.text = Money.ToString("0");
    }
}
