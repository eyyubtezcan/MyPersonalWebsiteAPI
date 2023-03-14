﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPersonalWebsite.Service.Concreate
{
    public class ServiceResult<T>
    {
        private bool _hasWarn = false;
        private bool _isOk = false;

        public bool isOk
        {
            get
            {
                return _isOk;
            }
        }
        public bool hasWarn
        {
            get
            {
                return _hasWarn;
            }
        }
        public T? Result { get; set; }

        public void Ok()
        {
            _isOk = true;
        }
        public void Fail()
        {
            _isOk = false;
        }
    }
}
