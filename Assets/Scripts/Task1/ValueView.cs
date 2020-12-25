using System;
using UnityEngine;
using UnityEngine.UI;

namespace GyreRigTask.Task1
{
    public class ValueView
    {
        public event Action onButtonPress;

        private Text _valueTxt;
        private Button _button;

        public ValueView(GameObject UI)
        {
            _valueTxt = UI.transform.GetChild(0).GetChild(0).GetComponent<Text>();
            _button = UI.GetComponentInChildren<Button>();

            Init();
        }

        private void Init()
        {
            _valueTxt.text = "0";
            _button.onClick.AddListener(ButtonAction);
        }

        private void ButtonAction()
        {
            onButtonPress();
        }

        public void ChangeValue(int value)
        {
            _valueTxt.text = value.ToString();
        }
    }
}

