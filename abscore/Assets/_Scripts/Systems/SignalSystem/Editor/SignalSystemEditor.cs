using com.absence.core.systems.signals;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace com.absence.core
{
    public class SignalSystemEditor : Editor
    {
        [MenuItem("GameObject/absence/core/Signal System/Signal Gate", false)]
        static void CreateSignalGate(MenuCommand menuCommand)
        {
            GameObject gateGO = new GameObject("New Signal Gate");
            gateGO.AddComponent<SignalGate>();
            Undo.RegisterCreatedObjectUndo(gateGO, $"Create {gateGO.name}");
            Selection.activeObject = gateGO;
        }

        [MenuItem("GameObject/absence/core/Signal System/Signal Listener", false)]
        static void CreateSignalListener(MenuCommand menuCommand)
        {
            GameObject listenerGO = new GameObject("New Signal Listener");
            listenerGO.AddComponent<SignalListener>();
            Undo.RegisterCreatedObjectUndo(listenerGO, $"Create {listenerGO.name}");
            Selection.activeObject = listenerGO;
        }

        [MenuItem("GameObject/absence/core/Signal System/Signal Generator", false)]
        static void CreateSignalGenerator(MenuCommand menuCommand)
        {
            GameObject generatorGO = new GameObject("New Signal Generator");
            generatorGO.AddComponent<SignalGenerator>();
            Undo.RegisterCreatedObjectUndo(generatorGO, $"Create {generatorGO.name}");
            Selection.activeObject = generatorGO;
        }   
    }

}
