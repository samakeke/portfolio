using UnityEngine;

public class UseStringVariable : MonoBehaviour
{
    #region Field

    // 定数一覧
    // ===============================================================================================
    // ﾊﾟﾈﾙｵﾌﾞｼﾞｪｸﾄ
    private const string panelName1 = "Player.UI STATUS";
    private const string panelName2 = "NPC (1) .UI STATUS";
    private const string panelName3 = "NPC (2) .UI STATUS";
    private const string panelName4 = "NPC (3) .UI STATUS";

    // ｼｰﾝﾀｲﾄﾙ
    private const string titleScene = "0.TitleScene";
    private const string optionScene = "1.OptionScene";
    private const string playerNameScene = "2.PlayerNameScene";
    private const string charaSelectScene = "3.CharaSelectScene";
    private const string gameMainScene = "4.GameMainScene";
    private const string creditScene = "5.CreditScene";

    // ﾀｲﾄﾙで使用するﾃｷｽﾄ
    private const string loadErrorText = "データが存在しません";
    private const string deleteErrorText = "データは既に削除済みです";
    private const string deleteText = "データを削除しました";

    // ﾌﾟﾚｲﾔｰﾈｰﾑ入力ｼｰﾝで使用するﾃｷｽﾄ
    private const string pNameSceneText = "名前を入力してください";

    // ｼﾞｮﾌﾞｾﾚｸﾄｼｰﾝで使用するﾃｷｽﾄ
    private const string charaSelectText = "さん、よろしくお願いします。\nどのジョブで冒険を開始しますか？";

    // PlayerPrefsｷｰ
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

    // ｷｬﾗｸﾀｰの名前
    private readonly string[] charName =
    {
        StaticPlayerName.PropertyPlayerName,
        "モンク",
        "黒魔導士",
        "白魔導士",
        "DARK KNIGHT"
    };

    // UI表示用のHPﾃｷｽﾄ
    private const string ui_hpText = "HP：";

    // UI表示用各種状態ﾃｷｽﾄ
    private const string ui_turnText = "のターン";
    private const string ui_attackText = "の攻撃！";
    private const string ui_healSkillText = "のメディカ！";
    private const string ui_skillScopeText = "味方全体を";
    private const string ui_healText = "かいふく！";
    private const string ui_damageText = "のダメージ！";
    private const string ui_downText = "がやられてしまった！";
    private const string ui_gameOverText = "GAME OVER...";
    private const string ui_gameClearText = "GAME CLEAR！";

    // ﾃｷｽﾄｶﾗｰ
    private const string greenColor = "<color=#00FF00>";      // 緑色
    private const string redColor = "<color=#ff0033>";        // 赤色
    private const string yellowColor = "<color=#ffff00>";     // 黄色
    private const string colorEnd = "</color>";               // 〆

    // ===============================================================================================

    #endregion

    // オブジェクト名ゲッタ
    public string GetPanelName1 => panelName1;
    public string GetPanelName2 => panelName2;
    public string GetPanelName3 => panelName3;
    public string GetPanelName4 => panelName4;

    // シーンタイトルゲッタ
    public string GetTitleScene => titleScene;
    public string GetOptionScene => optionScene;
    public string GetPlayerNameScene => playerNameScene;
    public string GetCharaSelectScene => charaSelectScene;
    public string GetGameMainScene => gameMainScene;
    public string GetCreditScene => creditScene;

    // 01.Titleで使用する変数ゲッタ
    public string GetLoadErrorText => loadErrorText;
    public string GetDeleteErrorText => deleteErrorText;
    public string GetDeleteText => deleteText;

    // 02.PlayerNameで使用する変数ゲッタ
    public string GetPnameSceneText => pNameSceneText;

    // 03.CharaSelectで使用する変数ゲッタ
    public string GetCharaSelectText => charaSelectText;

    // PlayerPrefsキーゲッタ
    public string GetPrefsKey => prefsKey;

    // FlashFlagNameゲッタ
    public string GetPlayerFlashFlagName => playerFlashFlagName;
    public string GetNpc1FlashFlagName => npc1FlashFlagName;
    public string GetNpc2FlashFlagName => npc2FlashFlagName;
    public string GetNpc3FlashFlagName => npc3FlashFlagName;

    // dialogFlagゲッタ
    public string GetDialogFLag(int num) { return this.dialogFLag[num]; }

    // キャラクターの名前ゲッタ
    public string GetName(int num){ return this.charName[num]; }
    public string PropertyPname { get => this.charName[0]; set => this.charName[0] = value; }

    // UI表示用のHPテキストゲッタ
    public string GetUi_hpText => ui_hpText;

    // UI表示用各種状態テキストゲッタ
    public string GetUi_turnText => ui_turnText;
    public string GetUi_attackText => ui_attackText;
    public string GetUi_healSkillText => ui_healSkillText;
    public string GetUi_skillScopeText => ui_skillScopeText;
    public string GetUi_healText => ui_healText;
    public string GetUi_damageText => ui_damageText;
    public string GetUi_downText => ui_downText;
    public string GetUi_gameOverText => ui_gameOverText;
    public string GetUi_gameClearText => ui_gameClearText;

    // テキストカラーゲッタ
    public string GetGreenColor  => greenColor;
    public string GetRedColor => redColor;
    public string GetYellowColor => yellowColor;
    public string GetColorEnd => colorEnd;
}