using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Compas.Logic
{
    public interface IGenericInterface<T>
    {
        T Get(int ID);
        List<T> GetAll();        
        int Delete(int ID);
        
    }
}
