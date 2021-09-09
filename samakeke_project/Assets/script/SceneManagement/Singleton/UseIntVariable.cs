using UnityEngine;

public class UseIntVariable : MonoBehaviour
{
    #region [Field] Fixed Number

    // 定数
    // ======================================================

    // ｷｬﾗ初期MAXHP
    private const int warriorHp = 100;
    private const int monkHp = 50;
    private const int blackMageHp = 30;
    private const int whiteMageHp = 30;
    private const int enemyHp = 100;

    // ｷｬﾗ初期ATK
    private const int warriorAtk = 5;
    private const int monkAtk = 15;
    private const int blackMageAtk = 20;
    private const int whiteMageAtk = 3;
    private const int enemyAtk = 20;

    // ｷｬﾗ初期HEAL
    private const int warriorHeal = 0;
    private const int monkHeal = 0;
    private const int blackMageHeal = 0;
    private const int whiteMageHeal = 20;

    // ======================================================

    #endregion

    #region [Field] Variable

    // 変数
    // ======================================================

    // GameMainでの総ﾀｰﾝ数ｶｳﾝﾄ用
    private int turnCount =1;

    // GameMainでのｱｸﾃｨﾌﾞﾀｰﾝ切替用（1～5ループ）
    private int activeTurnChange = 1;

    // ﾌﾗｸﾞ管理用bool型
    private bool flag;

    // ======================================================

    #endregion

    // ｷｬﾗ初期MAXHPｹﾞｯﾀ
    public int GetWarriorHp => warriorHp;
    public int GetMonkHp => monkHp;
    public int GetBlackMageHp => blackMageHp;
    public int GetWhiteMageHp => whiteMageHp;
    public int GetEnemyHp => enemyHp;

    // ｷｬﾗ初期ATKｹﾞｯﾀ
    public int GetWarriorAtk => warriorAtk;
    public int GetMonkAtk => monkAtk;
    public int GetBlackMageAtk => blackMageAtk;
    public int GetWhiteMageAtk => whiteMageAtk;
    public int GetEnemyAtk => enemyAtk;

    // ｷｬﾗ初期HEALｹﾞｯﾀ
    public int GetWarriorHeal => warriorHeal;
    public int GetMonkHeal => monkHeal;
    public int GetBlackMageHeal => blackMageHeal;
    public int GetWhiteMageHeal => whiteMageHeal;

    // GameMainでの総ﾀｰﾝ数ｶｳﾝﾄｹﾞｯﾀ
    public int GetTurnCount { get => this.turnCount; set => this.turnCount = value; }

    // GameMainでのｱｸﾃｨﾌﾞﾀｰﾝ切替用
    public int PropertyActiveTurnChange { get => this.activeTurnChange; set => this.activeTurnChange = value; }

    // ﾌﾗｸﾞ管理用bool型
    public bool PropertyFlag { get => this.flag; set => this.flag = value; }
}