using TMPro;
using UnityEngine;

public class CoinUI : MonoBehaviour
{
    [SerializeField]
    private TMP_Text coinText;

    private void OnEnable()
    {
        PlayerOM.OnCoinChanged += UpdateCoins;
    }

    private void OnDisable()
    {
        PlayerOM.OnCoinChanged -= UpdateCoins;
    }

    private void Start()
    {
        UpdateCoins(0);
    }

    private void UpdateCoins(int amount)
    {
        coinText.text = "Moedas: " + amount;
    }
}