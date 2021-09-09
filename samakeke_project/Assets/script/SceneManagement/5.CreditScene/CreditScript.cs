using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CreditScript : MonoBehaviour
{
    GameObject varManager;
    UseStringVariable strVar;

    void Start()
    {
        varManager = GameObject.Find("VariableManager");
        strVar = varManager.GetComponent<UseStringVariable>();
    }

    public void EndRollEnd()
    {
        SceneManager.LoadScene(strVar.GetTitleScene);
    }
}
