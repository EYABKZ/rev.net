using Examen.ApplicationCore.Domain;
using Examen.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Services
{
    public class FestivalServiceImpl : Service<Festival>, IFestivalService
    {
        public FestivalServiceImpl(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public List<Festival> GetFestivalsParStyle(StyleMusical styleMusical)
        {


            return null;


        }
    }
}
