using UnityEngine;

public class CanvasToggler : MonoBehaviour
{
    public GameObject canvasTrophe; // R�f�rence au Canvas Troph�

    public void Start()
    {
        canvasTrophe.SetActive(false);
    }
    // Active le Canvas Troph�
    public void ShowTrophe()
    {
        canvasTrophe.SetActive(true);
    }

    // D�sactive le Canvas Troph�
    public void HideTrophe()
    {
        canvasTrophe.SetActive(false);
    }
}