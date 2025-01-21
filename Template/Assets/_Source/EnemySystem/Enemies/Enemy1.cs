using UnityEngine;

namespace EnemySystem.Enemies
{
    public class Enemy1 : EnemyTemplate
    {
        private GameObject _enemyPrefab;

        public Enemy1(GameObject enemyPrefab)
        {
            _enemyPrefab = enemyPrefab;
        }

        public override void Spawn()
        {
            if (!IsActive) return;
            Attack();
        }

        public override void Idle()
        {
            if (!IsActive) return;
            //Idk
        }

        public override void Attack()
        {
            if (!IsActive) return;
            _enemyPrefab.GetComponent<Animator>().SetTrigger("Attack");
        }
    }
}