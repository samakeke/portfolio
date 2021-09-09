using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OptionSceneManagement : MonoBehaviour
{
    #region Field

    [SerializeField]
    private Button titleButton;
    
    private FindSingleObj singleObj;    // ��������Ǘ����Ă���X�N���v�g�^�ϐ�

    #endregion

    void Start()
    {
        singleObj = new FindSingleObj();
        singleObj.SingleObjString();

        titleButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(singleObj.GetSingleObjString.GetTitleScene);
        });
    }
}