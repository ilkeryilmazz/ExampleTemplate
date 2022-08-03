using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IExampleItemService
    {
        IDataResult<List<ExampleItem>> GetAll();
        IDataResult<ExampleItem> GetById(int id);
        IResult Add(ExampleItem exampleItem);
        IResult Update(ExampleItem exampleItem);
        IResult Delete(ExampleItem exampleItem);
    }
}
