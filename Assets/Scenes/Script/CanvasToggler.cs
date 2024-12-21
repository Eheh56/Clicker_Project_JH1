using UnityEngine;

public class CanvasToggler : MonoBehaviour
{
    public GameObject canvasTrophe; // Référence au Canvas Trophé

    public void Start()
    {
        canvasTrophe.SetActive(false);
    }
    // Active le Canvas Trophé
    public void ShowTrophe()
    {
        canvasTrophe.SetActive(true);
    }

    // Désactive le Canvas Trophé
    public void HideTrophe()
    {
        canvasTrophe.SetActive(false);
    }
}