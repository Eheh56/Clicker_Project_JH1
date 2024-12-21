using UnityEngine;

[CreateAssetMenu(fileName = "NewTrophy", menuName = "Game/Trophy")]
public class Trophy : ScriptableObject
{
    public long price = 560000000000; // Le prix du troph�e
    public Color trophyColor = Color.black; // Couleur du troph�e (noir par d�faut)
    public Sprite image;

    // M�thode pour acheter le troph�e
    public void BuyTrophy()
    {
        trophyColor = Color.white; // Changer la couleur du troph�e � blanc
    }
}