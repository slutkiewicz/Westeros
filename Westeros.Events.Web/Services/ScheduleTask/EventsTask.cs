﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using Westeros.Events.Data.Model;
using Westeros.Events.Data.Repositories;
using Westeros.Events.Web.Services.Events;

namespace ASPNETCoreScheduler.Scheduler
{
    public class EventsTask : ScheduledProcessor
    {

        public EventsTask(IServiceScopeFactory serviceScopeFactory) : base(serviceScopeFactory)
        {
        }

        protected override string Schedule => "*/2 * * * *";//Runs every 2 minutes

        public override Task ProcessInScope(IServiceProvider serviceProvider)
        {
            new CheckRecipes(serviceProvider.GetService<IGenericRepository<Recipe>>(), serviceProvider.GetService<IGenericRepository<Profile>>())
                .CheckNew();

            return Task.CompletedTask;
        }
    }
}