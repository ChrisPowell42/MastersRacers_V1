﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MastersRacers.Data.Contexts;
using MastersRacers.Data.Models;
using System.Data.Entity;
using MastersRacers.Data.Models.RefData;

namespace MastersRacers.Data.CommandObjects.RaceEventCommands
{
    public interface IGetActiveRaceEventsForPhaseCommand : IDisposable
    {
        Task<ICollection<RaceEvent>> GetActiveRacesForPhase(Guid phaseId);
    }

    public class GetActiveRaceEventsForPhaseCommand : CommandObjectBase, IGetActiveRaceEventsForPhaseCommand
    {
        public GetActiveRaceEventsForPhaseCommand(IRaceContext dbContext) : base(dbContext)
        {
        }

        public async Task<ICollection<RaceEvent>> GetActiveRacesForPhase(Guid phaseId)
        {
            ICollection<RaceEvent> returnValues = await _dbContext.RaceEvents.Where(x => x.Season.IsCurrentSeason && 
                                                                                         x.RaceEventTypeId == RaceEventType.RaceId &&
                                                                                         x.RacePhaseId.Equals(phaseId))
                                                                             .Include(x => x.Location)
                                                                             .Include(x => x.RaceFormat)
                                                                             .Include(x => x.RacePhase)
                                                                             .Include(x => x.Season)
                                                                             .ToListAsync();

            return returnValues;
        }
    }
}
