using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CharaSelectSceneManagement : MonoBehaviour
{

    #region Field

    [SerializeField]
    private Text pNameText;
    [SerializeField]
    private Button[] jobButton;
    [SerializeField]
    private DiaLog jobDialog;
    [SerializeField]
    private GameObject[] dialogObj;

    private FindSingleObj singleObj;    // ��������Ǘ����Ă���X�N���v�g�^�ϐ�

    #endregion

    void Start()
    {
        singleObj = new FindSingleObj();
        singleObj.SingleObjString();

        pNameText.text = StaticPlayerName.PropertyPlayerName + singleObj.GetSingleObjString.GetCharaSelectText;

        JobButtonRegister();
    }

    public void JobButtonRegister()
    {
        for (int i = 0; i < 4; i++)     // warrior,monk,blackMage,whiteMage��4�W���u���̃{�^����o�^����
        {
            int index = i;

            jobButton[index].onClick.AddListener(() =>
            {
                StaticPlayerJobReference.PropertyPlayerStatus = index;  // �v���C���[�C���X�^���X�쐬�̂��߂̕ϐ���p��
                                                                        // ���̎��_�ł͂܂��C���X�^���X�����Ȃ�
                dialogObj[index].gameObject.SetActive(true);
            });
        }
    }
}