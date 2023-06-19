using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void TInsert(T item);
        void TDelete(T item);
        void TUpdate(T item);
        List<T> TGetList();
        T TGetById(int id);
    }
}
