namespace EnemySystem
{
    public abstract class EnemyTemplate
    {
        public bool IsActive;
        public abstract void Spawn();
        public abstract void Idle();
        public abstract void Attack();
    }
}