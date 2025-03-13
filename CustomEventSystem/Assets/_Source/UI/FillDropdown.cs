using ResourceSystem;
using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace UI
{
    public class FillDropdown : MonoBehaviour
    {
        [SerializeField] private TMP_Dropdown dropdown;

        public void Construct(ResourceSlot pancakes, ResourceSlot guts, ResourceSlot skulls)
        {
            List<TMP_Dropdown.OptionData> options = new List<TMP_Dropdown.OptionData>();

            TMP_Dropdown.OptionData option1 = new TMP_Dropdown.OptionData();
            TMP_Dropdown.OptionData option2 = new TMP_Dropdown.OptionData();
            TMP_Dropdown.OptionData option3 = new TMP_Dropdown.OptionData();

            option1.text = Enum.GetName(typeof(Resource), pancakes.Resource);
            option2.text = Enum.GetName(typeof(Resource), guts.Resource);
            option3.text = Enum.GetName(typeof(Resource), skulls.Resource);

            options.Add(option1);
            options.Add(option2);
            options.Add(option3);

            dropdown.AddOptions(options);
        }
    }
}