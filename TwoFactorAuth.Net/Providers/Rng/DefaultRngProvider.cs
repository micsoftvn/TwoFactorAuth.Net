﻿using System.Security.Cryptography;

namespace TwoFactorAuth.Net.Providers.Rng
{
    public class DefaultRngProvider : IRngProvider
    {
        private static readonly RNGCryptoServiceProvider _rngcryptoserviceprovider = new RNGCryptoServiceProvider();

        public bool IsCryptographicallySecure
        {
            get { return true; }
        }

        public byte[] GetRandomBytes(int bytes)
        {
            var buff = new byte[bytes];
            _rngcryptoserviceprovider.GetBytes(buff);
            return buff;
        }
    }
}
