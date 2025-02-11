using HotdogSystem.Types;
using HotdogSystem2;
using UnityEngine;

public class DebugClass : MonoBehaviour
{
    private ClassicHotdog _classicHotdog = new();
    private CeaserHotdog _ceaserHotdog = new();
    private MeatHotdog _meatHotdog = new();
    
    private void Start()
    {
        /*Debug.Log($"{_classicHotdog.GetName()} - {_classicHotdog.GetCost()}");
        Debug.Log($"{_ceaserHotdog.GetName()} - {_ceaserHotdog.GetCost()}");
        Debug.Log($"{_meatHotdog.GetName()} - {_meatHotdog.GetCost()}");*/

        var Hotdogs = Resources.LoadAll<HotdogSO>("Hotdogs");

        foreach (var hotdog in Hotdogs)
        {
            Debug.Log($"{hotdog.Hotdog.GetName()} ({hotdog.Hotdog.GetWeigth()}г.) - {hotdog.Hotdog.GetCost()}р.");
            if(hotdog.IsExtras())
            {
                Debug.Log("Дополнительные ингридиенты:");
                for(int i = 0; i < hotdog.extras.Count; i++)
                {
                    Debug.Log($"{hotdog.ExtraDecoratorList[i].GetName()} ({hotdog.ExtraDecoratorList[i].GetWeigth()}г.) - {hotdog.ExtraDecoratorList[i].GetCost()}р.");
                }
            }
        }
    }
}