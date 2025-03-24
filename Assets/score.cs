using UnityEngine;
using TMPro;

public class score : MonoBehaviour
{
    public int total = 0;
    public TextMeshProUGUI label;

    public void add(int value) {
        total += value;
        label.SetText(total.ToString("000"));
    }

    public void reset() {
        total = 0;
        label.SetText(total.ToString("000"));
    }
}
