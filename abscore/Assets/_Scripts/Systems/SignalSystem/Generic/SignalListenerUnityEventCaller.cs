using com.absence.core.systems.signals;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace com.absence.core
{
    [RequireComponent(typeof(SignalListener))]
    public class SignalListenerUnityEventCaller : MonoBehaviour
    {
        // Fields.
        [SerializeField] private UnityEvent m_positiveSignalReceivedCallback;
        [SerializeField] private UnityEvent m_negativeSignalReceivedCallback;
        [SerializeField] private UnityEvent m_signalChangedCallback;
        [SerializeField] private UnityEvent m_signalChangedToPositiveCallback;
        [SerializeField] private UnityEvent m_signalChangedToNegativeCallback;

        // Private.
        SignalListener m_listener;

        private void OnEnable()
        {
            m_listener = GetComponent<SignalListener>();
            m_listener.OnPositiveSignalReceived  += () => m_positiveSignalReceivedCallback?.Invoke();
            m_listener.OnNegativeSignalReceived  += () => m_negativeSignalReceivedCallback?.Invoke();
            m_listener.OnSignalChanged           += () => m_signalChangedCallback?.Invoke();
            m_listener.OnSignalChangedToPositive += () => m_signalChangedToPositiveCallback?.Invoke();
            m_listener.OnSignalChangedToNegative += () => m_signalChangedToNegativeCallback?.Invoke();
        }

        private void OnDisable()
        {
            m_listener.OnPositiveSignalReceived  -= () => m_positiveSignalReceivedCallback?.Invoke();
            m_listener.OnNegativeSignalReceived  -= () => m_negativeSignalReceivedCallback?.Invoke();
            m_listener.OnSignalChanged           -= () => m_signalChangedCallback?.Invoke();
            m_listener.OnSignalChangedToPositive -= () => m_signalChangedToPositiveCallback?.Invoke();
            m_listener.OnSignalChangedToNegative -= () => m_signalChangedToNegativeCallback?.Invoke();
            m_listener = null;
        }
    }
}
