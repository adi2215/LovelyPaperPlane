using UnityEngine;
using UnityEngine.Events;

public class AnimationEvenHelper : MonoBehaviour
{
    public UnityEvent AnimationScene;

    public void Scene()
    {
        AnimationScene?.Invoke();
    }
}
