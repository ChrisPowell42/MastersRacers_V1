﻿using MastersRacers.Data.CommandObjects;
using MastersRacers.Data.Contexts;
using MastersRacers.DataInterface.CRUD;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MastersRacers.DataInterface.Startup
{
    public static class DataUnityConfig
    {
        public static void ConfigureContainer(IUnityContainer container)
        {
            container.RegisterType<IRaceContext, RaceContext>();

            container.RegisterType<IRemoveRacerCommand, RemoveRacerCommand>();
            container.RegisterType<IGetAllRacersCommand, GetAllRacersCommand>();
            container.RegisterType<IGetRacerCommand, GetRacerCommand>();
            container.RegisterType<ISaveRacerCommand, SaveRacerCommand>();

            container.RegisterType<IRacerCRUD, RacerCRUD>();
        }

    }
}
