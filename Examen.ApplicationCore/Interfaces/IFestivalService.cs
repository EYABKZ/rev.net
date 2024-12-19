﻿using Examen.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Interfaces
{
    public interface IFestivalService: IService<Festival>
    {
        public List<Festival> GetFestivalsParStyle(StyleMusical styleMusical);
    }
}
