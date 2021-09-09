using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestA : MonoBehaviour
{
    [SerializeField]
    private Animator panel;

    public void MethodA()
    {
        panel.SetBool("flag", true);
    }

    public void MethodB()
    {
        panel.SetBool("flag", false);
    }
}