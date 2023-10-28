using System.Collections.Generic;
using System.Linq;
using Lunha.DevKit.Extensions;
using UnityEngine;

namespace Lunha.ProbabilityTable.Runtime
{
    public class ProbabilityTable : MonoBehaviour
    {
        [SerializeField] List<ProbabilityItem> m_ProbabilityItems = new();

        public List<ProbabilityItem> ProbabilityItems => m_ProbabilityItems;

        /// <summary>
        ///     Return random item based on probability
        /// </summary>
        /// <returns><see cref="ProbabilityItem" /> - as result you can use itemBehaviour or itemObject.</returns>
        public ProbabilityItem GetRandom()
        {
            var sortedItems = m_ProbabilityItems.OrderBy(i => i.Probability);
            var value = Random.Range(1, 101);
            var step = 0;
            var itemsInRange = new List<ProbabilityItem>();

            foreach (var item in sortedItems)
            {
                if (!itemsInRange.Any()) step += item.Probability;

                if (value <= step) itemsInRange.Add(item);
            }

            if (itemsInRange.Count > 1) return itemsInRange.RandomOne();

            if (itemsInRange.Any()) return itemsInRange.First();

            return m_ProbabilityItems.Any() ? m_ProbabilityItems.First() : null;
        }
    }
}