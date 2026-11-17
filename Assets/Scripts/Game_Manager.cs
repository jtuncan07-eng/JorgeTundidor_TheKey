using TMPro;
using UnityEngine;

public class Game_Manager : MonoBehaviour
{
    public string text;
    public int coins = 0;
    public TextMeshProUGUI marc;

    public void Update()
    {
        text = "Monokuma coins= " + coins;
        marc.text = text;
    }
}
