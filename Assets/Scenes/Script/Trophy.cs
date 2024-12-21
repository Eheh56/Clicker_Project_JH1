using UnityEngine;

[CreateAssetMenu(fileName = "NewTrophy", menuName = "Game/Trophy")]
public class Trophy : ScriptableObject
{
    public long price = 560000000000; // Le prix du trophée
    public Color trophyColor = Color.black; // Couleur du trophée (noir par défaut)
    public Sprite image;

    // Méthode pour acheter le trophée
    public void BuyTrophy()
    {
        trophyColor = Color.white; // Changer la couleur du trophée à blanc
    }
}