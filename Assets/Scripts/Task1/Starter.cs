using UnityEngine;

namespace GyreRigTask.Task1
{
    public class Starter : MonoBehaviour
    {
        private void Awake()
        {
            GameObject UIprefab = Resources.Load<GameObject>("Prefab/[UI]");
            GameObject UI = Instantiate(UIprefab);
            UI.name = "[UI]";

            new ValueController(new ValueModel(), new ValueView(UI));
        }
    }
}

