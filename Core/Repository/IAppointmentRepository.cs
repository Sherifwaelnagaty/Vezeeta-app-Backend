﻿using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repository
{
    public interface IAppointmentRepository:ICommonRepository<Appointment>
    {
        Appointment GetByDoctorIdAndDay(int doctorId, DayOfWeek day);
    }
}
