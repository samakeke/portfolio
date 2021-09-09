using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class TitleSceneManagement : MonoBehaviour
{
    #region Field

    [SerializeField]
    private Button startButton;
    [SerializeField]
    private Button optionButton;
    [SerializeField]
    private Button loadButton;
    [SerializeField]
    private Button deleteButton;    
    [SerializeField]
    private Text loadText;

    private FindSingleObj singleObj;    // ��������Ǘ����Ă���X�N���v�g�^�ϐ�

    #endregion

    void Start()
    {
        singleObj = new FindSingleObj();
        singleObj.SingleObjString();

        // �X�^�[�g�{�^��
        startButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(singleObj.GetSingleObjString.GetPlayerNameScene);
        });

    // �I�v�V�����{�^��
        optionButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(singleObj.GetSingleObjString.GetOptionScene);
        });

    // ���[�h�{�^��
        loadButton.onClick.AddListener(() =>
        {
            StaticPlayerName.PropertyPlayerName = PlayerPrefs.GetString(singleObj.GetSingleObjString.GetPrefsKey, "");

            if (StaticPlayerName.PropertyPlayerName == "")
            {
                StartCoroutine(TextSet(singleObj.GetSingleObjString.GetLoadErrorText));
            }
            else
            {
                SceneManager.LoadScene(singleObj.GetSingleObjString.GetCharaSelectScene);
            }
        });

    // �f���[�g�{�^��
        deleteButton.onClick.AddListener(() =>
        {
            if (PlayerPrefs.HasKey(singleObj.GetSingleObjString.GetPrefsKey) == false)
            {
                StartCoroutine(TextSet(singleObj.GetSingleObjString.GetDeleteErrorText));
            }
            else
            {
                PlayerPrefs.DeleteKey(singleObj.GetSingleObjString.GetPrefsKey);

                StartCoroutine(TextSet(singleObj.GetSingleObjString.GetDeleteText));
            }
        });
    }

    IEnumerator TextSet(string str)
    {
        loadText.text = str;

        yield return new WaitForSeconds(1.0f);

        loadText.text = "";
    }
}