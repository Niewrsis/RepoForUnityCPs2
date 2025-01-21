using Core;
using EnemySystem.Enemies;
using UnityEngine;

namespace EnemySystem
{
    public class EnemyManager : MonoBehaviour
    {
        [Header("Enemies")]
        public GameObject Enemy1;
        public GameObject Enemy2;
        public GameObject Enemy3;

        public GameObject TempEnemy1;
        public GameObject TempEnemy2;
        public GameObject TempEnemy3;

        [Space(20)]
        [SerializeField] private Vector2 spawnPosition;

        private Enemy1 _enemy1;
        private Enemy2 _enemy2;
        private Enemy3 _enemy3;

        private EventManager _eventManager;

        public void Construct(Enemy1 enemy1, Enemy2 enemy2, Enemy3 enemy3, EventManager eventManager)
        {
            _enemy1 = enemy1;
            _enemy2 = enemy2;
            _enemy3 = enemy3;

            _eventManager = eventManager;
        }
        private void Awake()
        {
            TempEnemy1 = Instantiate(Enemy1, spawnPosition, Quaternion.identity);
            TempEnemy2 = Instantiate(Enemy2, spawnPosition, Quaternion.identity);
            TempEnemy3 = Instantiate(Enemy3, spawnPosition, Quaternion.identity);
        }
        public void SpawnEnemy1()
        {
            _eventManager.OnAttack -= AttackEnemy3;

            _enemy1.IsActive = true;
            _enemy2.IsActive = false;
            _enemy3.IsActive = false;

            SetActiveEnemy();

            _enemy1.Spawn();
        }
        public void SpawnEnemy2()
        {
            _eventManager.OnAttack -= AttackEnemy3;

            _enemy1.IsActive = false;
            _enemy2.IsActive = true;
            _enemy3.IsActive = false;

            SetActiveEnemy();
        }
        public void SpawnEnemy3()
        {

            _enemy1.IsActive = false;
            _enemy2.IsActive = false;
            _enemy3.IsActive = true;

            SetActiveEnemy();

            _eventManager.OnAttack += AttackEnemy3;
        }
        private void SetActiveEnemy()
        {
            TempEnemy1.SetActive(_enemy1.IsActive);
            TempEnemy2.SetActive(_enemy2.IsActive);
            TempEnemy3.SetActive(_enemy3.IsActive);
        }
        private void AttackEnemy3()
        {
            _enemy3.Attack();
        }
    }
}
