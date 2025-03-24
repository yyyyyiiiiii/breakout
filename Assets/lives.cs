using UnityEngine;
using TMPro;

public class lives : MonoBehaviour
{
    public int total = 3;
    public TextMeshProUGUI label;

    public void decrease(int value) {
        total -= value;
        label.SetText(total.ToString("000"));
    }

    public void reset() {
        total = 3;
        label.SetText(total.ToString("000"));
    }
}
