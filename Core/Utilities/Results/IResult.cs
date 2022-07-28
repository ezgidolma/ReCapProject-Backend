using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{

    //Temel voidler için başlangıç
    public interface IResult
    {
        bool Success { get; }//yapmaya çalışıtğım ekleme işi başarılı ya da başarısız
        string Message { get; }//eklendi eklenmedi bilgilendirmesini yapar
    }
}
