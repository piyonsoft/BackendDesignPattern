using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.Context;
using Entity.Concrete;

namespace DataAccess.Concrete
{
    public class PatientDataDal : EfEntityRepositoryBase<PatientData, Klinik365Context>, IPatientDataDal
    {
    }
}
