using CarRental.Data.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Data.Return
{
    public class Result : Abstracts.IResult
    {

        public Result(bool success, string message) : this(success)
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
