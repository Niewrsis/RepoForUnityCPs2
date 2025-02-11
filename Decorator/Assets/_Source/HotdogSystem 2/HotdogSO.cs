using System.Collections.Generic;
using HotdogSystem2.Extras;
using UnityEngine;

namespace HotdogSystem2
{
    [CreateAssetMenu(fileName = "NewHotdogSO", menuName = "SO/NewHotdog")]
    public class HotdogSO : ScriptableObject
    {
        public Hotdog Hotdog;

        [SerializeField] private string name;
        [SerializeField] private int cost;
        [SerializeField] private int weight;


        public List<ExtrasSO> extras;
        [HideInInspector] public List<ExtraDecorator> ExtraDecoratorList = new List<ExtraDecorator>();

        public void OnEnable()
        {
            Hotdog = new Hotdog(name, cost, weight);
            if(IsExtras())
            {
                foreach(var extra in extras)
                {
                    ExtraDecoratorList.Add(new ExtraDecorator(extra, Hotdog));
                }
            }
            
        }
        public bool IsExtras()
        {
            if(extras.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
