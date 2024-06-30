using UnityEngine;
using UnityEngine.UI;

public class CheckBalance : MonoBehaviour
{
    public MainData data;
    public Text text;

    private void Start()
    {
        Data();
    }

    public void Data()
    {
        text.text = data.countMoney.ToString();
    }

    public void BalanceMinusSmall()
    {
        data.countMoney -= 12;
        text.text = data.countMoney.ToString();
    }

    public void BalanceMinusSpeed()
    {
        data.countMoney -= 10;
        text.text = data.countMoney.ToString();
    }
}
