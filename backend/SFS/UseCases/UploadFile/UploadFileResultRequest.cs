﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.UseCases.UploadFile
{
    public class UploadFileResultRequest
    {
        public IFormFile? File { get; }
        public string HashPassword { get; }
    }
}