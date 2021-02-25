using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        
        //this-->classın kendisi demek
        //iki parametre gönderen için thisden önceki kısım
        //tek parametre gönderen biri için this kısmındaki classı çalıştır.
        public Result(bool success, string message):this(success)
        {
            Message = message;
        }
        public Result(bool success)
        {
            Success = success;
        }
        public bool Success { get; }

        public string Message { get; }
    }
}
