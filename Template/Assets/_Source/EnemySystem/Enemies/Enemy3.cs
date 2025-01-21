using UnityEngine;

namespace EnemySystem.Enemies
{
    public class Enemy3 : EnemyTemplate
    {
        private GameObject _enemyPrefab;

        public Enemy3(GameObject enemyPrefab)
        {
            _enemyPrefab = enemyPrefab;
        }
        public override void Spawn()
        {
            if (!IsActive) return;
            Idle();
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
