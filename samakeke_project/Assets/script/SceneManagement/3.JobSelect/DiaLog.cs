using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class DiaLog : MonoBehaviour
{
    [SerializeField]
    private Button yesButton;
    [SerializeField]
    private Button noButton;

    [SerializeField]
    private Animator dialog;
    [SerializeField]
    private GameObject dialogObj;

    private FindSingleObj singleObj;    // 文字列を管理しているスクリプト型変数

    void Awake()
    {
        singleObj = new FindSingleObj();
        singleObj.SingleObjString();

        yesButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(singleObj.GetSingleObjString.GetGameMainScene);
        });

        noButton.onClick.AddListener(() =>
        {
            StartCoroutine(DialogClose());
        });
    }

    IEnumerator DialogClose()
    {
        yield return null;
        Disable();
        yield return new WaitForSeconds(0.5f);
        dialogObj.gameObject.SetActive(false);
    }

    void OnEnable()
    {
        dialog.SetBool(singleObj.GetSingleObjString.
            GetDialogFLag(StaticPlayerJobReference.PropertyPlayerStatus), true);
    }

    public void Disable()
    {
        dialog.SetBool(singleObj.GetSingleObjString.
            GetDialogFLag(StaticPlayerJobReference.PropertyPlayerStatus), false);
    }
}