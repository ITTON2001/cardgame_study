using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//カードを出現させるプログラム
public class GameManager : MonoBehaviour
{
    //Unity側に紐づけるスペースを作る
    [SerializeField] GameObject cardPrefab;
    [SerializeField] Transform playerHand;
    [SerializeField] Transform playerfield;
    [SerializeField] Transform enemyfield;

    void Start()
    {
        for (int cnt = 0; cnt < 5; cnt++)
        {
            //手札を1枚配る
            Instantiate(cardPrefab, playerHand);
        }
        for (int cnt = 0; cnt < 3; cnt++)
        {
            //手札を1枚配る
            Instantiate(cardPrefab, enemyfield);
        }
        for (int cnt = 0; cnt < 2; cnt++)
        {
            //手札を1枚配る
            Instantiate(cardPrefab, playerfield);
        }

        Debug.Log("処理完了");
    }


}
