using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Result;
using Entity.Concrete;

namespace Business.Abstract
{
    public interface IPatientDataService
    {
        IDataResult<List<PatientData>> GetList();
        IDataResult<PatientData> GetById(int id);
        IResult Create(PatientData patientData);
        IResult Update(PatientData patientData);
        IResult Delete(PatientData patientData);
    }
}
