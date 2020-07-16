﻿using Domain;
using SFS.Application.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace SFS.Infrastructure.Data
{
    class FileAccessor : IFileAccessor
    {
        public async Task<bool> WriteFileToDiskAsync(StoredFile file)
        {
            try
            {
                // TODO: get path from config
                var pathFromConfig = "/home/tasfdasfd/";
                using (var stream = new FileStream(Path.Combine(new[] { pathFromConfig , file.FileName, file.Identifier}), FileMode.Create))
                {
                    // TODO: fire and forget ??
                    //_ = file.File.CopyToAsync(stream);
                    await file.File.CopyToAsync(stream);
                }
            }catch(Exception ex)
            {
                // TODO: logg ex
                return false;
            }
            return true;
        }
    }
}
