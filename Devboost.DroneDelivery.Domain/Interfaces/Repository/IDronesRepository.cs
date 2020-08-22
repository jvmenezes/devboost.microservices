﻿using Devboost.DroneDelivery.Domain.Entities;
using System.Collections.Generic;

namespace Devboost.DroneDelivery.Domain.Interfaces.Repository
{
    public interface IDronesRepository
    {
        List<DroneEntity> GetAll();

    }
}
