using UnityEngine;

public class CommandBox : MonoBehaviour
{
    public Transform box;

    public void OnActive()
    {
        box.LeanMoveLocalY(0, 0.5f).setEaseOutExpo().delay = 0.1f;
    }

    public void OpenBox()
    {
        box.LeanMoveLocalY(0, 0.5f).setEaseOutQuad();
    }

    public void CloseBox()
    {
        box.LeanMoveLocalY(-Screen.height, 0.3f).setEaseInExpo();
    }

    public void OpenBack()
    {
        box.LeanMoveLocalX(-400, 0.5f).setEaseOutQuad();
    }

    public void CloseBack()
    {
        box.LeanMoveLocalX(-Screen.width, 0.5f).setEaseInExpo();
    }

    public void OpenLoad()
    {
        transform.LeanScale(Vector2.one, 0.3f);
    }
}
