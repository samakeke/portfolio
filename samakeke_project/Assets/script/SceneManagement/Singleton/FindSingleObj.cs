using UnityEngine;

public class FindSingleObj 
{
    private GameObject varManager;
    private UseStringVariable strVar;
    private UseIntVariable intVar;

    // •Ï”‚ğŠÇ—‚µ‚Ä‚¢‚éµÌŞ¼Şª¸Ä
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
