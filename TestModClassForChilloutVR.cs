using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using MelonLoader;

namespace TestModForChilloutVR
{
    public class TestModClassForChilloutVR : MelonMod
    {
        public override void OnUpdate()
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                ABI_RC.Systems.MovementSystem.MovementSystem.Instance.ToggleFlight();
            }
        }
    }
}
