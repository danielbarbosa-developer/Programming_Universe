//Author: Daniel Barbosa
//This code is part of an initiative to support learning in the area of ​​programming and technology.

using System;

namespace LSP
{
    public class BusinessLicense : ILicense
    {
        public void AddExpireDate()
        {
            DateTime expireDate = new DateTime(2026, 12, 31);
        }

        public void BuyLicense()
        {
            int value = 20000;
        }
    }
}