﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WCGL
{
    public class CustomPerspectiveCamera : MonoBehaviour
    {
        void OnPreRender()
        {
            foreach (var cpm in CustomPerspectiveModel.GetInstances())
            {
                if (cpm.isActiveAndEnabled) { cpm.UpdateMatrix(Camera.current); }
            }
        }

        private void OnPostRender()
        {
            foreach (var cpm in CustomPerspectiveModel.GetInstances())
            {
                if (cpm.isActiveAndEnabled) { cpm.DisableMatrix(); }
            }
        }
    }
}