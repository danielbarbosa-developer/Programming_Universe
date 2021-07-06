//Author: Daniel Barbosa
//This code is part of an initiative to support learning in the area of ​​programming and technology.

namespace LSP
{
    public class Billing
    {
        private readonly ILicense _license;
        public Billing(ILicense license)
        {
            _license = license;
        }

        public void BuyLicense()
        {
            _license.BuyLicense();
            _license.AddExpireDate();
        }
    }
}