using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.PackageManager.UI;
using UnityEngine;

namespace com.absence.core
{
    public class SignalSystemEditorWindow : EditorWindow
    {
        [MenuItem("absence/Signal System")]
        public static void ShowWindow()
        {
            EditorWindow.GetWindow(typeof(SignalSystemEditorWindow), false, "Signal System");
        }

        private void OnGUI()
        {
            
        }
    }
}
