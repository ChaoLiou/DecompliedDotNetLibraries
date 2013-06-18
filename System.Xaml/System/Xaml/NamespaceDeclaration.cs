﻿namespace System.Xaml
{
    using System;
    using System.Diagnostics;

    [DebuggerDisplay("Prefix={Prefix} Namespace={Namespace}")]
    public class NamespaceDeclaration
    {
        private string ns;
        private string prefix;

        public NamespaceDeclaration(string ns, string prefix)
        {
            this.ns = ns;
            this.prefix = prefix;
        }

        public string Namespace
        {
            get
            {
                return this.ns;
            }
        }

        public string Prefix
        {
            get
            {
                return this.prefix;
            }
        }
    }
}

