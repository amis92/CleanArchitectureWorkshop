﻿using System.Threading.Tasks;
using Triggerity.Domain;

namespace Triggerity.Adapters
{
    internal class TriggerOrderRepository
        : ITriggerOrderRepository
    {
        public Task Save(TriggerOrder triggerOrder)
        {
            return Task.CompletedTask;
        }
    }
}
