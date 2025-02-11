using UnityEngine;

namespace HotdogSystem2.Extras
{
    [CreateAssetMenu(fileName = "NewExtraSO", menuName = "SO/NewExtra")]
    public class ExtrasSO : ScriptableObject
    {
        public string Name;
        public int ExtraMoney;
        public int ExtraWeight;
    }
}