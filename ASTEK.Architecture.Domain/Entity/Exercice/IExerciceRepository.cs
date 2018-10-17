using ASTEK.Architecture.Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASTEK.Architecture.Domain.Entity.Exercice
{
    public interface IExerciceRepository: IRepository<Exercice, Guid>
    {
        int Count(Guid lessonId);
    }
}
