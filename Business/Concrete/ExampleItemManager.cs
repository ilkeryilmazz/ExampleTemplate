using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ExampleItemManager : IExampleItemService
    {
        IExampleItemDal _exampleItemDal;

        public ExampleItemManager(IExampleItemDal exampleItemDal)
        {
            _exampleItemDal = exampleItemDal;
        }

        public IResult Add(ExampleItem exampleItem)
        {
            _exampleItemDal.Add(exampleItem);
            return new SuccessResult("Eklendi.");
        }

        public IResult Delete(ExampleItem exampleItem)
        {
            _exampleItemDal.Delete(exampleItem);
            return new SuccessResult("Silindi.");
        }

        public IDataResult<List<ExampleItem>> GetAll()
        {
            var data = _exampleItemDal.GetAll();
            return new SuccessDataResult<List<ExampleItem>>(data);
        }

        public IDataResult<ExampleItem> GetById(int id)
        {
            var data = _exampleItemDal.Get(exampleItem=>exampleItem.Id==id);
            return new SuccessDataResult<ExampleItem>(data);
        }

        public IResult Update(ExampleItem exampleItem)
        {
            _exampleItemDal.Update(exampleItem);
            return new SuccessResult("Güncellendi.");
        }
    }
}
