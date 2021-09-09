using UnityEngine;

public class TestB : MonoBehaviour
{
    [SerializeField]
    private TestA obj;

    void Start()
    {
        obj.gameObject.SetActive(true);

        obj.MethodA();
    }
}