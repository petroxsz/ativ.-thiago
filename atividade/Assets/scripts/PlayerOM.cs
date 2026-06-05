using System;

public static class PlayerOM
{
    public static Action<int> OnCoinChanged;

    public static void NotifyCoinChanged(int amount)
    {
        OnCoinChanged?.Invoke(amount);
    }
}