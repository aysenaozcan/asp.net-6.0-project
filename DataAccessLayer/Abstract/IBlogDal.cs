using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IBlogDal:IGenericDal<Blog> 
    {
        List<Blog> GetListWithCategory(); //generic yapıya ek olarak sadece ilgili entitye ait bir metot tanımlamak istediğimizde bu yapıyı kullanırız. 
    }
}
