using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //interface default olarak public değildir. referansları default olarak publictir
    public interface IProductDal:IEntityRepository<Product>
    {
        //interface referansları default olarak public tir onun için public yazmaya gerek yoktur.
        List<ProductDetailDto> GetProductDetails();       
    }
}

//Code Refactoring
