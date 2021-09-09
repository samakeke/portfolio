using UnityEngine;

public class UseStringVariable : MonoBehaviour
{
    #region Field

    // �萔�ꗗ
    // ===============================================================================================
    // ���ٵ�޼ު��
    private const string panelName1 = "Player.UI STATUS";
    private const string panelName2 = "NPC (1) .UI STATUS";
    private const string panelName3 = "NPC (2) .UI STATUS";
    private const string panelName4 = "NPC (3) .UI STATUS";

    // �������
    private const string titleScene = "0.TitleScene";
    private const string optionScene = "1.OptionScene";
    private const string playerNameScene = "2.PlayerNameScene";
    private const string charaSelectScene = "3.CharaSelectScene";
    private const string gameMainScene = "4.GameMainScene";
    private const string creditScene = "5.CreditScene";

    // ���قŎg�p����÷��
    private const string loadErrorText = "�f�[�^�����݂��܂���";
    private const string deleteErrorText = "�f�[�^�͊��ɍ폜�ς݂ł�";
    private const string deleteText = "�f�[�^���폜���܂���";

    // ��ڲ԰Ȱѓ��ͼ�݂Ŏg�p����÷��
    private const string pNameSceneText = "���O����͂��Ă�������";

    // �ޮ�޾ڸļ�݂Ŏg�p����÷��
    private const string charaSelectText = "����A��낵�����肢���܂��B\n�ǂ̃W���u�Ŗ`�����J�n���܂����H";

    // PlayerPrefs��
    private const string prefsKey = "pNameKey";

    // FlashFlag
    private const string playerFlashFlagName = "PlayerFlashFlag";
    private const string npc1FlashFlagName = "Npc1FlashFlag";
    private const string npc2FlashFlagName = "Npc2FlashFlag";
    private const string npc3FlashFlagName = "Npc3FlashFlag";

    // dialogFlag
    private readonly string[] dialogFLag =
    {
        "Dialog00",
        "Dialog01",
        "Dialog02",
        "Dialog03"
    };

    // ��׸���̖��O
    private readonly string[] charName =
    {
        StaticPlayerName.PropertyPlayerName,
        "�����N",
        "�������m",
        "�������m",
        "DARK KNIGHT"
    };

    // UI�\���p��HP÷��
    private const string ui_hpText = "HP�F";

    // UI�\���p�e����÷��
    private const string ui_turnText = "�̃^�[��";
    private const string ui_attackText = "�̍U���I";
    private const string ui_healSkillText = "�̃��f�B�J�I";
    private const string ui_skillScopeText = "�����S�̂�";
    private const string ui_healText = "�����ӂ��I";
    private const string ui_damageText = "�̃_���[�W�I";
    private const string ui_downText = "������Ă��܂����I";
    private const string ui_gameOverText = "GAME OVER...";
    private const string ui_gameClearText = "GAME CLEAR�I";

    // ÷�Ķװ
    private const string greenColor = "<color=#00FF00>";      // �ΐF
    private const string redColor = "<color=#ff0033>";        // �ԐF
    private const string yellowColor = "<color=#ffff00>";     // ���F
    private const string colorEnd = "</color>";               // �Y

    // ===============================================================================================

    #endregion

    // �I�u�W�F�N�g���Q�b�^
    public string GetPanelName1 => panelName1;
    public string GetPanelName2 => panelName2;
    public string GetPanelName3 => panelName3;
    public string GetPanelName4 => panelName4;

    // �V�[���^�C�g���Q�b�^
    public string GetTitleScene => titleScene;
    public string GetOptionScene => optionScene;
    public string GetPlayerNameScene => playerNameScene;
    public string GetCharaSelectScene => charaSelectScene;
    public string GetGameMainScene => gameMainScene;
    public string GetCreditScene => creditScene;

    // 01.Title�Ŏg�p����ϐ��Q�b�^
    public string GetLoadErrorText => loadErrorText;
    public string GetDeleteErrorText => deleteErrorText;
    public string GetDeleteText => deleteText;

    // 02.PlayerName�Ŏg�p����ϐ��Q�b�^
    public string GetPnameSceneText => pNameSceneText;

    // 03.CharaSelect�Ŏg�p����ϐ��Q�b�^
    public string GetCharaSelectText => charaSelectText;

    // PlayerPrefs�L�[�Q�b�^
    public string GetPrefsKey => prefsKey;

    // FlashFlagName�Q�b�^
    public string GetPlayerFlashFlagName => playerFlashFlagName;
    public string GetNpc1FlashFlagName => npc1FlashFlagName;
    public string GetNpc2FlashFlagName => npc2FlashFlagName;
    public string GetNpc3FlashFlagName => npc3FlashFlagName;

    // dialogFlag�Q�b�^
    public string GetDialogFLag(int num) { return this.dialogFLag[num]; }

    // �L�����N�^�[�̖��O�Q�b�^
    public string GetName(int num){ return this.charName[num]; }
    public string PropertyPname { get => this.charName[0]; set => this.charName[0] = value; }

    // UI�\���p��HP�e�L�X�g�Q�b�^
    public string GetUi_hpText => ui_hpText;

    // UI�\���p�e���ԃe�L�X�g�Q�b�^
    public string GetUi_turnText => ui_turnText;
    public string GetUi_attackText => ui_attackText;
    public string GetUi_healSkillText => ui_healSkillText;
    public string GetUi_skillScopeText => ui_skillScopeText;
    public string GetUi_healText => ui_healText;
    public string GetUi_damageText => ui_damageText;
    public string GetUi_downText => ui_downText;
    public string GetUi_gameOverText => ui_gameOverText;
    public string GetUi_gameClearText => ui_gameClearText;

    // �e�L�X�g�J���[�Q�b�^
    public string GetGreenColor  => greenColor;
    public string GetRedColor => redColor;
    public string GetYellowColor => yellowColor;
    public string GetColorEnd => colorEnd;
}