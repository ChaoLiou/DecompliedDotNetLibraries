﻿namespace System.Web.Security
{
    using System;
    using System.Web.Configuration;

    internal class MembershipAdapter : IMembershipAdapter
    {
        public byte[] EncryptOrDecryptData(bool encrypt, byte[] buffer, bool useLegacyMode)
        {
            return MachineKeySection.EncryptOrDecryptData(encrypt, buffer, null, 0, buffer.Length, false, useLegacyMode, IVType.None, false);
        }

        public bool IsDecryptionKeyAutogenerated
        {
            get
            {
                return MachineKeySection.IsDecryptionKeyAutogenerated;
            }
        }

        public MembershipProviderCollection Providers
        {
            get
            {
                return Membership.Providers;
            }
        }

        public int UserIsOnlineTimeWindow
        {
            get
            {
                return Membership.UserIsOnlineTimeWindow;
            }
        }

        public bool UsingCustomEncryption
        {
            get
            {
                return MachineKeySection.UsingCustomEncryption;
            }
        }
    }
}

