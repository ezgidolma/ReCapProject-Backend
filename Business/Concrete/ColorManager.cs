using Business.Abstract;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public void Delete(Entities.Concrete.Color color)
        {
            _colorDal.Delete(color);
            Console.WriteLine("Silme");
        }

        public List<Entities.Concrete.Color> GetAll()
        {
           return  _colorDal.GetAll();
            
        }

        public Entities.Concrete.Color GetById(int colorId)
        {

            return _colorDal.Get(p=>p.Id==colorId);
        }

        public void Insert(Entities.Concrete.Color color)
        {
            _colorDal.Add(color);
            Console.WriteLine("Ekleme");
        }

        public void Update(Entities.Concrete.Color color)
        {
            _colorDal.Update(color);
            Console.WriteLine("Güncelleme");
        }
    }
}
