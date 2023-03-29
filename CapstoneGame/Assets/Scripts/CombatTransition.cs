using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CombatTransition : MonoBehaviour
{
    public string scenename;
    public GameObject player;
    public GameObject thisEnemy;
    public float EnemyDist;
    private float minEnDist = 3.0f;
    void combatSceneChange()
    {
        SceneManager.LoadScene(scenename);
    }
        private void Update()
    {
        EnemyDist = Vector3.Distance(player.transform.position, thisEnemy.transform.position);
        if (EnemyDist < minEnDist)
        {
            combatSceneChange();
        }
    }
    
}
