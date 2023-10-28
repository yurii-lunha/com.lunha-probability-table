using System;
using UnityEngine;

namespace Lunha.ProbabilityTable.Runtime
{
    [Serializable]
    public class ProbabilityItem
    {
        [SerializeField, Range(1, 100)] int m_Probability;

        [SerializeField] MonoBehaviour m_ItemBehaviour;
        [SerializeField] GameObject m_ItemObject;
        [SerializeField] int m_ItemInt;
        [SerializeField] float m_ItemFlt;

        public int Probability
        {
            get => m_Probability;
            set => m_Probability = value;
        }

        public MonoBehaviour ItemBehaviour
        {
            get => m_ItemBehaviour;
            set => m_ItemBehaviour = value;
        }

        public GameObject ItemObject
        {
            get => m_ItemObject;
            set => m_ItemObject = value;
        }

        public int ItemInt
        {
            get => m_ItemInt;
            set => m_ItemInt = value;
        }

        public float ItemFlt
        {
            get => m_ItemFlt;
            set => m_ItemFlt = value;
        }
    }
}