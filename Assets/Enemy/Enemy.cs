using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField] int enemyReward = 25;
    [SerializeField] int enemyPenalty = 10;

    Bank bank;

    // Start is called before the first frame update
    void Start()
    {
        bank = FindObjectOfType<Bank>();
    }

    public void EnemyKillReward()
    {
        if(bank == null){ return; }
        bank.Deposit(enemyReward);
    }

    public void EnemyPenalty()
    {
        if(bank == null){ return; }
        bank.Withdraw(enemyPenalty);
    }

}
