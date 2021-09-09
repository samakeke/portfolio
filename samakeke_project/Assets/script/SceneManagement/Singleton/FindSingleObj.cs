using UnityEngine;

public class FindSingleObj 
{
    private GameObject varManager;
    private UseStringVariable strVar;
    private UseIntVariable intVar;

    // �ϐ����Ǘ����Ă����޼ު��
    private const string varManagerObj = "VariableManager";

    public FindSingleObj()
    {
        this.varManager = GameObject.Find(varManagerObj);
    }

    public void SingleObjString()
    {
        this.strVar = this.varManager.GetComponent<UseStringVariable>();
    }

    public void SingleObjInt()
    {
        this.intVar = this.varManager.GetComponent<UseIntVariable>();
    }

    public UseStringVariable GetSingleObjString => this.strVar;
    public UseIntVariable GetSingleObjInt => this.intVar;
}
