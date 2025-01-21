using UnityEngine;

namespace EnemySystem.Enemies
{
    public class Enemy2 : EnemyTemplate
    {
        private GameObject _enemyPrefab;

        public Enemy2(GameObject enemyPrefab)
        {
            _enemyPrefab = enemyPrefab;
        }
        public override void Spawn()
        {
            if (!IsActive) return;
            //Idk
        }

        public override void Idle()
        {
            if (!IsActive) return;
            Attack();
        }
        public override void Attack()
        {
            if (!IsActive) return;
            _enemyPrefab.GetComponent<Animator>().SetTrigger("Attack");
        }
    }
}
