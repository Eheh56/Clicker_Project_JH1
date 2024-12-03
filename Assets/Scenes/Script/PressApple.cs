using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using System.Collections;
using System.Collections.Generic;

public class ButtonResizer : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private RectTransform rectTransform;
    private Vector3 originalScale;
    private Vector3 enlargedScale;
    public TextMeshProUGUI monTextUI;

    public float Money;
    public float TotalMoney = 0;

    // Facteur d'agrandissement (10% de plus)
    [SerializeField]
    private float scaleFactor = 1.1f;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        originalScale = rectTransform.localScale;
        enlargedScale = originalScale * scaleFactor;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        rectTransform.localScale = enlargedScale; // Augmente la taille
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        rectTransform.localScale = originalScale; // Retourne à la taille originale
    }
    void Start()
    {
        Money = TotalMoney;


    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            Money++;
        }
        monTextUI.text = Money.ToString("0");
    }
}