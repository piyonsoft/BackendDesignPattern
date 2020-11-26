using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Contants;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entity.Concrete;

namespace Business.Concrete
{
    public class PatientDataManager : IPatientDataService
    {
        private IPatientDataDal _patientDataDal;

        public PatientDataManager(IPatientDataDal patientDataDal)
        {
            _patientDataDal = patientDataDal;
        }


        public IDataResult<List<PatientData>> GetList()
        {
            var result = _patientDataDal.GetList();
            return new SuccessDataResult<List<PatientData>>(result);
        }

        public IDataResult<PatientData> GetById(int id)
        {
            var result = _patientDataDal.Get(m => m.Id == id);
            return new SuccessDataResult<PatientData>(result);
        }

        public IResult Create(PatientData patientData)
        {
            try
            {
                _patientDataDal.Add((patientData));
                return new SuccessResult(Messages.SavedSuccessfully);

            }
            catch (Exception e)
            {
                return new ErrorResult(Messages.SavedUnSuccessfully);
            }
        }

        public IResult Update(PatientData patientData)
        {
            try
            {
                _patientDataDal.Update((patientData));
                return new SuccessResult(Messages.SavedSuccessfully);

            }
            catch (Exception e)
            {
                return new ErrorResult(Messages.SavedUnSuccessfully);
            }

        }

        public IResult Delete(PatientData patientData)
        {
            try
            {
                var getModel = _patientDataDal.Get(m => m.Id == patientData.Id);
                if (getModel!=null)
                {
                    _patientDataDal.Delete((patientData));
                    return new SuccessResult(Messages.DeletedSuccessfully);
                }
                return new ErrorResult(Messages.DeletedObjectNotFound);

            }
            catch (Exception e)
            {
                return new ErrorResult(Messages.DeletedUnSuccessfully);
            }
        }
    }
}
