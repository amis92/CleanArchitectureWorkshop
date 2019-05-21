﻿using Autofac;
using Microsoft.Extensions.Configuration;

namespace Triggerity.Infrastructure
{
    internal class SettingsModule : Autofac.Module
    {
        private readonly IConfiguration _configuration;

        public SettingsModule(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterInstance(_configuration).SingleInstance();
        }
    }
}
